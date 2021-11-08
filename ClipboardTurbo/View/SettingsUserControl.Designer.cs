
namespace ClipboardTurbo.View {
    partial class SettingsUserControl {
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.lbApplicationPath = new System.Windows.Forms.Label();
            this.tbConfigPath = new System.Windows.Forms.TextBox();
            this.btnConfigPath = new System.Windows.Forms.Button();
            this.lbKeyboardShortcut = new System.Windows.Forms.Label();
            this.rtbKeyboardShortcut = new System.Windows.Forms.RichTextBox();
            this.btnKeyboardShortcutReset = new System.Windows.Forms.Button();
            this.cbKeepOnTop = new System.Windows.Forms.CheckBox();
            this.cbStartWithWindows = new System.Windows.Forms.CheckBox();
            this.btnEmptyList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbApplicationPath
            // 
            this.lbApplicationPath.AutoSize = true;
            this.lbApplicationPath.Location = new System.Drawing.Point(26, 25);
            this.lbApplicationPath.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbApplicationPath.Name = "lbApplicationPath";
            this.lbApplicationPath.Size = new System.Drawing.Size(241, 25);
            this.lbApplicationPath.TabIndex = 0;
            this.lbApplicationPath.Text = "Path of application files:";
            // 
            // tbConfigPath
            // 
            this.tbConfigPath.Enabled = false;
            this.tbConfigPath.Location = new System.Drawing.Point(32, 75);
            this.tbConfigPath.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbConfigPath.Name = "tbConfigPath";
            this.tbConfigPath.Size = new System.Drawing.Size(806, 31);
            this.tbConfigPath.TabIndex = 1;
            this.tbConfigPath.TextChanged += new System.EventHandler(this.tbConfigPath_TextChanged);
            // 
            // btnConfigPath
            // 
            this.btnConfigPath.Location = new System.Drawing.Point(854, 75);
            this.btnConfigPath.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnConfigPath.Name = "btnConfigPath";
            this.btnConfigPath.Size = new System.Drawing.Size(54, 38);
            this.btnConfigPath.TabIndex = 2;
            this.btnConfigPath.Text = "...";
            this.btnConfigPath.UseVisualStyleBackColor = true;
            this.btnConfigPath.Click += new System.EventHandler(this.btnConfigPath_Click);
            // 
            // lbKeyboardShortcut
            // 
            this.lbKeyboardShortcut.AutoSize = true;
            this.lbKeyboardShortcut.Location = new System.Drawing.Point(34, 160);
            this.lbKeyboardShortcut.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbKeyboardShortcut.Name = "lbKeyboardShortcut";
            this.lbKeyboardShortcut.Size = new System.Drawing.Size(187, 25);
            this.lbKeyboardShortcut.TabIndex = 3;
            this.lbKeyboardShortcut.Text = "Keyboard shortcut";
            // 
            // rtbKeyboardShortcut
            // 
            this.rtbKeyboardShortcut.Location = new System.Drawing.Point(230, 154);
            this.rtbKeyboardShortcut.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rtbKeyboardShortcut.Name = "rtbKeyboardShortcut";
            this.rtbKeyboardShortcut.Size = new System.Drawing.Size(226, 39);
            this.rtbKeyboardShortcut.TabIndex = 4;
            this.rtbKeyboardShortcut.Text = "";
            // 
            // btnKeyboardShortcutReset
            // 
            this.btnKeyboardShortcutReset.Location = new System.Drawing.Point(472, 154);
            this.btnKeyboardShortcutReset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnKeyboardShortcutReset.Name = "btnKeyboardShortcutReset";
            this.btnKeyboardShortcutReset.Size = new System.Drawing.Size(150, 42);
            this.btnKeyboardShortcutReset.TabIndex = 5;
            this.btnKeyboardShortcutReset.Text = "Reset";
            this.btnKeyboardShortcutReset.UseVisualStyleBackColor = true;
            // 
            // cbKeepOnTop
            // 
            this.cbKeepOnTop.AutoSize = true;
            this.cbKeepOnTop.Location = new System.Drawing.Point(40, 227);
            this.cbKeepOnTop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbKeepOnTop.Name = "cbKeepOnTop";
            this.cbKeepOnTop.Size = new System.Drawing.Size(237, 29);
            this.cbKeepOnTop.TabIndex = 6;
            this.cbKeepOnTop.Text = "Keep window on top";
            this.cbKeepOnTop.UseVisualStyleBackColor = true;
            // 
            // cbStartWithWindows
            // 
            this.cbStartWithWindows.AutoSize = true;
            this.cbStartWithWindows.Location = new System.Drawing.Point(40, 273);
            this.cbStartWithWindows.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbStartWithWindows.Name = "cbStartWithWindows";
            this.cbStartWithWindows.Size = new System.Drawing.Size(226, 29);
            this.cbStartWithWindows.TabIndex = 7;
            this.cbStartWithWindows.Text = "Start with Windows";
            this.cbStartWithWindows.UseVisualStyleBackColor = true;
            // 
            // btnEmptyList
            // 
            this.btnEmptyList.Location = new System.Drawing.Point(32, 335);
            this.btnEmptyList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEmptyList.Name = "btnEmptyList";
            this.btnEmptyList.Size = new System.Drawing.Size(188, 44);
            this.btnEmptyList.TabIndex = 8;
            this.btnEmptyList.Text = "Empty whole list";
            this.btnEmptyList.UseVisualStyleBackColor = true;
            // 
            // SettingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.btnEmptyList);
            this.Controls.Add(this.cbStartWithWindows);
            this.Controls.Add(this.cbKeepOnTop);
            this.Controls.Add(this.btnKeyboardShortcutReset);
            this.Controls.Add(this.rtbKeyboardShortcut);
            this.Controls.Add(this.lbKeyboardShortcut);
            this.Controls.Add(this.btnConfigPath);
            this.Controls.Add(this.tbConfigPath);
            this.Controls.Add(this.lbApplicationPath);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "SettingsUserControl";
            this.Size = new System.Drawing.Size(1144, 962);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbApplicationPath;
        private System.Windows.Forms.TextBox tbConfigPath;
        private System.Windows.Forms.Button btnConfigPath;
        private System.Windows.Forms.Label lbKeyboardShortcut;
        private System.Windows.Forms.RichTextBox rtbKeyboardShortcut;
        private System.Windows.Forms.Button btnKeyboardShortcutReset;
        private System.Windows.Forms.CheckBox cbKeepOnTop;
        private System.Windows.Forms.CheckBox cbStartWithWindows;
        private System.Windows.Forms.Button btnEmptyList;
    }
}
