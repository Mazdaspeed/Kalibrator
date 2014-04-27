using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Kalibrator.Utility;

namespace Kalibrator.Data
{
    public class LogFile
    {
        #region Private Members

        private string _logFilePath = null;

        private List<LogEntry> _logEntries = null;

        #endregion

        #region Public Properties

        public string LogFilePath
        {
            get { return _logFilePath; }
        }

        public int LogEntryCount
        {
            get
            {
                if (_logEntries != null)
                {
                    return _logEntries.Count;
                }
                else
                {
                    return 0;
                }
            }
        }

        public List<LogEntry> LogEntries
        {
            get { return _logEntries; }
        }

        #endregion

        #region Constructor

        public LogFile(string logFilePath)
        {
            _logFilePath = logFilePath;
        }

        #endregion

        #region Load File

        public bool LoadFile()
        {
            bool result = true;
            TickProfiler profiler = new TickProfiler();
            profiler.Start();
            StreamReader inputStream = null;

            try
            {
                if (File.Exists(_logFilePath))
                {
                    _logEntries = new List<LogEntry>();
                    inputStream = new StreamReader(_logFilePath);
                    string firstLine = inputStream.ReadLine();
                    List<string> firstLineSplit = firstLine.Split(',').ToList();
                    
                    string line;
                    while ((line = inputStream.ReadLine()) != null)
                    {
                        LogEntry entry = new LogEntry(line);
                        entry.Parse(firstLineSplit);
                        _logEntries.Add(entry);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                result = false;
            }
            finally
            {
                if (inputStream != null)
                {
                    inputStream.Close();
                    inputStream.Dispose();
                    inputStream = null;
                }
            }

            profiler.LogElapsed("Loading File");
            return result;
        }

        #endregion

        #region ToString Override

        public override string ToString()
        {
            return _logFilePath;
        }

        #endregion
    }
}
