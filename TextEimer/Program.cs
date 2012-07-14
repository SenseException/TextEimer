using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using TextEimer.Windows;
using TextEimer.Clipboard;
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

                ForegroundWindow foregroundWindow = new ForegroundWindow();

                ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                NotifyIconMenu notifyIconMenu = new NotifyIconMenu(contextMenuStrip);
                notifyIconMenu.FocusHandler = foregroundWindow;

                NotifyIcon notifyIcon = new NotifyIcon();
                notifyIcon.ContextMenuStrip = notifyIconMenu.contextMenuStrip;
                notifyIcon.Icon = (System.Drawing.Icon)TextEimer.Properties.Resources.ResourceManager.GetObject("bucket");
                notifyIcon.Text = "TextEimer";
                notifyIcon.Visible = true;
                NotifyIconSymbol notifyIconSymbol = new NotifyIconSymbol(notifyIcon);
                notifyIconSymbol.FocusHandler = foregroundWindow;

                Hotkey hk = new Hotkey();

                hk.KeyCode = Keys.Y;
                hk.Windows = true;
                hk.Pressed += delegate {
                	notifyIconSymbol.ShowNotifyIconMenu();
                };

                hk.Register(notifyIconMenu.contextMenuStrip);
                
                ClipboardHandler clipboardHandler = new ClipboardHandler(notifyIconMenu);

                Application.ApplicationExit += delegate {
                	if (hk.Registered)
                	{
                		hk.Unregister();
                	}
                };
                Application.Run();
            }
        }
    }
}
