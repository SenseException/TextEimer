using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using TextEimer.Windows;
using MovablePython;

namespace TextEimer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            System.Threading.Mutex Mu = new System.Threading.Mutex(false, "{ed4a1d54-416d-47eb-adb6-9a2d47e96774}");
            if (Mu.WaitOne(0, false))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                NotifyIconMenu notifyIconMenu = new NotifyIconMenu(new ContextMenuStrip());

                NotifyIcon notifyIcon = new NotifyIcon();
                notifyIcon.ContextMenuStrip = notifyIconMenu.contextMenuStrip;
                notifyIcon.Icon = (System.Drawing.Icon)TextEimer.Properties.Resources.ResourceManager.GetObject("bucket");
                notifyIcon.Text = "TextEimer";
                notifyIcon.Visible = true;
                NotifyIconSymbol notifyIconSymbol = new NotifyIconSymbol(notifyIcon);

                Hotkey hk = new Hotkey();

                hk.KeyCode = Keys.Y;
                hk.Windows = true;
                hk.Pressed += delegate { notifyIconSymbol.ShowNotifyIconMenu(); };

                hk.Register(notifyIconMenu.contextMenuStrip);

                Application.Run();
            }
        }
    }
}
