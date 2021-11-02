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
        }

        private void tbConfigPath_TextChanged(object sender, EventArgs e) {
            _settingsController.ChangeFilePath(tbConfigPath.Text);
        }


        private void cbKeepOnTop_CheckedChanged(object sender, EventArgs e) {
            Control form = Parent;
            while (!(form is Form))
                form = Parent;

            (form as Form).TopMost = cbKeepOnTop.Checked;
        }

        private void btnConfigPath_Click(object sender, EventArgs e) {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                string folder = dialog.SelectedPath;
                tbConfigPath.Text = folder;
            }
        }


    }
}
