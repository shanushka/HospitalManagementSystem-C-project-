namespace Hospital
{
    partial class frmNewPatient
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
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton2 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraCalendarComboDOR = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.label7 = new System.Windows.Forms.Label();
            this.ultraCalendarComboDOB = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ultraTextEditorID = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraTextAddress = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ultraTextFullName = new ClassLibrary1.class3();
            this.ultraTextPhoneNumber = new ClassLibrary1.Class1();
            this.ultraTextEmergencyContact = new ClassLibrary1.Class1();
            this.ultraPictureBoxPatient = new Infragistics.Win.UltraWinEditors.UltraPictureBox();
            this.ultraBtnPUpload = new Infragistics.Win.Misc.UltraButton();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarComboDOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarComboDOB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.ultraPictureBoxPatient);
            this.ultraGroupBox1.Controls.Add(this.ultraBtnPUpload);
            this.ultraGroupBox1.Controls.Add(this.ultraTextEmergencyContact);
            this.ultraGroupBox1.Controls.Add(this.ultraTextPhoneNumber);
            this.ultraGroupBox1.Controls.Add(this.ultraTextFullName);
            this.ultraGroupBox1.Controls.Add(this.ultraCalendarComboDOR);
            this.ultraGroupBox1.Controls.Add(this.label7);
            this.ultraGroupBox1.Controls.Add(this.ultraCalendarComboDOB);
            this.ultraGroupBox1.Controls.Add(this.label6);
            this.ultraGroupBox1.Controls.Add(this.label5);
            this.ultraGroupBox1.Controls.Add(this.label4);
            this.ultraGroupBox1.Controls.Add(this.ultraTextEditorID);
            this.ultraGroupBox1.Controls.Add(this.ultraTextAddress);
            this.ultraGroupBox1.Controls.Add(this.label3);
            this.ultraGroupBox1.Controls.Add(this.label2);
            this.ultraGroupBox1.Controls.Add(this.label1);
            this.ultraGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraGroupBox1.Location = new System.Drawing.Point(21, 12);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(1037, 522);
            this.ultraGroupBox1.TabIndex = 1;
            this.ultraGroupBox1.Text = "Patient Profile";
            this.ultraGroupBox1.Click += new System.EventHandler(this.ultraGroupBox1_Click);
            // 
            // ultraCalendarComboDOR
            // 
            this.ultraCalendarComboDOR.DateButtons.Add(dateButton1);
            this.ultraCalendarComboDOR.Location = new System.Drawing.Point(307, 435);
            this.ultraCalendarComboDOR.Name = "ultraCalendarComboDOR";
            this.ultraCalendarComboDOR.NonAutoSizeHeight = 31;
            this.ultraCalendarComboDOR.Size = new System.Drawing.Size(270, 31);
            this.ultraCalendarComboDOR.TabIndex = 13;
            this.ultraCalendarComboDOR.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.ultraCalendarComboDOR_BeforeDropDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date Of Registration";
            // 
            // ultraCalendarComboDOB
            // 
            this.ultraCalendarComboDOB.DateButtons.Add(dateButton2);
            this.ultraCalendarComboDOB.Location = new System.Drawing.Point(307, 227);
            this.ultraCalendarComboDOB.Name = "ultraCalendarComboDOB";
            this.ultraCalendarComboDOB.NonAutoSizeHeight = 31;
            this.ultraCalendarComboDOB.Size = new System.Drawing.Size(270, 31);
            this.ultraCalendarComboDOB.TabIndex = 11;
            this.ultraCalendarComboDOB.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.ultraCalendarComboDOB_BeforeDropDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Emergency Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date Of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ultraTextEditorID
            // 
            this.ultraTextEditorID.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraTextEditorID.Location = new System.Drawing.Point(307, 33);
            this.ultraTextEditorID.Name = "ultraTextEditorID";
            this.ultraTextEditorID.Size = new System.Drawing.Size(270, 32);
            this.ultraTextEditorID.TabIndex = 6;
            this.ultraTextEditorID.ValueChanged += new System.EventHandler(this.ultraTextEditorID_ValueChanged);
            // 
            // ultraTextAddress
            // 
            this.ultraTextAddress.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraTextAddress.Location = new System.Drawing.Point(307, 153);
            this.ultraTextAddress.Name = "ultraTextAddress";
            this.ultraTextAddress.Size = new System.Drawing.Size(270, 32);
            this.ultraTextAddress.TabIndex = 5;
            this.ultraTextAddress.ValueChanged += new System.EventHandler(this.ultraTextAddress_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(885, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(754, 560);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 47);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ultraTextFullName
            // 
            this.ultraTextFullName.Location = new System.Drawing.Point(307, 91);
            this.ultraTextFullName.Name = "ultraTextFullName";
            this.ultraTextFullName.Size = new System.Drawing.Size(270, 31);
            this.ultraTextFullName.TabIndex = 14;
            this.ultraTextFullName.TextChanged += new System.EventHandler(this.ultraTextFullName_TextChanged);
            // 
            // ultraTextPhoneNumber
            // 
            this.ultraTextPhoneNumber.Location = new System.Drawing.Point(307, 285);
            this.ultraTextPhoneNumber.Name = "ultraTextPhoneNumber";
            this.ultraTextPhoneNumber.Size = new System.Drawing.Size(270, 31);
            this.ultraTextPhoneNumber.TabIndex = 15;
            this.ultraTextPhoneNumber.TextChanged += new System.EventHandler(this.ultraTextPhoneNumber_TextChanged);
            // 
            // ultraTextEmergencyContact
            // 
            this.ultraTextEmergencyContact.Location = new System.Drawing.Point(307, 356);
            this.ultraTextEmergencyContact.Name = "ultraTextEmergencyContact";
            this.ultraTextEmergencyContact.Size = new System.Drawing.Size(270, 31);
            this.ultraTextEmergencyContact.TabIndex = 16;
            this.ultraTextEmergencyContact.TextChanged += new System.EventHandler(this.ultraTextEmergencyContact_TextChanged);
            // 
            // ultraPictureBoxPatient
            // 
            this.ultraPictureBoxPatient.BorderShadowColor = System.Drawing.Color.Empty;
            this.ultraPictureBoxPatient.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraPictureBoxPatient.Location = new System.Drawing.Point(778, 33);
            this.ultraPictureBoxPatient.Name = "ultraPictureBoxPatient";
            this.ultraPictureBoxPatient.Size = new System.Drawing.Size(180, 189);
            this.ultraPictureBoxPatient.TabIndex = 18;
            // 
            // ultraBtnPUpload
            // 
            this.ultraBtnPUpload.Location = new System.Drawing.Point(778, 246);
            this.ultraBtnPUpload.Name = "ultraBtnPUpload";
            this.ultraBtnPUpload.Size = new System.Drawing.Size(180, 45);
            this.ultraBtnPUpload.TabIndex = 17;
            this.ultraBtnPUpload.Text = "Upload";
            this.ultraBtnPUpload.Click += new System.EventHandler(this.ultraBtnPUpload_Click);
            // 
            // frmNewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 638);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ultraGroupBox1);
            this.Name = "frmNewPatient";
            this.Text = "Patient Information";
            this.Load += new System.EventHandler(this.frmNewPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.ultraGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarComboDOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarComboDOB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextAddress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private System.Windows.Forms.Label label4;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditorID;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo ultraCalendarComboDOR;
        private System.Windows.Forms.Label label7;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo ultraCalendarComboDOB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
        private ClassLibrary1.class3 ultraTextFullName;
        private ClassLibrary1.Class1 ultraTextEmergencyContact;
        private ClassLibrary1.Class1 ultraTextPhoneNumber;
        private Infragistics.Win.UltraWinEditors.UltraPictureBox ultraPictureBoxPatient;
        private Infragistics.Win.Misc.UltraButton ultraBtnPUpload;
    }
}