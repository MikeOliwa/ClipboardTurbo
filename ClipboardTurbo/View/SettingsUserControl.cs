using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.Win32;

namespace ClipboardTurbo.View {
    public partial class SettingsUserControl : UserControl {

        private Controller.SettingsController _settingsController;
        Form _mainForm;

        public SettingsUserControl() {
            InitializeComponent();

            _settingsController = Controller.SettingsController.Create();



            tbConfigPath.Text = _settingsController.GetFilesDirectory();

            rtbKeyboardShortcut.KeyDown += new KeyEventHandler(rtbKeyboardShortcut_KeyPress);

        }
       
        private void ApplySettingsToProgram() {

            foreach (Configuration config in _settingsController.SettingsList) {

                    switch (config.Setting) {
                        case Setting.KeyboardShortcut:

                            break;

                        case Setting.KeepWindowOnTop:
                            if (config.Value.Equals("1")) {
                                cbKeepOnTop.Checked = true;
                            } else {
                                cbKeepOnTop.Checked = false;
                            }
                            break;

                        case Setting.StartWithWindows:

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

        private void rtbKeyboardShortcut_KeyPress(object sender, KeyEventArgs e) {

            if(e.KeyCode == Keys.Shift && e.KeyCode == Keys.A) {
                string pressedKey = e.KeyCode.ToString();
                rtbKeyboardShortcut.Text = pressedKey;
            }


        }

        private void cbKeepOnTop_CheckedChanged(object sender, EventArgs e) {

            if(cbKeepOnTop.Checked == true) {

                _settingsController.UpdateSettingValue(Setting.KeepWindowOnTop, "1");    
                _mainForm.TopMost = true;

            } else {

                _settingsController.UpdateSettingValue(Setting.KeepWindowOnTop, "0");
                _mainForm.TopMost = false;
            }

        }

        private void cbStartWithWindows_CheckedChanged(object sender, EventArgs e) {
            if (cbStartWithWindows.Checked == true) {
                _settingsController.UpdateSettingValue(Setting.StartWithWindows, "1");
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true)) {
                    key.SetValue("Clipboard Turbo", "\"" + Application.ExecutablePath + "\"");
                }
            }
            else {
                _settingsController.UpdateSettingValue(Setting.StartWithWindows, "0");
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true)) {
                    key.DeleteValue("Clipboard Turbo", false);
                }
            }
        }

        private void SettingsUserControl_Load(object sender, EventArgs e) {
            _mainForm = this.FindForm();
            ApplySettingsToProgram();
        }
    }
}
