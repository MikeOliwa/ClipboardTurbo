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
using System.Runtime.InteropServices;
using ComponentFactory.Krypton.Toolkit;

namespace ClipboardTurbo {
    public partial class Clipboard : KryptonForm {

        //Eventmanager
        private Events.EventManager _eventManager;

        //other members
        private bool _closedByTrayMenu;
        const int _hotkeyID = 99;

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int key);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hwnd, int id);


        //Constructor
        public Clipboard() {
            InitializeComponent();

            _eventManager = ClipboardTurbo.Events.EventManager.Instance;

            _closedByTrayMenu = false;
            //tcClipboard.TabPages[0].Text = "Clipboard";
            //tcClipboard.TabPages[1].Text = "Settings";
            //tcClipboard.Refresh();
            
            trayIcon.Visible = true;

            ContextMenu contextMenu = new ContextMenu();
            trayIcon.ContextMenu = contextMenu;
            trayIcon.MouseClick += TrayIconMenu_OnClickIcon;
            trayIcon.ContextMenu.MenuItems.Add(new MenuItem("Open", TrayIconMenu_OnClickOpen));
            trayIcon.ContextMenu.MenuItems.Add(new MenuItem("Close", TrayIconMenu_OnClickClose));

            _eventManager.KeyboardShortcutChangedEvent += OnKeyboardShortcutChangedEvent;


        }

        //Event-Handler

        //Registrieren von Tastenkombinationen
        private void OnKeyboardShortcutChangedEvent(object sender, KeyboardShortcutChangedEventArgs e) {

            if(e.Modifier == Keys.None && e.Key == char.MinValue) {
                UnregisterHotKey(this.Handle, _hotkeyID);
                return;
            }

            if (!e.SettingValue.Equals(String.Empty)) {
                UnregisterHotKey(this.Handle, _hotkeyID);
            }


            //Modifier key codes: Alt = 1, Ctrl = 2, Shift = 4, Win = 8
            int modifierKey = 0;

            switch (e.Modifier) {
                case Keys.Alt:
                    modifierKey = 1;
                    break;
                case Keys.Control:
                    modifierKey = 2;
                    break;
                case Keys.Shift:
                    modifierKey = 4;
                    break;
                case Keys.LWin:
                    modifierKey = 8;
                    break;
            }

            try {
                RegisterHotKey(this.Handle, _hotkeyID, modifierKey, (int)e.SettingValue.ElementAt<char>(e.SettingValue.Length-1));
            } catch (ArgumentOutOfRangeException ex){
                MessageBox.Show("Use a Modifier key as the first key (ALT/SHIFT/CTRL)","Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        //Control-Actions

        private void Clipboard_FormClosing(object sender, FormClosingEventArgs e) {
            if(e.CloseReason == CloseReason.UserClosing && _closedByTrayMenu == false) {
                e.Cancel = true;
                trayIcon.ShowBalloonTip(800, "Clipboard Turbo", "Application was moved to background", ToolTipIcon.Info);
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

        private void TrayIconMenu_OnClickIcon(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                Show();
                WindowState = FormWindowState.Normal;
            }
        }

        //
        protected override void WndProc(ref Message m) {
            //0x0312 = WM_HOTKEY code
            //Hotkey pressed? + Hotkey with ID = _hotkeyID pressed?
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == _hotkeyID) {
                Show();
                WindowState = FormWindowState.Normal;
            }
            base.WndProc(ref m);
        }

        //

    }
}