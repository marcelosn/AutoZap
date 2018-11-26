using Microsoft.Win32;
using SQLiteBAL.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLiteBAL.Common
{
    public class Util 
    {
        public string BackupDatabase()
        {
            string _newfile = "";
            try
            {
                SqlDao dao = new SqlDao();

                System.IO.Directory.CreateDirectory("backup");
                _newfile = "backup/" + "backup_" + DateTime.Now.ToString("_yyyyMMdd_") + dao.DatabaseFile;
                if (!System.IO.File.Exists(_newfile))
                {
                    System.IO.File.Copy(dao.DatabaseFile, _newfile);
                }

                return _newfile;
            }
            catch (Exception ex)
            {
                return "";
            }

        }

        public string GetFrameworkDirectory()
        {
            // This is the location of the .Net Framework Registry Key
            string framworkRegPath = @"Software\Microsoft\.NetFramework";

            // Get a non-writable key from the registry
            RegistryKey netFramework = Registry.LocalMachine.OpenSubKey(framworkRegPath, false);

            // Retrieve the install root path for the framework
            string installRoot = netFramework.GetValue("InstallRoot").ToString();

            // Retrieve the version of the framework executing this program
            string version = string.Format(@"v{0}.{1}.{2}\",
              Environment.Version.Major,
              Environment.Version.Minor,
              Environment.Version.Build);

            // Return the path of the framework
            return System.IO.Path.Combine(installRoot, version);
        }


        
    }
}
