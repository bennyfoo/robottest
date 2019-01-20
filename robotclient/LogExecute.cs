﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace robotclient
{
    internal class LogExecute
    {

        static string LogPath = Application.StartupPath + Properties.Settings.Default.LogPath;

        public const string ExceptionTag = "ExceptionTag";


        public static void WriteInfoLog(string Message, bool IsSucc)
        {
            string s = IsSucc ? "成功" : "失败";
            WriteInfoLog(Message + ",操作结果[" + s + "]");
        }

        public static void WriteDBExceptionLog(Exception ex)
        {
            WriteExceptionLog("DBExecute",ex);
        
        }

        public static void WriteExceptionLog(string tile, Exception ex)
        {
            try
            {
                if (ex != null && ex.Message != ExceptionTag)
                {
                    StringBuilder sb = new StringBuilder();
                    string NowDateTime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff");
                    sb.AppendLine(string.Format("****************************{0},Exception[{1}]****************************", NowDateTime, tile));
                    sb.AppendLine(ex.ToString());
                    WriteLogExecute("Exception", sb.ToString());
                }
            }
            catch
            {
            }
        }

        public static void WriteInfoLog(string Message)
        {
            WriteLogExecute("Info", System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff") + "  " + Message);
        }

        public static void WriteLineDataLog(string Message)
        {
            WriteLogExecute("Data", System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff") + "  " + Message);
        }



        static void WriteLogExecute(string FileName, string Message)
        {
            //如果日志文件目录不存在,则创建
            if (!Directory.Exists(LogPath))
            {
                Directory.CreateDirectory(LogPath);
            }
            string filename = LogPath + "\\" + FileName + "_" + System.DateTime.Now.ToString("yyyyMMdd") + ".txt";

            try
            {
                FileStream fs = new FileStream(filename, FileMode.Append);
                StreamWriter strwriter = new StreamWriter(fs);
                try
                {
                    strwriter.WriteLine(Message);
                    strwriter.Flush();
                }
                catch
                {

                }
                finally
                {
                    strwriter.Close();
                    strwriter = null;
                    fs.Close();
                    fs = null;
                }
            }
            catch
            {
            }
        }


    }
}
