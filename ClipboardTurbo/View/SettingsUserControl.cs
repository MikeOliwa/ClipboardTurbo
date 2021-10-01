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
        }

        private void SettingsUserControl_Load(object sender, EventArgs e) {
        }

    }
}
