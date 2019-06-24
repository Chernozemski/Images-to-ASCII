using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
namespace ImageToASCII.TextActions
{
    class TxtActions
    {
        private static string SaveFilePath;
        private static string FolderPath = Environment.CurrentDirectory + "\\ASCII images";
        public static void CreateTxt()
        {

            StreamWriter wr = new StreamWriter(SaveFilePath);
            wr.Close();

        }
        public static void OpenFolder()
        {
            Process.Start("explorer.exe", "/open," + FolderPath);
        }
        public static string GetFileName(string fileName)
        {
            SaveFilePath = FolderPath + "\\ASCII - " + fileName + ".txt";
            return SaveFilePath;
        }
    }
}
