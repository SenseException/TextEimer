using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TextEimer.Windows
{
    class NotifyIconSymbol
    {
        private NotifyIcon notifyIcon;
        private NotifyIconMenu notifyIconMenu;
        
        /// <summary>
        /// Contructor of NotifyIconSymbol class
        /// This class handles the NotifyIcon functionality
        /// </summary>
        /// <param name="notifyIcon">A NotifyIcon object</param>
        public NotifyIconSymbol(NotifyIcon notifyIcon, NotifyIconMenu notifyIconMenu)
        {
            this.notifyIcon = notifyIcon;
            this.notifyIconMenu = notifyIconMenu;
        }

        /// <summary>
        /// shows the ContextMenuStrip of the NotifyIcon with its options and clipboard history
        /// </summary>
        public void ShowNotifyIconMenu()
        {
            if (null != this.notifyIconMenu.FocusHandler)
            {
            	this.notifyIconMenu.FocusHandler.GetFocusedWindow();
            }
            this.notifyIconMenu.BuildContextMenuStrip();
            this.notifyIcon.ContextMenuStrip.Show(Cursor.Position.X, Cursor.Position.Y);
            if (null != this.notifyIconMenu.FocusHandler)
            {
                this.notifyIconMenu.FocusHandler.SetFocusedWindow(new System.Runtime.InteropServices.HandleRef(this.notifyIcon.ContextMenuStrip, this.notifyIcon.ContextMenuStrip.Handle));
            }
            else
            {
                this.notifyIcon.ContextMenuStrip.BringToFront();
                this.notifyIcon.ContextMenuStrip.Focus();
            }
        }
    }
}
