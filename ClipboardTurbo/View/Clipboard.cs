using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClipboardTurbo.Controller;

namespace ClipboardTurbo {
    public partial class Clipboard : Form {

        private bool _closedByTrayMenu;

        public Clipboard() {
            InitializeComponent();
            _closedByTrayMenu = false;
            //this.TopMost = true;
            tcClipboard.TabPages[0].Text = "Clipboard";
            tcClipboard.TabPages[1].Text = "Settings";
            tcClipboard.Refresh();

            trayIcon.Visible = true;
            trayIcon.ShowBalloonTip(10000, "test", "test2", ToolTipIcon.Info);

            ContextMenu contextMenu = new ContextMenu();

            trayIcon.ContextMenu = contextMenu;
            trayIcon.ContextMenu.MenuItems.Add(new MenuItem("Open", TrayIconMenu_OnClickOpen));
            trayIcon.ContextMenu.MenuItems.Add(new MenuItem("Close", TrayIconMenu_OnClickClose));
        }

        private void Clipboard_Resize(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Minimized) {
                trayIcon.Visible = true;
                trayIcon.ShowBalloonTip(1000,"test","test2", ToolTipIcon.Info);
            }
        }

        private void Clipboard_FormClosing(object sender, FormClosingEventArgs e) {
            if(e.CloseReason == CloseReason.UserClosing && _closedByTrayMenu == false) {
                e.Cancel = true;
                this.Hide();
                
            }

        }

        private void TrayIconMenu_OnClickOpen(object sender, EventArgs e) {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void TrayIconMenu_OnClickClose(object sender, EventArgs e) {
            _closedByTrayMenu = true;
            Close();
        }
    }
}
