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

        //Controller
        private Controller.ClipboardController _clipboardController;
        //Event manager
        private ClipboardTurbo.Events.EventManager _eventManager;

        //other members
        private UIState _uiState;

 
        //Properties
        public UIState WindowUIState {
            get {
                return _uiState;
            }
            set {
                if (_uiState != value) {
                    _uiState = value;
                    _eventManager.RaiseUIStateChangedEvent(_uiState);
                }
            }
        }


        private void OnUIStateChangedEvent(object sender, UIState uiMode) {
            UpdateUI(ref _uiState,uiMode);
        }

        //Construktor
        public ClipboardUserControl() {
            InitializeComponent();

            _eventManager = ClipboardTurbo.Events.EventManager.Instance;

            _clipboardController = Controller.ClipboardController.Create();
            _clipboardController.RefreshListView(lvInformation);
            //lvInformation.View = System.Windows.Forms.View.List;

            _eventManager.UIStateChangedEvent += OnUIStateChangedEvent;
            _eventManager.EmptyWholeListClickedEvent += OnEmptyWholeListClickedEvent;

            WindowUIState = UIState.None;
            
        }

        //Event-Handler
        private void OnEmptyWholeListClickedEvent(object sender, EventArgs e) {
            _clipboardController.CleanInformation();
            _clipboardController.RefreshListView(lvInformation);
            WindowUIState = UIState.None;
        }

        // Methods / Functions
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
                    tbInformation.Text = String.Empty;
                    tbValue.Text = String.Empty;
                    lbNotification.Text = String.Empty;
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
                    tbInformation.Text = String.Empty;
                    tbValue.Text = String.Empty;
                    lbNotification.Text = String.Empty;
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

        //Control-Actions

        private void lvInformation_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvInformation.SelectedItems.Count == 1) {
                tbInformation.Text = lvInformation.SelectedItem.ToString();
                UpdateUI(ref _uiState, UIState.Selected);
                string value = _clipboardController.GetValueOfInformation(lvInformation.Items.IndexOf(lvInformation.SelectedItems[0]));
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
            DialogResult result = MessageBox.Show($"Delete information \"{lvInformation.SelectedItem.ToString()}\"?","Delete information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            WindowUIState = UIState.Delete;
            if(result == DialogResult.Yes) {
                _clipboardController.DeleteInformation(lvInformation.Items.IndexOf(lvInformation.SelectedItem));
                _clipboardController.RefreshListView(lvInformation);
                WindowUIState = UIState.None;
            }
        }

        private void btnApply_Click(object sender, EventArgs e) {
            switch (WindowUIState) {
                case UIState.New:

                    if(_clipboardController.AddInformation(_clipboardController.GetNextId(), tbInformation.Text.Trim(), tbValue.Text.Trim())) {
                        WindowUIState = UIState.None;
                        _clipboardController.RefreshListView(lvInformation);
                    } else {
                        WindowUIState = UIState.New;
                    }

                    break;

                case UIState.Edit:
                    if (_clipboardController.EditInformation(lvInformation.Items.IndexOf(lvInformation.SelectedItems[0]), tbInformation.Text.Trim(), tbValue.Text.Trim())) {
                        WindowUIState = UIState.Selected;
                        int selectedItem = lvInformation.Items.IndexOf(lvInformation.SelectedItems[0]);
                        _clipboardController.RefreshListView(lvInformation);
                        lvInformation.SelectedItem = lvInformation.Items[selectedItem];
                        _clipboardController.CopyToClipboard(_clipboardController.GetValueOfInformation(lvInformation.Items.IndexOf(lvInformation.SelectedItems[0])));
                        lbNotification.Text = $"\"{_clipboardController.GetValueOfInformation(lvInformation.Items.IndexOf(lvInformation.SelectedItems[0]))}\" was sent to your clipboard!";
                    } else {
                        WindowUIState = UIState.Edit;
                    }
                    break;

                default:
                    break;

            }

        }

        private void btnCancel_Click(object sender, EventArgs e) {

            switch (WindowUIState) {
                case UIState.New:
                    WindowUIState = UIState.None;
                    break;

                case UIState.Edit:
                    var selectedItem = lvInformation.SelectedItems[0];
                    WindowUIState = UIState.Selected;
                    lvInformation.SelectedItem = selectedItem;
                    tbInformation.Text = _clipboardController.GetNameOfInformation(lvInformation.Items.IndexOf(selectedItem));
                    tbValue.Text = _clipboardController.GetValueOfInformation(lvInformation.Items.IndexOf(selectedItem));
                    break;

                default:
                    break;

            }

        }

        private void tbInformation_TextChanged(object sender, EventArgs e) {
            if (((ComponentFactory.Krypton.Toolkit.KryptonTextBox)sender).Modified) {
                if (!tbInformation.Text.Equals(String.Empty) && !tbValue.Text.Equals(String.Empty)) {
                    btnApply.Enabled = true;
                }
                else {
                    btnApply.Enabled = false;
                }
            }

        }

        private void tbValue_TextChanged(object sender, EventArgs e) {
            if (((ComponentFactory.Krypton.Toolkit.KryptonTextBox)sender).Modified) {
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
