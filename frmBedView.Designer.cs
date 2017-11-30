namespace Hospital
{
    partial class frmBedView
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
            Infragistics.Win.Appearance appearance57 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            this.ultraGroupBox3 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraBtnBRefresh = new Infragistics.Win.Misc.UltraButton();
            this.ultraBtnBDelete = new Infragistics.Win.Misc.UltraButton();
            this.ultraBtnBEdit = new Infragistics.Win.Misc.UltraButton();
            this.ultraBtnBNew = new Infragistics.Win.Misc.UltraButton();
            this.ultraGridBed = new Infragistics.Win.UltraWinGrid.UltraGrid();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox3)).BeginInit();
            this.ultraGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridBed)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraGroupBox3
            // 
            appearance57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ultraGroupBox3.Appearance = appearance57;
            this.ultraGroupBox3.Controls.Add(this.ultraBtnBRefresh);
            this.ultraGroupBox3.Controls.Add(this.ultraBtnBDelete);
            this.ultraGroupBox3.Controls.Add(this.ultraBtnBEdit);
            this.ultraGroupBox3.Controls.Add(this.ultraBtnBNew);
            this.ultraGroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ultraGroupBox3.Location = new System.Drawing.Point(0, 506);
            this.ultraGroupBox3.Name = "ultraGroupBox3";
            this.ultraGroupBox3.Size = new System.Drawing.Size(1045, 95);
            this.ultraGroupBox3.TabIndex = 8;
            // 
            // ultraBtnBRefresh
            // 
            this.ultraBtnBRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraBtnBRefresh.Location = new System.Drawing.Point(28, 20);
            this.ultraBtnBRefresh.Name = "ultraBtnBRefresh";
            this.ultraBtnBRefresh.Size = new System.Drawing.Size(106, 63);
            this.ultraBtnBRefresh.TabIndex = 3;
            this.ultraBtnBRefresh.Text = "Refresh";
            this.ultraBtnBRefresh.Click += new System.EventHandler(this.ultraBtnBRefresh_Click);
            // 
            // ultraBtnBDelete
            // 
            this.ultraBtnBDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraBtnBDelete.Location = new System.Drawing.Point(685, 20);
            this.ultraBtnBDelete.Name = "ultraBtnBDelete";
            this.ultraBtnBDelete.Size = new System.Drawing.Size(104, 63);
            this.ultraBtnBDelete.TabIndex = 2;
            this.ultraBtnBDelete.Text = "Delete";
            this.ultraBtnBDelete.Click += new System.EventHandler(this.ultraBtnBDelete_Click);
            // 
            // ultraBtnBEdit
            // 
            this.ultraBtnBEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraBtnBEdit.Location = new System.Drawing.Point(795, 20);
            this.ultraBtnBEdit.Name = "ultraBtnBEdit";
            this.ultraBtnBEdit.Size = new System.Drawing.Size(106, 63);
            this.ultraBtnBEdit.TabIndex = 1;
            this.ultraBtnBEdit.Text = "Edit";
            this.ultraBtnBEdit.Click += new System.EventHandler(this.ultraBtnBEdit_Click);
            // 
            // ultraBtnBNew
            // 
            this.ultraBtnBNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraBtnBNew.Location = new System.Drawing.Point(907, 20);
            this.ultraBtnBNew.Name = "ultraBtnBNew";
            this.ultraBtnBNew.Size = new System.Drawing.Size(104, 63);
            this.ultraBtnBNew.TabIndex = 0;
            this.ultraBtnBNew.Text = "New";
            this.ultraBtnBNew.Click += new System.EventHandler(this.ultraBtnBNew_Click);
            // 
            // ultraGridBed
            // 
            appearance25.BackColor = System.Drawing.SystemColors.Window;
            appearance25.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ultraGridBed.DisplayLayout.Appearance = appearance25;
            this.ultraGridBed.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraGridBed.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance26.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance26.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance26.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGridBed.DisplayLayout.GroupByBox.Appearance = appearance26;
            appearance28.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGridBed.DisplayLayout.GroupByBox.BandLabelAppearance = appearance28;
            this.ultraGridBed.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance27.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance27.BackColor2 = System.Drawing.SystemColors.Control;
            appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance27.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGridBed.DisplayLayout.GroupByBox.PromptAppearance = appearance27;
            this.ultraGridBed.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraGridBed.DisplayLayout.MaxRowScrollRegions = 1;
            appearance31.BackColor = System.Drawing.SystemColors.Window;
            appearance31.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ultraGridBed.DisplayLayout.Override.ActiveCellAppearance = appearance31;
            appearance34.BackColor = System.Drawing.SystemColors.Highlight;
            appearance34.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ultraGridBed.DisplayLayout.Override.ActiveRowAppearance = appearance34;
            this.ultraGridBed.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraGridBed.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance36.BackColor = System.Drawing.SystemColors.Window;
            this.ultraGridBed.DisplayLayout.Override.CardAreaAppearance = appearance36;
            appearance32.BorderColor = System.Drawing.Color.Silver;
            appearance32.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.ultraGridBed.DisplayLayout.Override.CellAppearance = appearance32;
            this.ultraGridBed.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraGridBed.DisplayLayout.Override.CellPadding = 0;
            appearance30.BackColor = System.Drawing.SystemColors.Control;
            appearance30.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance30.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance30.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGridBed.DisplayLayout.Override.GroupByRowAppearance = appearance30;
            appearance29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            appearance29.TextHAlignAsString = "Left";
            this.ultraGridBed.DisplayLayout.Override.HeaderAppearance = appearance29;
            this.ultraGridBed.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraGridBed.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance35.BackColor = System.Drawing.SystemColors.Window;
            appearance35.BorderColor = System.Drawing.Color.Silver;
            this.ultraGridBed.DisplayLayout.Override.RowAppearance = appearance35;
            this.ultraGridBed.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance33.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraGridBed.DisplayLayout.Override.TemplateAddRowAppearance = appearance33;
            this.ultraGridBed.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraGridBed.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGridBed.Dock = System.Windows.Forms.DockStyle.Top;
            this.ultraGridBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraGridBed.Location = new System.Drawing.Point(0, 0);
            this.ultraGridBed.Name = "ultraGridBed";
            this.ultraGridBed.Size = new System.Drawing.Size(1045, 509);
            this.ultraGridBed.TabIndex = 1;
            this.ultraGridBed.Text = "ultraGrid1";
            this.ultraGridBed.AfterRowActivate += new System.EventHandler(this.ultraGridBed_AfterRowActivate);
            // 
            // frmBedView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 601);
            this.Controls.Add(this.ultraGroupBox3);
            this.Controls.Add(this.ultraGridBed);
            this.Name = "frmBedView";
            this.Text = "frmBedView";
            this.Load += new System.EventHandler(this.frmBedView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox3)).EndInit();
            this.ultraGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridBed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox3;
        private Infragistics.Win.Misc.UltraButton ultraBtnBRefresh;
        private Infragistics.Win.Misc.UltraButton ultraBtnBDelete;
        private Infragistics.Win.Misc.UltraButton ultraBtnBEdit;
        private Infragistics.Win.Misc.UltraButton ultraBtnBNew;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGridBed;
    }
}