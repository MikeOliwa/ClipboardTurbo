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
        private UIState _uiState;

        public UIState WindowUIState {
            get {
                return _uiState;
            }
            set {
                if (_uiState != value) {
                    _uiState = value;
                    //5. Auslösen des Events
                    RaiseUIStateChangedEvent(_uiState);
                }
            }
        }

        //1. Event.
        public event EventHandler<UIState> UIStateChangedEvent;

        //2. Methode zum Auslösen des Events. Event wird nur
        //   ausgelöst wenn Subscriber existieren.
        public virtual void RaiseUIStateChangedEvent(UIState state) {
            UIStateChangedEvent?.Invoke(this, state);
        }

        //3. Methode, welche auf das ausgelöste Event reagieren soll.
        private void OnUIStateChangedEvent(object sender, UIState uiMode) {
            UpdateUI(ref _uiState,uiMode);
        }

        public ClipboardUserControl() {
            InitializeComponent();

            _clipboardController = Controller.ClipboardController.Create();
            _clipboardController.RefreshListView(lvInformation);
            lvInformation.View = System.Windows.Forms.View.List;

            //4. Die "OnUIStateChangedEvent" Methode wird als Abonnent dem "UIStateChangedEvent" Event hinzugefügt.
            this.UIStateChangedEvent += OnUIStateChangedEvent;
            SettingsUserControl.BtnEmptyWholeListClickedEvent += OnBtnEmptyWholeListClickedEvent;

            WindowUIState = UIState.None;
            
        }

        private bool UpdateUI(ref UIState ui, UIState state) {
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

        private void lvInformation_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvInformation.SelectedItems.Count == 1) {
                tbInformation.Text = lvInformation.FocusedItem.Text;
                UpdateUI(ref _uiState, UIState.Selected);
                string value = _clipboardController.GetValueOfInformation(lvInformation.FocusedItem.Index);
                tbValue.Text = value;
                lbNotification.Text = $"\"{value}\" was sent to your clipboard!";
            } else if (lvInformation.SelectedItems.Count > 1) {
                tbInformation.Text = String.Empty;
                tbValue.Text = String.Empty;
                WindowUIState = UIState.None;
            }

        }



        private void btnNew_Click(object sender, EventArgs e) {
            WindowUIState = UIState.New;
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            WindowUIState = UIState.Edit;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show($"Delete information \"{lvInformation.FocusedItem.Text}\"?","Delete information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            WindowUIState = UIState.Delete;
            if(result == DialogResult.Yes) {
                _clipboardController.DeleteInformation(lvInformation.FocusedItem.Index);
                _clipboardController.RefreshListView(lvInformation);
                tbInformation.Text = String.Empty;
                tbValue.Text = String.Empty;
                lbNotification.Text = String.Empty;
                WindowUIState = UIState.None;
            }
        }

        private void btnApply_Click(object sender, EventArgs e) {
            switch (WindowUIState) {
                case UIState.New:
                    if (_clipboardController.AddInformation(_clipboardController.GetNextId(),tbInformation.Text.Trim(), tbValue.Text.Trim())) {
                        tbInformation.Text = String.Empty;
                        tbValue.Text = String.Empty;
                        lbNotification.Text = String.Empty;
                    }
                    _clipboardController.RefreshListView(lvInformation);
                    WindowUIState = UIState.None;
                    break;

                case UIState.Edit:
                    _clipboardController.EditInformation(lvInformation.FocusedItem.Index,tbInformation.Text.Trim(), tbValue.Text.Trim());
                    _clipboardController.RefreshListView(lvInformation);
                    tbInformation.Text = String.Empty;
                    tbValue.Text = String.Empty;
                    lbNotification.Text = String.Empty;
                    WindowUIState = UIState.None;
                    break;

                default:
                    break;

            }

        }

        private void btnCancel_Click(object sender, EventArgs e) {
            tbInformation.Text = String.Empty;
            tbValue.Text = String.Empty;
            lbNotification.Text = String.Empty;
            WindowUIState = UIState.None;
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

        private void OnBtnEmptyWholeListClickedEvent(object sender, EventArgs e) {
            _clipboardController.CleanInformation();
            _clipboardController.RefreshListView(lvInformation);
        }

    }

}
