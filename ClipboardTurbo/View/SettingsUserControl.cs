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

            _settingsController = new Controller.SettingsController();
        }

        private void cbStartWithWindows_CheckedChanged(object sender, EventArgs e) {
            
        }

        private void tbConfigPath_TextChanged(object sender, EventArgs e) {

        }

        private void cbKeepOnTop_CheckedChanged(object sender, EventArgs e) {
            Control form = Parent;
            while (!(form is Form))
                form = Parent;

            (form as Form).TopMost = cbStartWithWindows.Checked;
        }
    }
}
