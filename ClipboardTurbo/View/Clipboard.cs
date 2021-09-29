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

        ClipboardController clipboardController;
        public static SettingsController settingsController;
        public Clipboard() {
            InitializeComponent();
            tcClipboard.TabPages[0].Text = "Clipboard";
            tcClipboard.TabPages[1].Text = "Settings";
            tcClipboard.Refresh();

            settingsController = new SettingsController();
            clipboardController = new ClipboardController();


        }

        private void btnAdd_Click(object sender, EventArgs e) {
            clipboardController.AddInformation(tbInformation.Text, tbValue.Text);
            tbInformation.Text = String.Empty;
            tbValue.Text = String.Empty;

            clipboardController.RefreshListView(lvInformation);
        }
    }
}
