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

        private Controller.ClipboardController _clipboardController;
        public ClipboardUserControl() {
            InitializeComponent();

            _clipboardController = new Controller.ClipboardController();
            _clipboardController.RefreshListView(lvInformation);
            lvInformation.View = System.Windows.Forms.View.List;

        }

        private void btnApply_Click(object sender, EventArgs e) {

            if(_clipboardController.AddInformation(tbInformation.Text.Trim(), tbValue.Text.Trim())) {
                tbInformation.Text = String.Empty;
                tbValue.Text = String.Empty;
            }
            _clipboardController.RefreshListView(lvInformation);
        }

        private void lvInformation_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvInformation.SelectedItems.Count == 1) {
                tbInformation.Text = lvInformation.FocusedItem.Text;
                string value = _clipboardController.GetValueOfInformation(lvInformation.FocusedItem.Text);
                tbValue.Text = value;
                _clipboardController.CopyToClipboard(value);
            } else if (lvInformation.SelectedItems.Count > 1) {
                tbInformation.Text = String.Empty;
            }

        }
    }
}
