using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Kalibrator.Data;

namespace Kalibrator.Processors
{
    public interface IProcessor
    {
        OutputData Process(FormData inputData, List<LogFile> logFiles);
    }
}
