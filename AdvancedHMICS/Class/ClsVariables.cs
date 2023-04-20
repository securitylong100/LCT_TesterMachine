using System.IO;
using System.Text;

namespace AdvancedHMICS.Class
{
    public static class ClsVariables
    {
        public const string FOLDER_APP = @"C:\LCT\";
        public const string FOLDER_LOGS = @"C:\LCT\Logs";
        public const string FILE_CONFIG = @"C:\LCT\configuration.txt";
        public const string FILE_DB_CONFIG = @"C:\LCT\connectsql_LCT_IFM.txt";
        public static string User { get; set; } = string.Empty;
        public static string Line { get; set; } = "N/A";
        public static string Machine { get; set; } = "N/A";
        public static string HistoryDays { get; set; } = "300";
        public static string FolderBrowser { get; set; } = FOLDER_APP;
        public static int AutoBackupCounter { get; set; } = 60000; // ms

        public static void ReadConfigFile()
        {
            try
            {
                bool exists = File.Exists(FILE_CONFIG);
                if (!exists) return;
                string[] datarow = File.ReadAllLines(FILE_CONFIG);
                FolderBrowser = datarow[0];
                Line = datarow[1];
                Machine = datarow[2];
                AutoBackupCounter = int.Parse(datarow[3]);
                HistoryDays = datarow[4];
            }
            catch
            {

            }
        }

        public static void WriteConfigFile()
        {
            try
            {
                bool exists = File.Exists(FILE_CONFIG);
                if (exists)
                    File.Delete(FILE_CONFIG);

                StringBuilder sb = new StringBuilder();
                sb.Append(FolderBrowser);
                sb.Append("\n");
                sb.Append(Line);
                sb.Append("\n");
                sb.Append(Machine);
                sb.Append("\n");
                sb.Append(AutoBackupCounter);
                sb.Append("\n");
                sb.Append(HistoryDays);
                File.AppendAllText(FILE_CONFIG, sb.ToString());
            }
            catch
            {

            }
        }
    }
}
