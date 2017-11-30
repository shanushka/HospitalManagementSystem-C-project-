namespace Hospital
{
    partial class frmDoctorView
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
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance51 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraBtnRefresh = new Infragistics.Win.Misc.UltraButton();
            this.ultraBtnDelete = new Infragistics.Win.Misc.UltraButton();
            this.ultraBtnEdit = new Infragistics.Win.Misc.UltraButton();
            this.ultraBtnNew = new Infragistics.Win.Misc.UltraButton();
            this.ultraGridDoc = new Infragistics.Win.UltraWinGrid.UltraGrid();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.ultraBtnRefresh);
            this.ultraGroupBox1.Controls.Add(this.ultraBtnDelete);
            this.ultraGroupBox1.Controls.Add(this.ultraBtnEdit);
            this.ultraGroupBox1.Controls.Add(this.ultraBtnNew);
            this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ultraGroupBox1.Location = new System.Drawing.Point(0, 426);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(1077, 114);
            this.ultraGroupBox1.TabIndex = 7;
            // 
            // ultraBtnRefresh
            // 
            this.ultraBtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraBtnRefresh.Location = new System.Drawing.Point(33, 22);
            this.ultraBtnRefresh.Name = "ultraBtnRefresh";
            this.ultraBtnRefresh.Size = new System.Drawing.Size(106, 63);
            this.ultraBtnRefresh.TabIndex = 3;
            this.ultraBtnRefresh.Text = "Refresh";
            this.ultraBtnRefresh.Click += new System.EventHandler(this.ultraBtnRefresh_Click);
            // 
            // ultraBtnDelete
            // 
            this.ultraBtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraBtnDelete.Location = new System.Drawing.Point(688, 22);
            this.ultraBtnDelete.Name = "ultraBtnDelete";
            this.ultraBtnDelete.Size = new System.Drawing.Size(104, 63);
            this.ultraBtnDelete.TabIndex = 2;
            this.ultraBtnDelete.Text = "Delete";
            this.ultraBtnDelete.Click += new System.EventHandler(this.ultraBtnDelete_Click);
            // 
            // ultraBtnEdit
            // 
            this.ultraBtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraBtnEdit.Location = new System.Drawing.Point(798, 22);
            this.ultraBtnEdit.Name = "ultraBtnEdit";
            this.ultraBtnEdit.Size = new System.Drawing.Size(106, 63);
            this.ultraBtnEdit.TabIndex = 1;
            this.ultraBtnEdit.Text = "Edit";
            this.ultraBtnEdit.Click += new System.EventHandler(this.ultraBtnEdit_Click);
            // 
            // ultraBtnNew
            // 
            this.ultraBtnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraBtnNew.Location = new System.Drawing.Point(910, 22);
            this.ultraBtnNew.Name = "ultraBtnNew";
            this.ultraBtnNew.Size = new System.Drawing.Size(104, 63);
            this.ultraBtnNew.TabIndex = 0;
            this.ultraBtnNew.Text = "New";
            this.ultraBtnNew.Click += new System.EventHandler(this.ultraBtnNew_Click);
            // 
            // ultraGridDoc
            // 
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ultraGridDoc.DisplayLayout.Appearance = appearance1;
            this.ultraGridDoc.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraGridDoc.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance5.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGridDoc.DisplayLayout.GroupByBox.Appearance = appearance5;
            appearance7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGridDoc.DisplayLayout.GroupByBox.BandLabelAppearance = appearance7;
            this.ultraGridDoc.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance6.BackColor2 = System.Drawing.SystemColors.Control;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGridDoc.DisplayLayout.GroupByBox.PromptAppearance = appearance6;
            this.ultraGridDoc.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraGridDoc.DisplayLayout.MaxRowScrollRegions = 1;
            appearance10.BackColor = System.Drawing.SystemColors.Window;
            appearance10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ultraGridDoc.DisplayLayout.Override.ActiveCellAppearance = appearance10;
            appearance49.BackColor = System.Drawing.SystemColors.Highlight;
            appearance49.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ultraGridDoc.DisplayLayout.Override.ActiveRowAppearance = appearance49;
            this.ultraGridDoc.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free;
            this.ultraGridDoc.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraGridDoc.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance51.BackColor = System.Drawing.SystemColors.Window;
            this.ultraGridDoc.DisplayLayout.Override.CardAreaAppearance = appearance51;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            appearance11.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.ultraGridDoc.DisplayLayout.Override.CellAppearance = appearance11;
            this.ultraGridDoc.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraGridDoc.DisplayLayout.Override.CellPadding = 0;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGridDoc.DisplayLayout.Override.GroupByRowAppearance = appearance9;
            appearance8.BackColor = System.Drawing.Color.Teal;
            appearance8.TextHAlignAsString = "Left";
            this.ultraGridDoc.DisplayLayout.Override.HeaderAppearance = appearance8;
            this.ultraGridDoc.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraGridDoc.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance50.BackColor = System.Drawing.SystemColors.Window;
            appearance50.BorderColor = System.Drawing.Color.Silver;
            this.ultraGridDoc.DisplayLayout.Override.RowAppearance = appearance50;
            this.ultraGridDoc.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraGridDoc.DisplayLayout.Override.TemplateAddRowAppearance = appearance12;
            this.ultraGridDoc.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraGridDoc.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGridDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGridDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraGridDoc.Location = new System.Drawing.Point(0, 0);
            this.ultraGridDoc.Name = "ultraGridDoc";
            this.ultraGridDoc.Size = new System.Drawing.Size(1077, 426);
            this.ultraGridDoc.TabIndex = 8;
            this.ultraGridDoc.Text = "ultraGrid1";
            this.ultraGridDoc.AfterRowActivate += new System.EventHandler(this.ultraGridDoc_AfterRowActivate);
            // 
            // frmDoctorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 540);
            this.Controls.Add(this.ultraGridDoc);
            this.Controls.Add(this.ultraGroupBox1);
            this.Name = "frmDoctorView";
            this.Text = "frmDoctorView";
            this.Load += new System.EventHandler(this.frmDoctorView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridDoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private Infragistics.Win.Misc.UltraButton ultraBtnRefresh;
        private Infragistics.Win.Misc.UltraButton ultraBtnDelete;
        private Infragistics.Win.Misc.UltraButton ultraBtnEdit;
        private Infragistics.Win.Misc.UltraButton ultraBtnNew;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGridDoc;
    }
}