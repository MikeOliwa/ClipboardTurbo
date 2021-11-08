using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardTurbo.View {
    public partial class SettingsUserControl : UserControl {

        private Controller.SettingsController _settingsController;

        public SettingsUserControl() {
            InitializeComponent();

            _settingsController = Controller.SettingsController.Create();

            tbConfigPath.Text = _settingsController.GetFilesDirectory();

            rtbKeyboardShortcut.KeyDown += new KeyEventHandler(rtbKeyboardShortcut_KeyPress);
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
    }
}
