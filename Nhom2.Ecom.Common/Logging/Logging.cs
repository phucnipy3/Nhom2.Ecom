using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using Nhom2.Ecom.Constants;

namespace Nhom2.Ecom.Common.Logging
{
    public static class Logging<T> where T : class
    {
        private const string INFO = "INFO";
        private const string ERROR = "ERROR";
        private const string WARNING = "WARNING";
        private const string path = "./Logger/";
        private const string Filename = "Log-{0}.txt";
        public static void Information(params string[] message)
        {
            WritelLog(INFO, message);
        }

        public static void Error(params string[] message)
        {
            WritelLog(ERROR, message);
        }

        public static void Error(Exception ex, params string[] message)
        {
            WritelLog(ERROR, string.Join("||", message),
                "Message: " + ex.Message,
                "Inner: " + (ex.InnerException != null ? ex.InnerException.Message : "No inner"),
                "StackTrace: " + (ex.StackTrace != null ? ex.StackTrace : "No StackTrace"),
                "Source: " + (ex.Source != null ? ex.Source : "No Source"));
        }

        public static void Warning(params string[] message)
        {
            WritelLog(WARNING, message);
        }

        private static void WritelLog(string logType, params string[] message)
        {
            try
            {
                DateTime datetime = DateTime.Now;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (StreamWriter fs = File.AppendText(string.Format(path + Filename, datetime.ToString(DateFormat.DateFormatStandard))))
                {
                    var logContent = logType + "[" + datetime.ToString(DateFormat.DateTimeFormat) + "]:: " + typeof(T).Name + ":: " + string.Join("||", message) + "[ENDLOG]";
                    fs.WriteLine(logContent);
                }
            }
            catch (Exception ex)
            {
                try
                {
                    Thread.Sleep(5000);
                    WritelLog(logType, message);
                }
                catch
                {
                    Error(ex, message);
                }
            }
        }
    }
}
