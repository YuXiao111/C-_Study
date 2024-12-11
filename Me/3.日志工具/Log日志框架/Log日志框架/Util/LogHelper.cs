using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Log日志框架.Util
{
    /// <summary>
    /// 日志帮助类
    /// </summary>
    public class LogHelper
    {
        #region 输出日志到Log4Net

        /// <summary>
        /// 输出日志到Log4Net
        /// </summary>
        /// <param name="t"></param>
        /// <param name="ex">异常对象</param>
        /// <param name="level">日志等级，默认为：1 Debug 级</param>
        public static void WriteLog(Type t, Exception ex, LogLevel level = LogLevel.DEBUG)
        {
            WriteLog(t, ex.Message, level);
        }

        #endregion

        #region 输出日志到Log4Net

        /// <summary>
        /// 输出日志到Log4Net
        /// </summary>
        /// <param name="t"></param>
        /// <param name="msg">错误信息</param>
        /// <param name="level">日志等级，默认为：1 Debug 级</param>
        public static void WriteLog(Type t, string msg, LogLevel level = LogLevel.DEBUG)
        {
            // 对应日志信息中的“%property{UserName}”
            //log4net.ThreadContext.Properties["UserName"] = "Test";

            log4net.ILog log = log4net.LogManager.GetLogger(t);
            switch (level)
            {
                // 日志等级：OFF > FATAL > ERROR > WARN > INFO > DEBUG  > ALL
                case LogLevel.DEBUG:
                    log.Debug(msg);
                    break;
                case LogLevel.INFO:
                    log.Info(msg);
                    break;
                case LogLevel.WARN:
                    log.Warn(msg);
                    break;
                case LogLevel.ERROR:
                    log.Error(msg);
                    break;
                case LogLevel.FATAL:
                    log.Fatal(msg);
                    break;
                default:
                    log.Debug(msg);
                    break;
            }
        }

        #endregion

    }

    /// <summary>
    /// 日志等级：
    /// OFF > FATAL > ERROR > WARN > INFO > DEBUG  > ALL
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// ALL
        /// </summary>
        ALL = 0,

        /// <summary>
        /// DEBUG
        /// </summary>
        DEBUG = 1,

        /// <summary>
        /// INFO
        /// </summary>
        INFO = 2,

        /// <summary>
        /// WARN
        /// </summary>
        WARN = 3,

        /// <summary>
        /// ERROR
        /// </summary>
        ERROR = 4,

        /// <summary>
        /// FATAL
        /// </summary>
        FATAL = 5,

        /// <summary>
        /// OFF
        /// </summary>
        OFF = 6
    }

}
