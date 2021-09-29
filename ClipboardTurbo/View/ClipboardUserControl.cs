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

namespace ClipboardTurbo.View {
    public partial class ClipboardUserControl : UserControl {

        public ClipboardUserControl() {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {

            Clipboard.clipboardController.AddInformation(tbInformation.Text, tbValue.Text);
            tbInformation.Text = String.Empty;
            tbValue.Text = String.Empty;

            Clipboard.clipboardController.RefreshListView(lvInformation);

        }
    }
}
