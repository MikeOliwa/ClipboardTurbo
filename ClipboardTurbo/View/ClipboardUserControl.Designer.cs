
namespace ClipboardTurbo.View {
    partial class ClipboardUserControl {
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
            this.btnApply = new System.Windows.Forms.Button();
            this.lvInformation = new System.Windows.Forms.ListView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.lbValue = new System.Windows.Forms.Label();
            this.tbInformation = new System.Windows.Forms.TextBox();
            this.lbInformation = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbNotification = new System.Windows.Forms.Label();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(348, 107);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(93, 23);
            this.btnApply.TabIndex = 17;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lvInformation
            // 
            this.lvInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvInformation.HideSelection = false;
            this.lvInformation.LabelWrap = false;
            this.lvInformation.Location = new System.Drawing.Point(16, 18);
            this.lvInformation.Name = "lvInformation";
            this.lvInformation.Scrollable = false;
            this.lvInformation.Size = new System.Drawing.Size(318, 431);
            this.lvInformation.TabIndex = 16;
            this.lvInformation.UseCompatibleStateImageBehavior = false;
            this.lvInformation.SelectedIndexChanged += new System.EventHandler(this.lvInformation_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(348, 254);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(198, 34);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(348, 214);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(198, 34);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(348, 174);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(198, 34);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(348, 79);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(198, 20);
            this.tbValue.TabIndex = 12;
            this.tbValue.TextChanged += new System.EventHandler(this.tbValue_TextChanged);
            // 
            // lbValue
            // 
            this.lbValue.AutoSize = true;
            this.lbValue.Location = new System.Drawing.Point(346, 63);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(34, 13);
            this.lbValue.TabIndex = 11;
            this.lbValue.Text = "Value";
            // 
            // tbInformation
            // 
            this.tbInformation.Location = new System.Drawing.Point(348, 34);
            this.tbInformation.Name = "tbInformation";
            this.tbInformation.Size = new System.Drawing.Size(198, 20);
            this.tbInformation.TabIndex = 10;
            this.tbInformation.TextChanged += new System.EventHandler(this.tbInformation_TextChanged);
            // 
            // lbInformation
            // 
            this.lbInformation.AutoSize = true;
            this.lbInformation.Location = new System.Drawing.Point(346, 18);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(59, 13);
            this.lbInformation.TabIndex = 9;
            this.lbInformation.Text = "Information";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(452, 107);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbNotification
            // 
            this.lbNotification.AutoSize = true;
            this.lbNotification.Location = new System.Drawing.Point(14, 466);
            this.lbNotification.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNotification.Name = "lbNotification";
            this.lbNotification.Size = new System.Drawing.Size(0, 13);
            this.lbNotification.TabIndex = 19;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(349, 294);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton1.Size = new System.Drawing.Size(196, 37);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.kryptonButton1.StateCommon.Back.ColorAngle = 45F;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.kryptonButton1.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 7;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 20;
            this.kryptonButton1.Values.Text = "Delete";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // ClipboardUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.lbNotification);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lvInformation);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.lbValue);
            this.Controls.Add(this.tbInformation);
            this.Controls.Add(this.lbInformation);
            this.Name = "ClipboardUserControl";
            this.Size = new System.Drawing.Size(572, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ListView lvInformation;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label lbValue;
        private System.Windows.Forms.TextBox tbInformation;
        private System.Windows.Forms.Label lbInformation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbNotification;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}
