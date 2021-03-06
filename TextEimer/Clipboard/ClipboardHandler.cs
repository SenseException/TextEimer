﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;

using TextEimer.Clipboard.Container;
using ContainerType = TextEimer.Clipboard.Container.Type;
using TextEimer.Windows;
using TextEimer.Log;

namespace TextEimer.Clipboard
{
    /// <summary>
    /// Handles the Clipboard functions
    /// </summary>
    class ClipboardHandler : Form
    {
        [DllImport("User32.dll")]
        protected static extern int SetClipboardViewer(int hWndNewViewer);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);


        IntPtr nextClipboardViewer;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        
        private NotifyIconMenu notifyIconMenu;
        private Writer logWriter = null;

        public ClipboardHandler(NotifyIconMenu notifyIconMenu)
        {
            this.nextClipboardViewer = (IntPtr)SetClipboardViewer((int)this.Handle);
            this.notifyIconMenu = notifyIconMenu;
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            try
            {
                ChangeClipboardChain(this.Handle, this.nextClipboardViewer);
                if (disposing)
                {
                    if (components != null)
                    {
                        components.Dispose();
                    }
                }
                base.Dispose(disposing);
            }
            catch (Exception e)
            {
            }
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            // defined in winuser.h
            const int WM_DRAWCLIPBOARD = 0x308;
            const int WM_CHANGECBCHAIN = 0x030D;

            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
            		try {
	            		ContainerType.IType typeContainer = Factory.CreateTypeContainer();
	
	                    if (null != typeContainer) {
	                        this.notifyIconMenu.Add(typeContainer);
	                    }
	                    
	                    SendMessage(this.nextClipboardViewer, m.Msg, m.WParam, m.LParam);
            		}
            		catch(NullReferenceException e)
            		{
                        if (null != this.logWriter)
                        {
                            this.logWriter.Write(e.Message, e);
                        }
            		}

                    break;

                case WM_CHANGECBCHAIN:
                    if (m.WParam == this.nextClipboardViewer)
                        this.nextClipboardViewer = m.LParam;
                    else
                        SendMessage(this.nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                    break;

                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        public Writer LogWriter
        {
            get
            {
                return this.logWriter;
            }
            set
            {
                this.logWriter = value;
            }
        }
    }
}
