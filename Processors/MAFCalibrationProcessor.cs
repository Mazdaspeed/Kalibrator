using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Kalibrator.Data;

namespace Kalibrator.Processors
{
    public class MafCalibrationProcessor : IProcessor
    {
        public OutputData Process(FormData inputData, List<LogFile> logFiles)
        {
            OutputData result = null;

            foreach (LogFile logFile in logFiles)
            {
                // Give me the list of log entries sorted by maf voltage ascending
                var sortedEntries = logFile.LogEntries.OrderBy(t => t.MAFVoltage);

                // Give me the list of log entries that have knock retard and sort by the highest knock
                var knockEntries = logFile.LogEntries.Where(t => t.KnockRetard.Value > 0).OrderByDescending(s => s.KnockRetard);
            }

            // Give me groups of maf voltages from all logs
            var mafVoltages = logFiles.SelectMany(files => files.LogEntries, (file, entry) => new { file, entry })
                                        .GroupBy(pair => pair.entry.MAFVoltage.Value, pair => pair.entry);

            foreach (IGrouping<float, LogEntry> groupOfEntries in mafVoltages)
            {
                List<float> flows = new List<float>();
                foreach (LogEntry entry in groupOfEntries)
                {
                    // Do some calculations
                    float adjustedFlow = entry.MassAirflow.Value / entry.LTFT.Value;
                    flows.Add(adjustedFlow);
                }

                // Pull an average
                float adjustedFlowAverage = flows.Average();
            }

            return result;
        }
    }
}
