﻿using EveryLogSource.LogTypes;
using System.Diagnostics.Tracing;

namespace EveryLogSource.Events
{
    [EventSource(Name="AdvWrksLogs")]
    public class EveryLoggerSource : EventSource
    {
        public static readonly EveryLoggerSource Log = new EveryLoggerSource();        

        [Event(GlobalType.GlobalCritical, Message = "Global Critical: {0}", Level = EventLevel.Critical)]
        public void Critical(string message)
        {            
            if (IsEnabled()) WriteEvent(GlobalType.GlobalCritical, message);
        }

        [Event(GlobalType.GlobalError, Message = "Global Error {0}", Level = EventLevel.Error)]
        public void Error(string message)
        {
            if (IsEnabled()) WriteEvent(GlobalType.GlobalError, message);
        }

        [Event(GlobalType.GlobalInformational, Message = "Global Informational {0}", Level = EventLevel.Informational)]
        public void Informational(string message)
        {
            if (IsEnabled()) WriteEvent(GlobalType.GlobalInformational, message);
        }

        [Event(GlobalType.GlobalLogAlways, Message = "Global LogAlways {0}", Level = EventLevel.LogAlways)]
        public void LogAlways(string message)
        {
            if (IsEnabled()) WriteEvent(GlobalType.GlobalLogAlways, message);
        }

        [Event(GlobalType.GlobalVerbose, Message = "Global Verbose {0}", Level = EventLevel.Verbose)]
        public void Verbose(string message)
        {
            if (IsEnabled()) WriteEvent(GlobalType.GlobalVerbose, message);
        }

        [Event(GlobalType.GlobalWarning, Message = "Global Warning {0}", Level = EventLevel.Warning)]
        public void Warning(string message)
        {
            if (IsEnabled()) WriteEvent(GlobalType.GlobalWarning, message);
        }
    }
}