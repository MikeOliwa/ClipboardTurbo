
namespace ClipboardTurbo {
    partial class Clipboard {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clipboard));
            this.tcClipboard = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.clipboardUserControl1 = new ClipboardTurbo.View.ClipboardUserControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.settingsUserControl1 = new ClipboardTurbo.View.SettingsUserControl();
            this.tcClipboard.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcClipboard
            // 
            this.tcClipboard.Controls.Add(this.tabPage1);
            this.tcClipboard.Controls.Add(this.tabPage2);
            this.tcClipboard.Location = new System.Drawing.Point(12, 12);
            this.tcClipboard.Name = "tcClipboard";
            this.tcClipboard.SelectedIndex = 0;
            this.tcClipboard.Size = new System.Drawing.Size(574, 526);
            this.tcClipboard.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.clipboardUserControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(566, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // clipboardUserControl1
            // 
            this.clipboardUserControl1.BackColor = System.Drawing.Color.CadetBlue;
            this.clipboardUserControl1.Location = new System.Drawing.Point(-2, 0);
            this.clipboardUserControl1.Margin = new System.Windows.Forms.Padding(6);
            this.clipboardUserControl1.Name = "clipboardUserControl1";
            this.clipboardUserControl1.Size = new System.Drawing.Size(572, 500);
            this.clipboardUserControl1.TabIndex = 0;
            this.clipboardUserControl1.WindowUIState = ClipboardTurbo.UIState.None;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.settingsUserControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(566, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Clipboard Turbo";
            // 
            // settingsUserControl1
            // 
            this.settingsUserControl1.Location = new System.Drawing.Point(0, 0);
            this.settingsUserControl1.Name = "settingsUserControl1";
            this.settingsUserControl1.Size = new System.Drawing.Size(572, 500);
            this.settingsUserControl1.TabIndex = 0;
            // 
            // Clipboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 550);
            this.Controls.Add(this.tcClipboard);
            this.Name = "Clipboard";
            this.Text = "Clipboard Turbo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Clipboard_FormClosing);
            this.tcClipboard.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcClipboard;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private View.ClipboardUserControl clipboardUserControl1;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private View.SettingsUserControl settingsUserControl1;
    }
}

