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

        public static Controller.SettingsController settingsController;
        public static Controller.ClipboardController clipboardController;

        public Clipboard() {
            InitializeComponent();
            tcClipboard.TabPages[0].Text = "Clipboard";
            tcClipboard.TabPages[1].Text = "Settings";
            tcClipboard.Refresh();

            settingsController = new Controller.SettingsController();
            clipboardController = new Controller.ClipboardController();

        }

    }
}
