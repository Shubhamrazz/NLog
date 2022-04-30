﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Analog
{
    class NLog
    {
        public Logger logger = LogManager.GetCurrentClassLogger();
        public void LogDebug(string input)
        {
            logger.Debug(input);
        }

        public void LogError(string input)
        {
            logger.Error(input);
        }

        public void LogWarn(string input)
        {
            logger.Warn(input);
        }

        public void LogInfo(string input)
        {
            logger.Info(input);
        }
    }
}
