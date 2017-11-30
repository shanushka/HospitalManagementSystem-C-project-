namespace Hospital
{
    partial class frmNewDoctor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraTextFullName = new ClassLibrary1.class3();
            this.ultraPictureBox = new Infragistics.Win.UltraWinEditors.UltraPictureBox();
            this.ultraBtnUpload = new Infragistics.Win.Misc.UltraButton();
            this.label4 = new System.Windows.Forms.Label();
            this.ultraTextEditorID = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraTextPhoneNumber = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraTextAddress = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ultraBtnCancel = new Infragistics.Win.Misc.UltraButton();
            this.ultraBtnSave = new Infragistics.Win.Misc.UltraButton();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.ultraTextFullName);
            this.ultraGroupBox1.Controls.Add(this.ultraPictureBox);
            this.ultraGroupBox1.Controls.Add(this.ultraBtnUpload);
            this.ultraGroupBox1.Controls.Add(this.label4);
            this.ultraGroupBox1.Controls.Add(this.ultraTextEditorID);
            this.ultraGroupBox1.Controls.Add(this.ultraTextPhoneNumber);
            this.ultraGroupBox1.Controls.Add(this.ultraTextAddress);
            this.ultraGroupBox1.Controls.Add(this.label3);
            this.ultraGroupBox1.Controls.Add(this.label2);
            this.ultraGroupBox1.Controls.Add(this.label1);
            this.ultraGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraGroupBox1.Location = new System.Drawing.Point(12, 3);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(920, 453);
            this.ultraGroupBox1.TabIndex = 0;
            this.ultraGroupBox1.Text = "Doctor Profile";
            this.ultraGroupBox1.Click += new System.EventHandler(this.ultraGroupBox1_Click);
            // 
            // ultraTextFullName
            // 
            this.ultraTextFullName.Location = new System.Drawing.Point(263, 150);
            this.ultraTextFullName.Name = "ultraTextFullName";
            this.ultraTextFullName.Size = new System.Drawing.Size(202, 31);
            this.ultraTextFullName.TabIndex = 11;
            // 
            // ultraPictureBox
            // 
            this.ultraPictureBox.BorderShadowColor = System.Drawing.Color.Empty;
            this.ultraPictureBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraPictureBox.Location = new System.Drawing.Point(660, 47);
            this.ultraPictureBox.Name = "ultraPictureBox";
            this.ultraPictureBox.Size = new System.Drawing.Size(180, 189);
            this.ultraPictureBox.TabIndex = 10;
            // 
            // ultraBtnUpload
            // 
            this.ultraBtnUpload.Location = new System.Drawing.Point(660, 260);
            this.ultraBtnUpload.Name = "ultraBtnUpload";
            this.ultraBtnUpload.Size = new System.Drawing.Size(180, 45);
            this.ultraBtnUpload.TabIndex = 9;
            this.ultraBtnUpload.Text = "Upload";
            this.ultraBtnUpload.Click += new System.EventHandler(this.ultraBtnUpload_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID";
            // 
            // ultraTextEditorID
            // 
            this.ultraTextEditorID.Location = new System.Drawing.Point(263, 51);
            this.ultraTextEditorID.Name = "ultraTextEditorID";
            this.ultraTextEditorID.Size = new System.Drawing.Size(202, 34);
            this.ultraTextEditorID.TabIndex = 6;
            // 
            // ultraTextPhoneNumber
            // 
            this.ultraTextPhoneNumber.Location = new System.Drawing.Point(263, 335);
            this.ultraTextPhoneNumber.Name = "ultraTextPhoneNumber";
            this.ultraTextPhoneNumber.Size = new System.Drawing.Size(202, 34);
            this.ultraTextPhoneNumber.TabIndex = 4;
            this.ultraTextPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ultraTextPhoneNumber_KeyPress);
            // 
            // ultraTextAddress
            // 
            this.ultraTextAddress.Location = new System.Drawing.Point(263, 239);
            this.ultraTextAddress.Name = "ultraTextAddress";
            this.ultraTextAddress.Size = new System.Drawing.Size(202, 34);
            this.ultraTextAddress.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            // 
            // ultraBtnCancel
            // 
            this.ultraBtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraBtnCancel.Location = new System.Drawing.Point(650, 500);
            this.ultraBtnCancel.Name = "ultraBtnCancel";
            this.ultraBtnCancel.Size = new System.Drawing.Size(132, 62);
            this.ultraBtnCancel.TabIndex = 3;
            this.ultraBtnCancel.Text = "Cancel";
            this.ultraBtnCancel.Click += new System.EventHandler(this.ultraBtnCancel_Click);
            // 
            // ultraBtnSave
            // 
            this.ultraBtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraBtnSave.Location = new System.Drawing.Point(800, 500);
            this.ultraBtnSave.Name = "ultraBtnSave";
            this.ultraBtnSave.Size = new System.Drawing.Size(132, 62);
            this.ultraBtnSave.TabIndex = 2;
            this.ultraBtnSave.Text = "Save";
            this.ultraBtnSave.Click += new System.EventHandler(this.ultraBtnSave_Click);
            // 
            // frmNewDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 614);
            this.Controls.Add(this.ultraBtnCancel);
            this.Controls.Add(this.ultraBtnSave);
            this.Controls.Add(this.ultraGroupBox1);
            this.Name = "frmNewDoctor";
            this.Text = "Doctor Information";
            this.Load += new System.EventHandler(this.frmNewDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.ultraGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextAddress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextPhoneNumber;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextAddress;
        private Infragistics.Win.Misc.UltraButton ultraBtnCancel;
        private Infragistics.Win.Misc.UltraButton ultraBtnSave;
        private System.Windows.Forms.Label label4;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditorID;
        private Infragistics.Win.Misc.UltraButton ultraBtnUpload;
        private Infragistics.Win.UltraWinEditors.UltraPictureBox ultraPictureBox;
        private ClassLibrary1.class3 ultraTextFullName;
    }
}