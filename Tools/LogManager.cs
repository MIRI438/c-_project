using System;
using System.IO;

namespace Tools
{
    public static class LogManager
    {
        private static readonly string Path = "Log";

        /// <summary>
        /// פונקיצה להחזרת הניותב של התיקיה
        /// </summary>
        private static string GetFolderPath()
        {
            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory($"{DateTime.Now.Year}_{DateTime.Now.Month}");
            }

            return Path;
        }

        /// <summary>
        /// פונקיצה להחזרת הניתוב של הקובץ
        /// </summary>
        private static string GetFilePath()
        {
            string folderPath = GetFolderPath(); 
            string filePath = @$"{folderPath}\Log_{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}.txt";

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            return filePath;
        }
        

        /// <summary>
        /// פונקציה לכתיבת הלוגים
        /// </summary>
        public static void WriteToLog(string nameOfProject, string message)
        {
            string logFilePath = GetFilePath(); 
            using (StreamWriter sw = new StreamWriter(logFilePath, true))
            {
                sw.WriteLine($"{DateTime.Now}\t{nameOfProject}:\t{message}");
            }
        }


        /// <summary>
        /// פונקציה לניקוי הלוגיים הישנים
        /// </summary>
        public static void CleanLog()
        {
            string[] subDirectories = Directory.GetDirectories(Path);
            foreach (string Dir in subDirectories)
            {
                if (int.TryParse(Dir.Substring(0, 4), out int year) && year < DateTime.Now.Year)
                {
                    Directory.Delete(Dir,true);
                }
                else if (int.TryParse(Dir.Substring(5, Dir.Length), out int month) && year == DateTime.Now.Year && month < DateTime.Now.Month)
                {
                    Directory.Delete(Dir,true);
                }
            }
        }

    }
    
}
