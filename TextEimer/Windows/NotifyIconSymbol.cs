﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TextEimer.Windows
{
    class NotifyIconSymbol
    {
        private NotifyIcon notifyIcon;
        
        /// <summary>
        /// Contructor of NotifyIconSymbol class
        /// This class handles the NotifyIcon functionality
        /// </summary>
        /// <param name="notifyIcon">A NotifyIcon object</param>
        public NotifyIconSymbol(NotifyIcon notifyIcon)
        {
            this.notifyIcon = notifyIcon;
        }

        /// <summary>
        /// shows the ContextMenuStrip of the NotifyIcon with its options and clipboard history
        /// </summary>
        public void ShowNotifyIconMenu()
        {
            this.notifyIcon.ContextMenuStrip.Focus();
            this.notifyIcon.ContextMenuStrip.Show(Cursor.Position.X, Cursor.Position.Y);
            this.notifyIcon.ContextMenuStrip.BringToFront();
        }
    }
}
