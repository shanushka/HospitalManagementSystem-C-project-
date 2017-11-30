namespace Hospital
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            this.ultraTilePanel1 = new Infragistics.Win.Misc.UltraTilePanel();
            this.ultraTile1 = new Infragistics.Win.Misc.UltraTile();
            this.ultraBtnPatient = new Infragistics.Win.Misc.UltraButton();
            this.ultraTile2 = new Infragistics.Win.Misc.UltraTile();
            this.ultraBtnDoctor = new Infragistics.Win.Misc.UltraButton();
            this.ultraTile3 = new Infragistics.Win.Misc.UltraTile();
            this.ultraBtnVisit = new Infragistics.Win.Misc.UltraButton();
            this.ultraTile4 = new Infragistics.Win.Misc.UltraTile();
            this.ultraBtnBed = new Infragistics.Win.Misc.UltraButton();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTilePanel1)).BeginInit();
            this.ultraTilePanel1.SuspendLayout();
            this.ultraTile1.SuspendLayout();
            this.ultraTile2.SuspendLayout();
            this.ultraTile3.SuspendLayout();
            this.ultraTile4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraTilePanel1
            // 
            this.ultraTilePanel1.Location = new System.Drawing.Point(196, 63);
            this.ultraTilePanel1.Name = "ultraTilePanel1";
            this.ultraTilePanel1.NormalModeDimensions = new System.Drawing.Size(2, 2);
            this.ultraTilePanel1.Size = new System.Drawing.Size(509, 549);
            this.ultraTilePanel1.TabIndex = 0;
            this.ultraTilePanel1.Tiles.Add(this.ultraTile1);
            this.ultraTilePanel1.Tiles.Add(this.ultraTile2);
            this.ultraTilePanel1.Tiles.Add(this.ultraTile3);
            this.ultraTilePanel1.Tiles.Add(this.ultraTile4);
            // 
            // ultraTile1
            // 
            this.ultraTile1.Caption = "Patient";
            this.ultraTile1.Control = this.ultraBtnPatient;
            this.ultraTile1.Controls.Add(this.ultraBtnPatient);
            this.ultraTile1.Name = "ultraTile1";
            this.ultraTile1.PositionInNormalMode = new System.Drawing.Point(0, 0);
            this.ultraTile1.TabIndex = 0;
            // 
            // ultraBtnPatient
            // 
            appearance1.Image = ((object)(resources.GetObject("appearance1.Image")));
            appearance1.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance1.ImageBackground")));
            this.ultraBtnPatient.Appearance = appearance1;
            this.ultraBtnPatient.ImageSize = new System.Drawing.Size(230, 230);
            this.ultraBtnPatient.Location = new System.Drawing.Point(0, 18);
            this.ultraBtnPatient.Name = "ultraBtnPatient";
            this.ultraBtnPatient.Size = new System.Drawing.Size(239, 241);
            this.ultraBtnPatient.TabIndex = 0;
            this.ultraBtnPatient.Text = "Patient";
            this.ultraBtnPatient.Click += new System.EventHandler(this.ultraBtnPatient_Click);
            // 
            // ultraTile2
            // 
            this.ultraTile2.Caption = "Doctor";
            this.ultraTile2.Control = this.ultraBtnDoctor;
            this.ultraTile2.Controls.Add(this.ultraBtnDoctor);
            this.ultraTile2.Name = "ultraTile2";
            this.ultraTile2.PositionInNormalMode = new System.Drawing.Point(1, 0);
            this.ultraTile2.TabIndex = 1;
            // 
            // ultraBtnDoctor
            // 
            appearance2.Image = ((object)(resources.GetObject("appearance2.Image")));
            this.ultraBtnDoctor.Appearance = appearance2;
            this.ultraBtnDoctor.ImageSize = new System.Drawing.Size(230, 230);
            this.ultraBtnDoctor.Location = new System.Drawing.Point(0, 18);
            this.ultraBtnDoctor.Name = "ultraBtnDoctor";
            this.ultraBtnDoctor.Size = new System.Drawing.Size(239, 241);
            this.ultraBtnDoctor.TabIndex = 0;
            this.ultraBtnDoctor.Text = "Doctor";
            this.ultraBtnDoctor.Click += new System.EventHandler(this.ultraBtnDoctor_Click);
            // 
            // ultraTile3
            // 
            this.ultraTile3.Caption = "Visit";
            this.ultraTile3.Control = this.ultraBtnVisit;
            this.ultraTile3.Controls.Add(this.ultraBtnVisit);
            this.ultraTile3.Name = "ultraTile3";
            this.ultraTile3.PositionInNormalMode = new System.Drawing.Point(0, 1);
            this.ultraTile3.TabIndex = 2;
            // 
            // ultraBtnVisit
            // 
            appearance5.Image = ((object)(resources.GetObject("appearance5.Image")));
            this.ultraBtnVisit.Appearance = appearance5;
            this.ultraBtnVisit.ImageSize = new System.Drawing.Size(230, 230);
            this.ultraBtnVisit.Location = new System.Drawing.Point(0, 18);
            this.ultraBtnVisit.Name = "ultraBtnVisit";
            this.ultraBtnVisit.Size = new System.Drawing.Size(239, 241);
            this.ultraBtnVisit.TabIndex = 0;
            this.ultraBtnVisit.Text = "Visit";
            this.ultraBtnVisit.Click += new System.EventHandler(this.ultraBtnVisit_Click);
            // 
            // ultraTile4
            // 
            this.ultraTile4.Caption = "Bed";
            this.ultraTile4.Control = this.ultraBtnBed;
            this.ultraTile4.Controls.Add(this.ultraBtnBed);
            this.ultraTile4.Name = "ultraTile4";
            this.ultraTile4.PositionInNormalMode = new System.Drawing.Point(1, 1);
            this.ultraTile4.TabIndex = 3;
            // 
            // ultraBtnBed
            // 
            appearance6.Image = ((object)(resources.GetObject("appearance6.Image")));
            this.ultraBtnBed.Appearance = appearance6;
            this.ultraBtnBed.ImageSize = new System.Drawing.Size(230, 230);
            this.ultraBtnBed.Location = new System.Drawing.Point(0, 18);
            this.ultraBtnBed.Name = "ultraBtnBed";
            this.ultraBtnBed.Size = new System.Drawing.Size(239, 241);
            this.ultraBtnBed.TabIndex = 0;
            this.ultraBtnBed.Text = "Bed";
            this.ultraBtnBed.Click += new System.EventHandler(this.ultraBtnBed_Click);
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel1.Location = new System.Drawing.Point(196, 12);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(489, 38);
            this.ultraLabel1.TabIndex = 1;
            this.ultraLabel1.Text = "Hospital Management System";
            this.ultraLabel1.Click += new System.EventHandler(this.ultraLabel1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 650);
            this.Controls.Add(this.ultraLabel1);
            this.Controls.Add(this.ultraTilePanel1);
            this.Name = "frmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ultraTilePanel1)).EndInit();
            this.ultraTilePanel1.ResumeLayout(false);
            this.ultraTile1.ResumeLayout(false);
            this.ultraTile2.ResumeLayout(false);
            this.ultraTile3.ResumeLayout(false);
            this.ultraTile4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGridDoctor;
        private Infragistics.Win.Misc.UltraTilePanel ultraTilePanel1;
        private Infragistics.Win.Misc.UltraTile ultraTile1;
        private Infragistics.Win.Misc.UltraButton ultraBtnPatient;
        private Infragistics.Win.Misc.UltraTile ultraTile2;
        private Infragistics.Win.Misc.UltraButton ultraBtnDoctor;
        private Infragistics.Win.Misc.UltraTile ultraTile3;
        private Infragistics.Win.Misc.UltraButton ultraBtnVisit;
        private Infragistics.Win.Misc.UltraTile ultraTile4;
        private Infragistics.Win.Misc.UltraButton ultraBtnBed;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
    }
}

