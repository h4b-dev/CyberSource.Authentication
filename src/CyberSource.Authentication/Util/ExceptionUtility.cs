﻿using NLog;

namespace CyberSource.Authentication.Util
{
    // TODO: remove here dependency from NLog and sue more common logger if needed

    public static class ExceptionUtility
    {
        private static bool _exceptionIsCaughtAlready;

        public static void Exception(string exceptionMessage, string stackTrace)
        {
            Logger currentClassLogger = LogManager.GetCurrentClassLogger();
            if (ExceptionUtility._exceptionIsCaughtAlready)
                return;
            if (!string.IsNullOrEmpty(exceptionMessage))
            {
                currentClassLogger.Error(exceptionMessage);
                if (!string.IsNullOrEmpty(stackTrace))
                    currentClassLogger.Trace(stackTrace);
            }

            ExceptionUtility._exceptionIsCaughtAlready = true;
        }
    }
}
