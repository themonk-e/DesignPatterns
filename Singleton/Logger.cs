using System.Collections.Generic;

namespace designPatterns.problem
{
    public class Logger
    {

        //private constructor

        private Logger() { }

        private static readonly object _syncLock = new object();
        private  List<string> logList = new List<string>();

        private static Logger _loggerInstance;

        public static Logger getInstance()
        {
            if (_loggerInstance == null)
            {
                  lock (_syncLock)
            {
                if (_loggerInstance == null)
                {
                    _loggerInstance = new Logger();
                }
            }
            }

          

            return _loggerInstance;
        }

        public List<string> AddToLog(string logMessage)
        {
            logList.Add(logMessage);
            return logList;
        }
        


   }

}