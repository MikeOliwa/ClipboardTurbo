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
    public partial class ClipboardControl : UserControl {

        ClipboardController clipboardController;
        public ClipboardControl() {
            InitializeComponent();
            clipboardController = new ClipboardController();
        }

        private void btnAdd_Click(object sender, EventArgs e) {

        }
    }
}
