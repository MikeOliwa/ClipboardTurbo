
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
            this.cbKeepOnTop = new System.Windows.Forms.CheckBox();
            this.cbStartWithWindows = new System.Windows.Forms.CheckBox();
            this.lbApplicationPath = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbKeyboardShortcut = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbConfigPath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnConfigPath = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnKeyboardShortcutReset = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.rtbKeyboardShortcut = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnEmptyList = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // cbKeepOnTop
            // 
            this.cbKeepOnTop.AutoSize = true;
            this.cbKeepOnTop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKeepOnTop.ForeColor = System.Drawing.Color.White;
            this.cbKeepOnTop.Location = new System.Drawing.Point(3, 119);
            this.cbKeepOnTop.Name = "cbKeepOnTop";
            this.cbKeepOnTop.Size = new System.Drawing.Size(154, 21);
            this.cbKeepOnTop.TabIndex = 6;
            this.cbKeepOnTop.Text = "Keep window on top";
            this.cbKeepOnTop.UseVisualStyleBackColor = true;
            this.cbKeepOnTop.CheckedChanged += new System.EventHandler(this.cbKeepOnTop_CheckedChanged);
            // 
            // cbStartWithWindows
            // 
            this.cbStartWithWindows.AutoSize = true;
            this.cbStartWithWindows.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbStartWithWindows.ForeColor = System.Drawing.Color.White;
            this.cbStartWithWindows.Location = new System.Drawing.Point(3, 143);
            this.cbStartWithWindows.Name = "cbStartWithWindows";
            this.cbStartWithWindows.Size = new System.Drawing.Size(148, 21);
            this.cbStartWithWindows.TabIndex = 7;
            this.cbStartWithWindows.Text = "Start with Windows";
            this.cbStartWithWindows.UseVisualStyleBackColor = true;
            this.cbStartWithWindows.CheckedChanged += new System.EventHandler(this.cbStartWithWindows_CheckedChanged);
            // 
            // lbApplicationPath
            // 
            this.lbApplicationPath.Location = new System.Drawing.Point(3, 3);
            this.lbApplicationPath.Name = "lbApplicationPath";
            this.lbApplicationPath.Size = new System.Drawing.Size(162, 21);
            this.lbApplicationPath.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbApplicationPath.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.lbApplicationPath.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationPath.TabIndex = 28;
            this.lbApplicationPath.Values.Text = "Path of application files:";
            // 
            // lbKeyboardShortcut
            // 
            this.lbKeyboardShortcut.Location = new System.Drawing.Point(3, 77);
            this.lbKeyboardShortcut.Name = "lbKeyboardShortcut";
            this.lbKeyboardShortcut.Size = new System.Drawing.Size(129, 21);
            this.lbKeyboardShortcut.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbKeyboardShortcut.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.lbKeyboardShortcut.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKeyboardShortcut.TabIndex = 29;
            this.lbKeyboardShortcut.Values.Text = "Keyboard shortcut";
            // 
            // tbConfigPath
            // 
            this.tbConfigPath.Location = new System.Drawing.Point(3, 30);
            this.tbConfigPath.Name = "tbConfigPath";
            this.tbConfigPath.Size = new System.Drawing.Size(405, 27);
            this.tbConfigPath.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbConfigPath.StateCommon.Border.Rounding = 5;
            this.tbConfigPath.TabIndex = 30;
            // 
            // btnConfigPath
            // 
            this.btnConfigPath.Location = new System.Drawing.Point(414, 30);
            this.btnConfigPath.Name = "btnConfigPath";
            this.btnConfigPath.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnConfigPath.Size = new System.Drawing.Size(41, 27);
            this.btnConfigPath.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnConfigPath.StateCommon.Back.Color2 = System.Drawing.Color.SlateBlue;
            this.btnConfigPath.StateCommon.Back.ColorAngle = 70F;
            this.btnConfigPath.StateCommon.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnConfigPath.StateCommon.Border.Color2 = System.Drawing.Color.SlateBlue;
            this.btnConfigPath.StateCommon.Border.ColorAngle = 70F;
            this.btnConfigPath.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfigPath.StateCommon.Border.Rounding = 7;
            this.btnConfigPath.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnConfigPath.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnConfigPath.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigPath.TabIndex = 31;
            this.btnConfigPath.Values.Text = "...";
            this.btnConfigPath.Click += new System.EventHandler(this.btnConfigPath_Click);
            // 
            // btnKeyboardShortcutReset
            // 
            this.btnKeyboardShortcutReset.Location = new System.Drawing.Point(273, 74);
            this.btnKeyboardShortcutReset.Name = "btnKeyboardShortcutReset";
            this.btnKeyboardShortcutReset.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnKeyboardShortcutReset.Size = new System.Drawing.Size(63, 27);
            this.btnKeyboardShortcutReset.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnKeyboardShortcutReset.StateCommon.Back.Color2 = System.Drawing.Color.SlateBlue;
            this.btnKeyboardShortcutReset.StateCommon.Back.ColorAngle = 70F;
            this.btnKeyboardShortcutReset.StateCommon.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnKeyboardShortcutReset.StateCommon.Border.Color2 = System.Drawing.Color.SlateBlue;
            this.btnKeyboardShortcutReset.StateCommon.Border.ColorAngle = 70F;
            this.btnKeyboardShortcutReset.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnKeyboardShortcutReset.StateCommon.Border.Rounding = 7;
            this.btnKeyboardShortcutReset.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnKeyboardShortcutReset.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnKeyboardShortcutReset.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeyboardShortcutReset.TabIndex = 32;
            this.btnKeyboardShortcutReset.Values.Text = "Reset";
            this.btnKeyboardShortcutReset.Click += new System.EventHandler(this.btnKeyboardShortcutReset_Click);
            // 
            // rtbKeyboardShortcut
            // 
            this.rtbKeyboardShortcut.Location = new System.Drawing.Point(138, 74);
            this.rtbKeyboardShortcut.Name = "rtbKeyboardShortcut";
            this.rtbKeyboardShortcut.Size = new System.Drawing.Size(129, 27);
            this.rtbKeyboardShortcut.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.rtbKeyboardShortcut.StateCommon.Border.Rounding = 5;
            this.rtbKeyboardShortcut.TabIndex = 33;
            this.rtbKeyboardShortcut.TextChanged += new System.EventHandler(this.rtbKeyboardShortcut_TextChanged);
            this.rtbKeyboardShortcut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbKeyboardShortcut_KeyDown);
            // 
            // btnEmptyList
            // 
            this.btnEmptyList.Location = new System.Drawing.Point(3, 179);
            this.btnEmptyList.Name = "btnEmptyList";
            this.btnEmptyList.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnEmptyList.Size = new System.Drawing.Size(108, 29);
            this.btnEmptyList.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnEmptyList.StateCommon.Back.Color2 = System.Drawing.Color.SlateBlue;
            this.btnEmptyList.StateCommon.Back.ColorAngle = 70F;
            this.btnEmptyList.StateCommon.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnEmptyList.StateCommon.Border.Color2 = System.Drawing.Color.SlateBlue;
            this.btnEmptyList.StateCommon.Border.ColorAngle = 70F;
            this.btnEmptyList.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEmptyList.StateCommon.Border.Rounding = 7;
            this.btnEmptyList.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnEmptyList.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnEmptyList.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmptyList.TabIndex = 34;
            this.btnEmptyList.Values.Text = "Empty whole list";
            this.btnEmptyList.Click += new System.EventHandler(this.btnEmptyList_Click);
            // 
            // SettingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.btnEmptyList);
            this.Controls.Add(this.rtbKeyboardShortcut);
            this.Controls.Add(this.btnKeyboardShortcutReset);
            this.Controls.Add(this.btnConfigPath);
            this.Controls.Add(this.tbConfigPath);
            this.Controls.Add(this.lbKeyboardShortcut);
            this.Controls.Add(this.lbApplicationPath);
            this.Controls.Add(this.cbStartWithWindows);
            this.Controls.Add(this.cbKeepOnTop);
            this.Name = "SettingsUserControl";
            this.Size = new System.Drawing.Size(572, 500);
            this.Load += new System.EventHandler(this.SettingsUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbKeepOnTop;
        private System.Windows.Forms.CheckBox cbStartWithWindows;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbApplicationPath;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbKeyboardShortcut;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbConfigPath;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnConfigPath;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnKeyboardShortcutReset;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox rtbKeyboardShortcut;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEmptyList;
    }
}
