namespace Hospital
{
    partial class frmBed
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraComboBed = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ultraTextEditorBedID = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraTextRatePerDay = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraTextBedName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ultraBtnCancel = new Infragistics.Win.Misc.UltraButton();
            this.ultraBtnSave = new Infragistics.Win.Misc.UltraButton();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboBed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorBedID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextRatePerDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextBedName)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.ultraComboBed);
            this.ultraGroupBox1.Controls.Add(this.label6);
            this.ultraGroupBox1.Controls.Add(this.label4);
            this.ultraGroupBox1.Controls.Add(this.ultraTextEditorBedID);
            this.ultraGroupBox1.Controls.Add(this.ultraTextRatePerDay);
            this.ultraGroupBox1.Controls.Add(this.ultraTextBedName);
            this.ultraGroupBox1.Controls.Add(this.label3);
            this.ultraGroupBox1.Controls.Add(this.label1);
            this.ultraGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(941, 445);
            this.ultraGroupBox1.TabIndex = 2;
            this.ultraGroupBox1.Text = "Profile";
            // 
            // ultraComboBed
            // 
            this.ultraComboBed.CheckedListSettings.CheckStateMember = "";
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ultraComboBed.DisplayLayout.Appearance = appearance1;
            this.ultraComboBed.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraComboBed.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraComboBed.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraComboBed.DisplayLayout.GroupByBox.BandLabelAppearance = appearance4;
            this.ultraComboBed.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance3.BackColor2 = System.Drawing.SystemColors.Control;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraComboBed.DisplayLayout.GroupByBox.PromptAppearance = appearance3;
            this.ultraComboBed.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraComboBed.DisplayLayout.MaxRowScrollRegions = 1;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            appearance7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ultraComboBed.DisplayLayout.Override.ActiveCellAppearance = appearance7;
            appearance10.BackColor = System.Drawing.SystemColors.Highlight;
            appearance10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ultraComboBed.DisplayLayout.Override.ActiveRowAppearance = appearance10;
            this.ultraComboBed.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraComboBed.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            this.ultraComboBed.DisplayLayout.Override.CardAreaAppearance = appearance12;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.ultraComboBed.DisplayLayout.Override.CellAppearance = appearance8;
            this.ultraComboBed.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraComboBed.DisplayLayout.Override.CellPadding = 0;
            appearance6.BackColor = System.Drawing.SystemColors.Control;
            appearance6.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance6.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance6.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraComboBed.DisplayLayout.Override.GroupByRowAppearance = appearance6;
            appearance5.TextHAlignAsString = "Left";
            this.ultraComboBed.DisplayLayout.Override.HeaderAppearance = appearance5;
            this.ultraComboBed.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraComboBed.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            this.ultraComboBed.DisplayLayout.Override.RowAppearance = appearance11;
            this.ultraComboBed.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraComboBed.DisplayLayout.Override.TemplateAddRowAppearance = appearance9;
            this.ultraComboBed.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraComboBed.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraComboBed.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraComboBed.Location = new System.Drawing.Point(263, 241);
            this.ultraComboBed.Name = "ultraComboBed";
            this.ultraComboBed.PreferredDropDownSize = new System.Drawing.Size(0, 0);
            this.ultraComboBed.Size = new System.Drawing.Size(202, 35);
            this.ultraComboBed.TabIndex = 10;
            this.ultraComboBed.Text = "ultraComboBed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Bed Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID";
            // 
            // ultraTextEditorBedID
            // 
            this.ultraTextEditorBedID.Location = new System.Drawing.Point(263, 32);
            this.ultraTextEditorBedID.Name = "ultraTextEditorBedID";
            this.ultraTextEditorBedID.Size = new System.Drawing.Size(202, 34);
            this.ultraTextEditorBedID.TabIndex = 6;
            // 
            // ultraTextRatePerDay
            // 
            this.ultraTextRatePerDay.Location = new System.Drawing.Point(263, 167);
            this.ultraTextRatePerDay.Name = "ultraTextRatePerDay";
            this.ultraTextRatePerDay.Size = new System.Drawing.Size(202, 34);
            this.ultraTextRatePerDay.TabIndex = 4;
            // 
            // ultraTextBedName
            // 
            this.ultraTextBedName.Location = new System.Drawing.Point(263, 97);
            this.ultraTextBedName.Name = "ultraTextBedName";
            this.ultraTextBedName.Size = new System.Drawing.Size(202, 34);
            this.ultraTextBedName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "RatePerDay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bed Name";
            // 
            // ultraBtnCancel
            // 
            this.ultraBtnCancel.Location = new System.Drawing.Point(661, 517);
            this.ultraBtnCancel.Name = "ultraBtnCancel";
            this.ultraBtnCancel.Size = new System.Drawing.Size(132, 62);
            this.ultraBtnCancel.TabIndex = 5;
            this.ultraBtnCancel.Text = "Cancel";
            this.ultraBtnCancel.Click += new System.EventHandler(this.ultraBtnCancel_Click);
            // 
            // ultraBtnSave
            // 
            this.ultraBtnSave.Location = new System.Drawing.Point(821, 517);
            this.ultraBtnSave.Name = "ultraBtnSave";
            this.ultraBtnSave.Size = new System.Drawing.Size(132, 62);
            this.ultraBtnSave.TabIndex = 4;
            this.ultraBtnSave.Text = "Save";
            this.ultraBtnSave.Click += new System.EventHandler(this.ultraBtnSave_Click);
            // 
            // frmBed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 609);
            this.Controls.Add(this.ultraBtnCancel);
            this.Controls.Add(this.ultraBtnSave);
            this.Controls.Add(this.ultraGroupBox1);
            this.Name = "frmBed";
            this.Text = "Bed Information";
            this.Load += new System.EventHandler(this.frmBed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.ultraGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboBed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorBedID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextRatePerDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextBedName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditorBedID;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextRatePerDay;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextBedName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Infragistics.Win.UltraWinGrid.UltraCombo ultraComboBed;
        private Infragistics.Win.Misc.UltraButton ultraBtnCancel;
        private Infragistics.Win.Misc.UltraButton ultraBtnSave;
    }
}