
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
            this.lbApplicationPath.Location = new System.Drawing.Point(13, 13);
            this.lbApplicationPath.Name = "lbApplicationPath";
            this.lbApplicationPath.Size = new System.Drawing.Size(119, 13);
            this.lbApplicationPath.TabIndex = 0;
            this.lbApplicationPath.Text = "Path of application files:";
            // 
            // tbConfigPath
            // 
            this.tbConfigPath.Location = new System.Drawing.Point(16, 39);
            this.tbConfigPath.Name = "tbConfigPath";
            this.tbConfigPath.Size = new System.Drawing.Size(405, 20);
            this.tbConfigPath.TabIndex = 1;
            // 
            // btnConfigPath
            // 
            this.btnConfigPath.Location = new System.Drawing.Point(427, 39);
            this.btnConfigPath.Name = "btnConfigPath";
            this.btnConfigPath.Size = new System.Drawing.Size(27, 20);
            this.btnConfigPath.TabIndex = 2;
            this.btnConfigPath.Text = "...";
            this.btnConfigPath.UseVisualStyleBackColor = true;
            // 
            // lbKeyboardShortcut
            // 
            this.lbKeyboardShortcut.AutoSize = true;
            this.lbKeyboardShortcut.Location = new System.Drawing.Point(17, 83);
            this.lbKeyboardShortcut.Name = "lbKeyboardShortcut";
            this.lbKeyboardShortcut.Size = new System.Drawing.Size(93, 13);
            this.lbKeyboardShortcut.TabIndex = 3;
            this.lbKeyboardShortcut.Text = "Keyboard shortcut";
            // 
            // rtbKeyboardShortcut
            // 
            this.rtbKeyboardShortcut.Location = new System.Drawing.Point(115, 80);
            this.rtbKeyboardShortcut.Name = "rtbKeyboardShortcut";
            this.rtbKeyboardShortcut.Size = new System.Drawing.Size(115, 22);
            this.rtbKeyboardShortcut.TabIndex = 4;
            this.rtbKeyboardShortcut.Text = "";
            // 
            // btnKeyboardShortcutReset
            // 
            this.btnKeyboardShortcutReset.Location = new System.Drawing.Point(236, 80);
            this.btnKeyboardShortcutReset.Name = "btnKeyboardShortcutReset";
            this.btnKeyboardShortcutReset.Size = new System.Drawing.Size(75, 22);
            this.btnKeyboardShortcutReset.TabIndex = 5;
            this.btnKeyboardShortcutReset.Text = "Reset";
            this.btnKeyboardShortcutReset.UseVisualStyleBackColor = true;
            // 
            // cbKeepOnTop
            // 
            this.cbKeepOnTop.AutoSize = true;
            this.cbKeepOnTop.Location = new System.Drawing.Point(20, 118);
            this.cbKeepOnTop.Name = "cbKeepOnTop";
            this.cbKeepOnTop.Size = new System.Drawing.Size(123, 17);
            this.cbKeepOnTop.TabIndex = 6;
            this.cbKeepOnTop.Text = "Keep window on top";
            this.cbKeepOnTop.UseVisualStyleBackColor = true;
            // 
            // cbStartWithWindows
            // 
            this.cbStartWithWindows.AutoSize = true;
            this.cbStartWithWindows.Location = new System.Drawing.Point(20, 142);
            this.cbStartWithWindows.Name = "cbStartWithWindows";
            this.cbStartWithWindows.Size = new System.Drawing.Size(117, 17);
            this.cbStartWithWindows.TabIndex = 7;
            this.cbStartWithWindows.Text = "Start with Windows";
            this.cbStartWithWindows.UseVisualStyleBackColor = true;
            this.cbStartWithWindows.CheckedChanged += new System.EventHandler(this.cbStartWithWindows_CheckedChanged);
            // 
            // btnEmptyList
            // 
            this.btnEmptyList.Location = new System.Drawing.Point(16, 174);
            this.btnEmptyList.Name = "btnEmptyList";
            this.btnEmptyList.Size = new System.Drawing.Size(94, 23);
            this.btnEmptyList.TabIndex = 8;
            this.btnEmptyList.Text = "Empty whole list";
            this.btnEmptyList.UseVisualStyleBackColor = true;
            // 
            // SettingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Name = "SettingsUserControl";
            this.Size = new System.Drawing.Size(572, 500);
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
