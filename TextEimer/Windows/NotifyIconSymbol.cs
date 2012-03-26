using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TextEimer.Windows
{
    class NotifyIconSymbol
    {
        private NotifyIcon notifyIcon;
        
        public NotifyIconSymbol(NotifyIcon notifyIcon)
        {
            this.notifyIcon = notifyIcon;
        }

        public void ShowNotifyIconMenu()
        {
            this.notifyIcon.ContextMenuStrip.Focus();
            this.notifyIcon.ContextMenuStrip.Show(Cursor.Position.X, Cursor.Position.Y);
            this.notifyIcon.ContextMenuStrip.BringToFront();
        }
    }
}
