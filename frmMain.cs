using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Infragistics.Win.UltraWinGrid;
using MyCompany.MyProject.Db;

namespace Hospital
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
           
        }

   


  
      
      
     
        private void ultraTabPageControl5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ultraGridPatient_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {

        }

        private void ultraComboPSearch_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {

        }

        private void ultraLabel1_Click(object sender, EventArgs e)
        {

        }
        frmPatientView objfrmPatientView;
        frmDoctorView objfrmDoctorView;
        frmBedView objfrmBedView;
        frmVisitView objfrmVisitView;
        private void ultraBtnPatient_Click(object sender, EventArgs e)
        {
            objfrmPatientView = new frmPatientView();
            objfrmPatientView.ShowDialog();
        }

        private void ultraBtnDoctor_Click(object sender, EventArgs e)
        {
            objfrmDoctorView = new frmDoctorView();
            objfrmDoctorView.ShowDialog();
        }

        private void ultraBtnVisit_Click(object sender, EventArgs e)
        {
            objfrmVisitView = new frmVisitView();
            objfrmVisitView.ShowDialog();
        }

        private void ultraBtnBed_Click(object sender, EventArgs e)
        {
            objfrmBedView = new frmBedView();
            objfrmBedView.ShowDialog();
        }
    }
}
