using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using TextEimer.Windows;

namespace TextEimer
{
    class Init
    {
        public void InitApplication()
        {
            NotifyIconMenu notifyIconMenu = new NotifyIconMenu(new ContextMenuStrip());

            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.ContextMenuStrip = notifyIconMenu.contextMenuStrip;
            notifyIcon.Icon = (System.Drawing.Icon)TextEimer.Properties.Resources.ResourceManager.GetObject("bucket");
            notifyIcon.Text = "TextEimer";
            notifyIcon.Visible = true;
            NotifyIconSymbol notifyIconSymbol = new NotifyIconSymbol(new NotifyIcon());
        }
    }
}
