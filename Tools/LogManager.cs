using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Tools
{
    public static class LogManager
    {
        private static string LOG = "Log";
        private static int COUNTER = 0;

        public static string GetRoutingMonth()
        {
            return LOG + "/" + DateTime.Now.Month.ToString();
        }
        public static string GetRoutingDay()
        {
            return GetRoutingMonth() + "/" + DateTime.Now.Day.ToString() + ".txt";
        }

        public static void Enter()
        {
            COUNTER++;
        }
        public static void Exit()
        {

            COUNTER--;


        }
        public static string GetTab()
        {
            string s = "";
            for (int i = 0; i < COUNTER; i++)
            {
                s += " ";
            }
            return s;
        }

        public static void WriteToLog(string projectName, string functionName, string message)
        {

            if (!Directory.Exists(GetRoutingMonth()))
                Directory.CreateDirectory(GetRoutingMonth());
            if (!File.Exists(GetRoutingDay()))
                File.Create(GetRoutingDay()).Close();
            using (StreamWriter current = new StreamWriter(GetRoutingDay(), true))
            {
                current.WriteLine($"{GetTab}{DateTime.Now}\t{projectName}\t{functionName}\t{message}");
            }

        }
        public static void deleteOldFolder()
        {
            string[] subDirectories = Directory.GetDirectories(LOG);

            for (int i = 0; i < subDirectories.Length - 2; i++)
            {
                int monthBefore;
                string monthCurrent = subDirectories[i].Substring(subDirectories[i].Length - 2);
                if (DateTime.Now.Month == 1)
                    monthBefore = 12;
                else
                     monthBefore = DateTime.Now.Month - 1;
                if (monthCurrent != DateTime.Now.Month.ToString() && monthCurrent != monthBefore.ToString())
                    Directory.Delete(subDirectories[i], true);
            }

        }


    }

}
