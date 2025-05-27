using System;
using System.IO;

namespace Tools
{
    public static class LogManager
    {
        private static readonly string LogDirectoryName = "Log"; 

        private static string AppBaseDirectory => AppContext.BaseDirectory;

        private static string GetRootLogDirectoryPath()
        {
            string rootPath = Path.Combine(AppBaseDirectory, LogDirectoryName);
            if (!Directory.Exists(rootPath))
            {
                Directory.CreateDirectory(rootPath);
            }
            return rootPath;
        }

        private static string GetMonthlyLogDirectoryPath()
        {
            string rootPath = GetRootLogDirectoryPath();
         
            if (!Directory.Exists(rootPath))
            {
                Directory.CreateDirectory(rootPath);
            }
            return rootPath;
        }

        private static string GetDailyLogFilePath()
        {
            string monthlyPath = GetMonthlyLogDirectoryPath();
            string fileName = $"Log_{DateTime.Now.Year}_{DateTime.Now.Month:00}_{DateTime.Now.Day:00}.txt";
            string filePath = Path.Combine(monthlyPath, fileName);

            return filePath;
        }

        public static void WriteToLog(string nameOfProject, string message)
        {
            try
            {
                string logFilePath = GetDailyLogFilePath();
                using (StreamWriter sw = new StreamWriter(logFilePath, true))
                {
                    sw.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}\t{nameOfProject}:\t{message}");
                }
            }
            catch (Exception ex)
            {
                // This line will definitely tell you if an error occurred.
                System.Diagnostics.Debug.WriteLine($"LOG ERROR: {ex.GetType().Name} - {ex.Message}");
                // You could also try writing to a different, simple file path as a last resort:
                // File.WriteAllText("C:\\Temp\\LogManagerError.txt", $"Error at {DateTime.Now}: {ex.Message}\nStackTrace:\n{ex.StackTrace}");
            }
        }

        public static void CleanLog(int yearsToKeep = 1) 
        {
            try
            {
                string rootLogPath = GetRootLogDirectoryPath();
                string[] yearDirectories = Directory.GetDirectories(rootLogPath);

                foreach (string yearDir in yearDirectories)
                {
                    string yearDirName = Path.GetFileName(yearDir);

                    if (int.TryParse(yearDirName, out int year))
                    {
                        if (year < DateTime.Now.Year - yearsToKeep)
                        {
                            Console.WriteLine($"Deleting old log directory: {yearDir}");
                            Directory.Delete(yearDir, true); 
                        }
                        else if (year == DateTime.Now.Year - yearsToKeep)
                        {
                            string[] monthDirectories = Directory.GetDirectories(yearDir);
                            foreach (string monthDir in monthDirectories)
                            {
                                string monthDirName = Path.GetFileName(monthDir);
                                if (int.TryParse(monthDirName, out int month))
                                {
                                    if (month < DateTime.Now.Month)
                                    {
                                        Console.WriteLine($"Deleting old log directory: {monthDir}");
                                        Directory.Delete(monthDir, true);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"ERROR: Failed to clean log files. Details: {ex.Message}");
            }
        }
    }
}