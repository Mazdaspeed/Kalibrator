using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

using Kalibrator.Data;
using Kalibrator.Processors;
using Kalibrator.Utility;

namespace Kalibrator
{
    public partial class MainForm : Form
    {
        #region Private Members

        private List<LogFile> _logFiles = null;

        #endregion

        #region Constructor

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Button Event Handlers

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (_logFiles == null)
            {
                _logFiles = new List<LogFile>();
            }

            DisableForm();

            Thread loadThread = new Thread(LoadThread);
            loadThread.IsBackground = true;
            loadThread.Name = "Load Thread";
            loadThread.Start();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Load Log File";
            fileDialog.FileName = "";
            fileDialog.Filter = "DataLog (*.csv)|*.csv";
            DialogResult result = fileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                if (fileDialog.FileName != string.Empty)
                {
                    if (File.Exists(fileDialog.FileName))
                    {
                        tbLogFilePath.Text = fileDialog.FileName;
                    }
                }
            }   
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (_logFiles == null || _logFiles.Count == 0)
            {
                MessageBox.Show("No logs loaded");
                return;
            }

            DisableForm();

            Thread processThread = new Thread(ProcessThread);
            processThread.IsBackground = true;
            processThread.Name = "Processor Thread";
            processThread.Start();
        }

        #endregion

        #region Threads

        private void LoadThread()
        {
            if (File.Exists(tbLogFilePath.Text))
            {
                LogFile newFile = new LogFile(tbLogFilePath.Text);
                newFile.LoadFile();

                _logFiles.Add(newFile);

                AddToList(string.Format("{0}  [Entries: {1}]",newFile.LogFilePath, newFile.LogEntryCount));
            }
            else
            {
                MessageBox.Show("File does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }

            EnableForm();
        }

        private void ProcessThread()
        {
            TickProfiler profiler = new TickProfiler();

            if (_logFiles != null)
            {
                FormData data = GetFormData();

                IProcessor processor = new MafCalibrationProcessor();                
                OutputData outputData = processor.Process(data, _logFiles);

                DisplayOutput(outputData);
            }

            profiler.LogElapsed("Processing");

            MessageBox.Show("Processing Complete");
            EnableForm();
        }

        #endregion

        #region Form Methods and Delegates

        private FormData GetFormData()
        {
            FormData data = new FormData();

            try
            {
                data.OpenLoopAPP = Convert.ToInt32(tbAcceleratorPosition.Text);
                data.OpenLoopLoad = Convert.ToSingle(tbLoad.Text);
                
                System.Collections.Specialized.StringCollection mafBreakpoints = Properties.Settings.Default.MafBreakpoints;
                List<string> mafValues = tbCurrentMAFCalibration.Text.Split('\t').ToList();

                // Check to make sure we have enough maf values for our breakpoints
                if (mafBreakpoints.Count == mafValues.Count)
                {
                    data.MafValues = new Dictionary<float,float>();
                    for (int i = 0; i < mafBreakpoints.Count; i++)
                    {
                        data.MafValues.Add(Convert.ToSingle(mafBreakpoints[i]), Convert.ToSingle(mafValues[i]));
                    }
                }

                System.Collections.Specialized.StringCollection wotAfrBreakpoints = Properties.Settings.Default.WotAfrBreakpoints;
                List<string> wotAfrValues = tbAFRTargets.Text.Split('\t').ToList();

                // Check to make sure we have enough wot afr values for our breakpoints
                if (wotAfrBreakpoints.Count == wotAfrValues.Count)
                {
                    data.WotAFRValues = new Dictionary<float, float>();
                    for (int i = 0; i < wotAfrBreakpoints.Count; i++)
                    {
                        data.WotAFRValues.Add(Convert.ToSingle(wotAfrBreakpoints[i]), Convert.ToSingle(wotAfrValues[i]));
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                data = null;
            }

            return data;
        }

        private delegate void DisplayOutputDelegate(OutputData data);

        private void DisplayOutput(OutputData data)
        {
            if (InvokeRequired)
            {
                this.Invoke(new DisplayOutputDelegate(DisplayOutput), data);
            }
            else
            {
                tbProcessingOutput.Text = data.GetDisplayedOutput();
            }
        }

        private delegate void AddDelegate(string filename);

        private void AddToList(string fileName)
        {
            if (InvokeRequired)
            {
                this.Invoke(new AddDelegate(AddToList), fileName);
            }
            else
            {
                lbLogFiles.Items.Add(fileName);
            }
        }

        private delegate void SimpleDelegate();

        private void EnableForm()
        {
            if (InvokeRequired)
            {
                this.Invoke(new SimpleDelegate(EnableForm));
            }
            else
            {
                gbOpenLoopTransition.Enabled = true;
                gbLogFile.Enabled = true;
                gbCurrentMAFCalibration.Enabled = true;
                gbAFRTargets.Enabled = true;
                gbProcessingOutput.Enabled = true;
                btnProcess.Enabled = true;
                Application.DoEvents();
            }
        }

        private void DisableForm()
        {
            if (InvokeRequired)
            {
                this.Invoke(new SimpleDelegate(DisableForm));
            }
            else
            {
                gbOpenLoopTransition.Enabled = false;
                gbLogFile.Enabled = false;
                gbCurrentMAFCalibration.Enabled = false;
                gbAFRTargets.Enabled = false;
                gbProcessingOutput.Enabled = false;
                btnProcess.Enabled = false;
                Application.DoEvents();
            }
        }

        #endregion
    }
}
