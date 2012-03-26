using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Settings
{
    public class Settings
    {
        protected string autostartFilePath = Environment.GetFolderPath(
            Environment.SpecialFolder.Startup
        ) + "\\textEimer.url";
        protected string appDataDirectory = Environment.GetFolderPath(
            Environment.SpecialFolder.ApplicationData
        ) + "/TextEimer";
        protected Dictionary<string,string> settings = new Dictionary<string,string>();

        public Settings()
        {
            settings.Add("version", System.Windows.Forms.Application.ProductVersion);
            settings.Add("itemCount", "20");
        }

        /// <summary>
        /// create Autostart Shortcut
        /// </summary>
        protected void addShortcutToAutostart()
        {
            using (StreamWriter writer = new StreamWriter(autostartFilePath))
            {
                string app = System.Reflection.Assembly.GetExecutingAssembly().Location;
                writer.WriteLine("[InternetShortcut]");
                writer.WriteLine("URL=file:///" + app);
                writer.WriteLine("IconIndex=0");
                string icon = app.Replace('\\', '/');
                writer.WriteLine("IconFile=" + icon);
                writer.Flush();
            }
        }

        protected void createAppDataDirectory()
        {
            if (!Directory.Exists(appDataDirectory))
            {
                Directory.CreateDirectory(appDataDirectory);
            }
        }

        public Dictionary<string, string> currentOptions
        {
            get
            {
                return settings;
            }
            set
            {
                settings = value;
            }
        }
    }
}
