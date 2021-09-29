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
using ClipboardTurbo.View;

namespace ClipboardTurbo.View {
    public partial class SettingsControl : UserControl {

        public static SettingsController settingsController;

        public SettingsControl() {
            InitializeComponent();
            settingsController = new SettingsController();
        }
    }
}
