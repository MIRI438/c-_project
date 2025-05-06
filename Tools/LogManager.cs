using System;
using System.IO;

namespace Tools
{
    public static class LogManager
    {
        private static readonly string LogDirectoryPath = "Log";

        private static string GetFolderPath()
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, LogDirectoryPath);
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            return folderPath;
        }

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

        public static void WriteToLog(string nameOfProject, string message)
        {
            string logFilePath = GetFilePath();
            using (StreamWriter sw = new StreamWriter(logFilePath, true))
            {
                sw.WriteLine($"{DateTime.Now}\t{nameOfProject}:\t{message}");
            }
        }

        public static void CleanLog()
        {
            string[] subDirectories = Directory.GetDirectories(LogDirectoryPath);
            foreach (string Dir in subDirectories)
            {
                if (int.TryParse(Dir.Substring(0, 4), out int year) && year < DateTime.Now.Year)
                {
                    Directory.Delete(Dir, true);
                }
                else if (int.TryParse(Dir.Substring(5, Dir.Length), out int month) && year == DateTime.Now.Year && month < DateTime.Now.Month)
                {
                    Directory.Delete(Dir, true);
                }
            }
        }
    }
}
