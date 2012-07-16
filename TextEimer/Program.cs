using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;

using TextEimer.Windows;
using TextEimer.Clipboard;
using TextEimer.Config;
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

                Settings settings = new Settings();

                ForegroundWindow foregroundWindow = new ForegroundWindow();

                #region NotifyIconMenu
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                NotifyIconMenu notifyIconMenu = new NotifyIconMenu(contextMenuStrip, settings);
                notifyIconMenu.FocusHandler = foregroundWindow;
                #endregion

                #region NotifyIcon
                NotifyIcon notifyIcon = new NotifyIcon();
                notifyIcon.ContextMenuStrip = notifyIconMenu.contextMenuStrip;
                notifyIcon.Icon = (System.Drawing.Icon)TextEimer.Properties.Resources.ResourceManager.GetObject("bucket");
                notifyIcon.Text = "TextEimer";
                notifyIcon.Visible = true;
                NotifyIconSymbol notifyIconSymbol = new NotifyIconSymbol(notifyIcon);
                notifyIconSymbol.FocusHandler = foregroundWindow;
                #endregion

                ClipboardHandler clipboardHandler = new ClipboardHandler(notifyIconMenu);

                #region global Hotkey
                Hotkey hk = new Hotkey();

                hk.KeyCode = Keys.Y;
                hk.Windows = true;
                hk.Pressed += delegate {
                	notifyIconSymbol.ShowNotifyIconMenu();
                };

                hk.Register(notifyIconMenu.contextMenuStrip);

                Application.ApplicationExit += delegate {
                	if (hk.Registered)
                	{
                		hk.Unregister();
                	}
                };
                #endregion

                Application.Run();
            }
        }
    }
}
