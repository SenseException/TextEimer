using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace TextEimer.Config
{
    // TODO create own config format in later versions
    public class Settings
    {   
        public Settings()
        {
            if (!Properties.Settings.Default.Updated)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.Updated = true;
                Properties.Settings.Default.Save();
            }
        }

        public int MenuItemAmount
        {
            get
            {
                return Properties.Settings.Default.MenuItemAmount;
            }
            set
            {
                Properties.Settings.Default.MenuItemAmount = value;
            }
        }

        public bool AutostartOn
        {
            get
            {
                return Properties.Settings.Default.AutostartOn;
            }
            set
            {
                Properties.Settings.Default.AutostartOn = value;
            }
        }

        public bool OrderDesc
        {
            get
            {
                return Properties.Settings.Default.OrderDesc;
            }
            set
            {
                Properties.Settings.Default.OrderDesc = value;
            }
        }

        public bool LoggingOn
        {
            get
            {
                return Properties.Settings.Default.LoggingOn;
            }
            set
            {
                Properties.Settings.Default.LoggingOn = value;
            }
        }

        public int MenuPosX
        {
            get
            {
                return Properties.Settings.Default.MenuPosX;
            }
            set
            {
                Properties.Settings.Default.MenuPosX = value;
            }
        }

        public int MenuPosY
        {
            get
            {
                return Properties.Settings.Default.MenuPosY;
            }
            set
            {
                Properties.Settings.Default.MenuPosY = value;
            }
        }

        public void Save()
        {
            Properties.Settings.Default.Save();
        }
    }
}
