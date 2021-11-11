using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.Win32;

namespace ClipboardTurbo.View {
    public partial class SettingsUserControl : UserControl {

        private Controller.SettingsController _settingsController;
        public static event EventHandler BtnEmptyWholeListClickedEvent;
        public static event EventHandler<RtbKeyboardShortcutChangedEventArgs> RtbKeyboardShortcutChangedEvent;
        Form _mainForm;

        public SettingsUserControl() {
            InitializeComponent();

            _settingsController = Controller.SettingsController.Create();



            tbConfigPath.Text = _settingsController.GetFilesDirectory();

        }

        private void SettingsUserControl_Load(object sender, EventArgs e) {
            _mainForm = this.FindForm();
            ApplySettingsToProgram();
        }

        private void ApplySettingsToProgram() {

            foreach (Configuration config in _settingsController.SettingsList) {

                switch (config.Setting) {

                    case Setting.KeyboardShortcut:
                        rtbKeyboardShortcut.Text = _settingsController.GetHotKeySettingValue();
                        string modifierOfSetting_STRING = _settingsController.GetHotKeySettingValue().Remove(_settingsController.GetHotKeySettingValue().IndexOf(" "));
                        Keys modifierOfSetting_KEYS = Keys.None;

                        switch (modifierOfSetting_STRING) {
                            case "ALT":
                                modifierOfSetting_KEYS = Keys.Alt;
                                break;
                            case "SHIFT":
                                modifierOfSetting_KEYS = Keys.Shift;
                                break;
                            case "WIN":
                                modifierOfSetting_KEYS = Keys.LWin;
                                break;
                            case "CTRL":
                                modifierOfSetting_KEYS = Keys.Control;
                                break;
                        }

                        if (modifierOfSetting_KEYS != Keys.None) {
                            RtbKeyboardShortcutChangedEventArgs eventArgs = new RtbKeyboardShortcutChangedEventArgs(modifierOfSetting_KEYS, _settingsController.GetHotKeySettingValue().ElementAt<char>(_settingsController.GetHotKeySettingValue().Length - 1), _settingsController.GetHotKeySettingValue());
                            RaiseRtbKeyboardShortcutChangedEvent(eventArgs);
                        }


                        break;

                    case Setting.KeepWindowOnTop:
                        if (config.Value.Equals("1")) {
                            cbKeepOnTop.Checked = true;
                        }
                        else {
                            cbKeepOnTop.Checked = false;
                        }
                        break;

                    case Setting.StartWithWindows:
                        if (config.Value.Equals("1")) {
                            cbStartWithWindows.Checked = true;
                        }
                        else {
                            cbStartWithWindows.Checked = false;
                        }
                        break;
                }

            }
        }

        private void btnConfigPath_Click(object sender, EventArgs e) {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                string folder = dialog.SelectedPath;
                tbConfigPath.Text = folder;
                _settingsController.SetFilesDirectory(folder);
            }
        }


        //private void rtbKeyboardShortcut_KeyPress(object sender, KeyPressEventArgs e) {

        //    Keys modifier = Control.ModifierKeys;

        //    if (modifier == Keys.None) {
        //        string pressedKey = e.KeyChar.ToString().ToUpper();
        //        rtbKeyboardShortcut.Text = pressedKey;
        //    }
        //    else {

        //        switch (Control.ModifierKeys) {

        //            case Keys.Alt:
        //                rtbKeyboardShortcut.Text = "ALT + " + e.KeyChar.ToString().ToUpper();
        //                break;
        //            case Keys.Shift:
        //                rtbKeyboardShortcut.Text = "SHIFT + " + e.KeyChar.ToString().ToUpper();
        //                break;
        //            case Keys.LWin:
        //                rtbKeyboardShortcut.Text = "WIN + " + e.KeyChar.ToString().ToUpper();
        //                break;
        //            case Keys.Control:
        //                rtbKeyboardShortcut.Text = "CTRL + " + e.KeyChar.ToString().ToUpper();
        //                break;
        //        }

        //        RtbKeyboardShortcutChangedEventArgs eventArgs = new RtbKeyboardShortcutChangedEventArgs(modifier, e.KeyChar, _settingsController.GetHotKeySettingValue());

        //        RaiseRtbKeyboardShortcutChangedEvent(eventArgs);
        //    }

        //}

        private void rtbKeyboardShortcut_KeyDown(object sender, KeyEventArgs e) {

            if (e.KeyCode != Control.ModifierKeys) {

                switch (Control.ModifierKeys) {

                    case Keys.Alt:
                        rtbKeyboardShortcut.Text = "ALT + " + e.KeyCode.ToString().ToUpper();
                        break;
                    case Keys.Shift:
                        rtbKeyboardShortcut.Text = "SHIFT + " + e.KeyCode.ToString().ToUpper();
                        break;
                    case Keys.LWin:
                        rtbKeyboardShortcut.Text = "WIN + " + e.KeyCode.ToString().ToUpper();
                        break;
                    case Keys.Control:
                        rtbKeyboardShortcut.Text = "CTRL + " + e.KeyCode.ToString().ToUpper();
                        break;
                }

                RtbKeyboardShortcutChangedEventArgs eventArgs = new RtbKeyboardShortcutChangedEventArgs(Control.ModifierKeys, (char)e.KeyCode, _settingsController.GetHotKeySettingValue());

                RaiseRtbKeyboardShortcutChangedEvent(eventArgs);

            }



        }

        private void rtbKeyboardShortcut_TextChanged(object sender, EventArgs e) {
            if (!rtbKeyboardShortcut.Text.Equals(String.Empty)) {
                _settingsController.UpdateSettingValue(Setting.KeyboardShortcut, rtbKeyboardShortcut.Text);
            }
        }

        private void cbKeepOnTop_CheckedChanged(object sender, EventArgs e) {

            if (cbKeepOnTop.Checked == true) {

                _settingsController.UpdateSettingValue(Setting.KeepWindowOnTop, "1");
                _mainForm.TopMost = true;

            }
            else {

                _settingsController.UpdateSettingValue(Setting.KeepWindowOnTop, "0");
                _mainForm.TopMost = false;
            }

        }

        private void cbStartWithWindows_CheckedChanged(object sender, EventArgs e) {
            if (cbStartWithWindows.Checked == true) {
                _settingsController.UpdateSettingValue(Setting.StartWithWindows, "1");
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true)) {
                    key.SetValue("Clipboard Turbo", "\"" + System.Windows.Forms.Application.ExecutablePath + "\"");
                }
            }
            else {
                _settingsController.UpdateSettingValue(Setting.StartWithWindows, "0");
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true)) {
                    key.DeleteValue("Clipboard Turbo", false);
                }
            }
        }


        private void btnEmptyList_Click(object sender, EventArgs e) {
            string messageBoxText = "Do you want to delete all entries of your clipboard list?";
            string caption = "Empty whole list";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Question;
            MessageBoxResult result;

            result = System.Windows.MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);

            if (result == MessageBoxResult.Yes) {
                RaiseBtnEmptyWholeListClickedEvent();
            }
        }

        private void RaiseBtnEmptyWholeListClickedEvent() {
            BtnEmptyWholeListClickedEvent?.Invoke(this, EventArgs.Empty);
        }

        private void RaiseRtbKeyboardShortcutChangedEvent(RtbKeyboardShortcutChangedEventArgs e) {
            RtbKeyboardShortcutChangedEvent?.Invoke(this, e);
        }

    }
}