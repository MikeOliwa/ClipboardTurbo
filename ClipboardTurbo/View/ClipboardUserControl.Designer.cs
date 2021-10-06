
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
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(696, 206);
            this.btnApply.Margin = new System.Windows.Forms.Padding(6);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(186, 44);
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
            this.lvInformation.Location = new System.Drawing.Point(32, 35);
            this.lvInformation.Margin = new System.Windows.Forms.Padding(6);
            this.lvInformation.Name = "lvInformation";
            this.lvInformation.Scrollable = false;
            this.lvInformation.Size = new System.Drawing.Size(632, 826);
            this.lvInformation.TabIndex = 16;
            this.lvInformation.UseCompatibleStateImageBehavior = false;
            this.lvInformation.SelectedIndexChanged += new System.EventHandler(this.lvInformation_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(696, 488);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(396, 65);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(696, 412);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(396, 65);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(696, 335);
            this.btnNew.Margin = new System.Windows.Forms.Padding(6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(396, 65);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(696, 152);
            this.tbValue.Margin = new System.Windows.Forms.Padding(6);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(392, 31);
            this.tbValue.TabIndex = 12;
            this.tbValue.TextChanged += new System.EventHandler(this.tbValue_TextChanged);
            // 
            // lbValue
            // 
            this.lbValue.AutoSize = true;
            this.lbValue.Location = new System.Drawing.Point(692, 121);
            this.lbValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(67, 25);
            this.lbValue.TabIndex = 11;
            this.lbValue.Text = "Value";
            // 
            // tbInformation
            // 
            this.tbInformation.Location = new System.Drawing.Point(696, 65);
            this.tbInformation.Margin = new System.Windows.Forms.Padding(6);
            this.tbInformation.Name = "tbInformation";
            this.tbInformation.Size = new System.Drawing.Size(392, 31);
            this.tbInformation.TabIndex = 10;
            this.tbInformation.TextChanged += new System.EventHandler(this.tbInformation_TextChanged);
            // 
            // lbInformation
            // 
            this.lbInformation.AutoSize = true;
            this.lbInformation.Location = new System.Drawing.Point(692, 35);
            this.lbInformation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(118, 25);
            this.lbInformation.TabIndex = 9;
            this.lbInformation.Text = "Information";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(904, 206);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(186, 44);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbNotification
            // 
            this.lbNotification.AutoSize = true;
            this.lbNotification.Location = new System.Drawing.Point(27, 896);
            this.lbNotification.Name = "lbNotification";
            this.lbNotification.Size = new System.Drawing.Size(0, 25);
            this.lbNotification.TabIndex = 19;
            // 
            // ClipboardUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ClipboardUserControl";
            this.Size = new System.Drawing.Size(1144, 962);
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
    }
}
