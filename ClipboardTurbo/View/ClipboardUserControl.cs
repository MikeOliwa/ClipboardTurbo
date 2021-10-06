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
        private UIState _ui;
        public ClipboardUserControl() {
            InitializeComponent();

            _clipboardController = new Controller.ClipboardController();
            _clipboardController.RefreshListView(lvInformation);
            lvInformation.View = System.Windows.Forms.View.List;
            _ui = UIState.None;
            updateUI(ref _ui,UIState.None);

        }

        private void lvInformation_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvInformation.SelectedItems.Count == 1) {
                tbInformation.Text = lvInformation.FocusedItem.Text;
                updateUI(ref _ui, UIState.Selected);
                string value = _clipboardController.GetValueOfInformation(lvInformation.FocusedItem.Index);
                tbValue.Text = value;
                lbNotification.Text = $"\"{value}\" was sent to your clipboard!";
            } else if (lvInformation.SelectedItems.Count > 1) {
                tbInformation.Text = String.Empty;
                tbValue.Text = String.Empty;
                updateUI(ref _ui, UIState.None);
            }

        }

        private bool updateUI(ref UIState ui, UIState state) {
            ui = state;
            switch(ui){
                case UIState.None:
                    lvInformation.Enabled = true;
                    tbInformation.Enabled = false;
                    tbValue.Enabled = false;
                    btnApply.Enabled = false;
                    btnCancel.Enabled = false;
                    btnNew.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    return true;

                case UIState.New:
                    lvInformation.Enabled = false;
                    tbInformation.Enabled = true;
                    tbValue.Enabled = true;
                    btnApply.Enabled = false;
                    btnCancel.Enabled = true;
                    btnNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    return true;

                case UIState.Edit:
                    lvInformation.Enabled = false;
                    tbInformation.Enabled = true;
                    tbValue.Enabled = true;
                    btnApply.Enabled = false;
                    btnCancel.Enabled = true;
                    btnNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    return true;

                case UIState.EditSafeReady:
                    lvInformation.Enabled = false;
                    tbInformation.Enabled = true;
                    tbValue.Enabled = true;
                    btnApply.Enabled = true;
                    btnCancel.Enabled = true;
                    btnNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    return true;

                case UIState.Delete:
                    lvInformation.Enabled = true;
                    tbInformation.Enabled = false;
                    tbValue.Enabled = false;
                    btnApply.Enabled = false;
                    btnCancel.Enabled = false;
                    btnNew.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    return true;

                case UIState.Selected:
                    lvInformation.Enabled = true;
                    tbInformation.Enabled = false;
                    tbValue.Enabled = false;
                    btnApply.Enabled = false;
                    btnCancel.Enabled = false;
                    btnNew.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    return true;

                default:
                    return true;
            }
        }

        private void btnNew_Click(object sender, EventArgs e) {
            updateUI(ref _ui, UIState.New);
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            updateUI(ref _ui, UIState.Edit);
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show($"Delete information \"{lvInformation.FocusedItem.Text}\"?","Delete information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            updateUI(ref _ui, UIState.Delete);
            if(result == DialogResult.Yes) {
                _clipboardController.DeleteInformation(lvInformation.FocusedItem.Index);
                _clipboardController.RefreshListView(lvInformation);
                tbInformation.Text = String.Empty;
                tbValue.Text = String.Empty;
                lbNotification.Text = String.Empty;
                updateUI(ref _ui, UIState.None);
            }
        }

        private void btnApply_Click(object sender, EventArgs e) {
            switch (_ui) {
                case UIState.New:
                    if (_clipboardController.AddInformation(_clipboardController.GetNextId(),tbInformation.Text.Trim(), tbValue.Text.Trim())) {
                        tbInformation.Text = String.Empty;
                        tbValue.Text = String.Empty;
                        lbNotification.Text = String.Empty;
                    }
                    _clipboardController.RefreshListView(lvInformation);
                    updateUI(ref _ui, UIState.None);
                    break;

                case UIState.Edit:
                    _clipboardController.EditInformation(lvInformation.FocusedItem.Index,tbInformation.Text.Trim(), tbValue.Text.Trim());
                    _clipboardController.RefreshListView(lvInformation);
                    tbInformation.Text = String.Empty;
                    tbValue.Text = String.Empty;
                    lbNotification.Text = String.Empty;
                    updateUI(ref _ui, UIState.None);
                    break;

                default:
                    break;

            }

        }

        private void btnCancel_Click(object sender, EventArgs e) {
            tbInformation.Text = String.Empty;
            tbValue.Text = String.Empty;
            lbNotification.Text = String.Empty;
            updateUI(ref _ui, UIState.None);
        }

        private void tbInformation_TextChanged(object sender, EventArgs e) {
            if (((TextBox)sender).Modified) {
                if (!tbInformation.Text.Equals(String.Empty) && !tbValue.Text.Equals(String.Empty)) {
                    btnApply.Enabled = true;
                }
                else {
                    btnApply.Enabled = false;
                }
            }

        }

        private void tbValue_TextChanged(object sender, EventArgs e) {
            if (((TextBox)sender).Modified) {
                if (!tbInformation.Text.Equals(String.Empty) && !tbValue.Text.Equals(String.Empty)) {
                    btnApply.Enabled = true;
                }
                else {
                    btnApply.Enabled = false;
                }
            }

        }
    }
}
