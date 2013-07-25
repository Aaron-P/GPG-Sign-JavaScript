using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using GpgApi;

namespace GPG_Sign_JavaScript
{
    static class Program
    {
        private const string gpgRegKey   = "HKEY_LOCAL_MACHINE\\SOFTWARE\\GNU\\GnuPG";
        private const string gpgRegValue = "Install Directory";
        private const string gpgExeName  = "gpg.exe";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static string gpgGetPath()
        {
            Object gpgDirectory = Registry.GetValue(gpgRegKey, gpgRegValue, null);
            if (gpgDirectory == null)
                return null;

            string gpgPath = gpgDirectory.ToString();
            if (!gpgPath.EndsWith("\\"))
                gpgPath += "\\";
            gpgPath += gpgExeName;

            if (gpgIsValid(gpgPath))
                return gpgPath;
            return null;
        }

        public static bool gpgIsValid(string gpgPath)
        {
            if (Path.GetFileName(gpgPath).ToLower() != gpgExeName || !File.Exists(gpgPath))
                return false;

            //Should these be unset after use?
            GpgInterface.ExePath = gpgPath;
            GpgInterface.SynchronizationContext = WindowsFormsSynchronizationContext.Current;
            GpgVersion version = new GpgVersion();
            version.Execute();

            if (version.Version != null)
                return true;
            return false;
        }

        public static string changeLineEndings(string inputText, string lineEnding = "\n")
        {
            string[] lineEndings = {"\r\n", "\n"};
            string[] outputText = inputText.Split(lineEndings, StringSplitOptions.None);
            return String.Join(lineEnding, outputText);
        }







        //Put these in form cs?
        public static void autoSizeListViewColumns(ListView listViewObject)
        {
            listViewObject.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewObject.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }


    }
}
