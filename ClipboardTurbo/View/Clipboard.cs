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

        public Clipboard() {
            InitializeComponent();
            //this.TopMost = true;
            tcClipboard.TabPages[0].Text = "Clipboard";
            tcClipboard.TabPages[1].Text = "Settings";
            tcClipboard.Refresh();


        }

    }
}
