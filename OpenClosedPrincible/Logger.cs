using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincible
{
    public class Logger
    {
        private readonly ILogger logger;
        public Logger(ILogger _logger)
        {
            logger = _logger;
        }

        public void Log(string value)
        {
            logger.Log(value);
        }


        #region Old Code
        //private readonly XmlLog xmlLog;
        //private readonly DbLog dbLog;
        //private readonly FileLog fileLog;
        //public Logger(XmlLog _xmlLog, DbLog _dbLog, FileLog _fileLog)
        //{
        //    xmlLog = _xmlLog;
        //    dbLog = _dbLog;
        //    fileLog = _fileLog;
        //}

        //public void Log(LogType type, string value)
        //{
        //    switch (type)
        //    {
        //        case LogType.Xml:
        //            xmlLog.Log(value);
        //            break;
        //        case LogType.Db:
        //            dbLog.Log(value);
        //            break;
        //        case LogType.File:
        //            fileLog.Log(value);
        //            break;
        //    }
        //} 
        #endregion
    }
}
