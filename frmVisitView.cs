using Infragistics.Win.UltraWinGrid;
using MyCompany.MyProject.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class frmVisitView : Form
    {
        public frmVisitView()
        {
            InitializeComponent();
            comboCall();
        }
        frmVisit objfrmVisit;
        HospitalDB objHospitalDB = null;
        private void ultraBtnVNew_Click(object sender, EventArgs e)
        {
            objfrmVisit = new frmVisit();
            objfrmVisit.strFormMode = "NEW";
            objfrmVisit.ShowDialog();
        }
        public string Vis_id;
        public string Vis_dov;
        public string Vis_dod;
        public string Vis_symptoms;
        public string Vis_disease;
        public string Vis_treatment;
        public string Vis_patienttype;
        public string Vis_patientid;
        public string Vis_doctorid;
        public string Vis_bedid;
    //    public string Vis_patname;
        private void ultraBtnVEdit_Click(object sender, EventArgs e)
        {
            objfrmVisit = new frmVisit();
            objfrmVisit.id = Vis_id.ToString();
            objfrmVisit.dod = Vis_dod.ToString();
            objfrmVisit.dov = Vis_dov.ToString();
            objfrmVisit.treatment = Vis_treatment.ToString();
            objfrmVisit.symptoms = Vis_symptoms.ToString();
            objfrmVisit.disease = Vis_disease.ToString();
            objfrmVisit.patienttype = Vis_patienttype.ToString();
            objfrmVisit.patid = Vis_patientid.ToString();
            objfrmVisit.docid = Vis_doctorid.ToString();
            objfrmVisit.bedid = Vis_bedid.ToString();
           // objfrmVisit.patname = Vis_patname.ToString();
            objfrmVisit.strFormMode = "EDIT";
            objfrmVisit.ShowDialog();
        }
        public void comboCall()
        {
            DataTable dt = Class_Files.comboClass.LoadSearchBy();
            ultraComboSearch.DataSource = dt;
            ultraComboSearch.BindingContext = this.BindingContext;
            ultraComboSearch.DisplayMember = "Search By";
            ultraComboSearch.ValueMember = "Search By";
        }
        private void ultraBtnVDelete_Click(object sender, EventArgs e)
        {
            objHospitalDB = new HospitalDB();
            ultraGridVisit.Rows[this.ultraGridVisit.ActiveRow.Index].Delete(true);
            SqlCommand query = objHospitalDB.CreateCommand("delete from Visit where VisitorID='" + this.Vis_id + "';", false);
            int p = query.ExecuteNonQuery();
            MessageBox.Show(p + "Deleted");
        }
        public DataSet dsVisit;
        private void ultraBtnVRefresh_Click(object sender, EventArgs e)
        {
            ultraTextSearch.Text = "";
            ultraDateTimeSearch.Value = "";
            try
            {
                objHospitalDB = new HospitalDB();
                Visit objVisit = new Visit(objHospitalDB);
                DataTable dtVisit = new DataTable();
                dtVisit=objVisit.GetAllAsDataTable();
                ultraGridVisit.DataSource = dtVisit;
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (objHospitalDB != null)
                {
                    objHospitalDB.Dispose();
                }
            }
        }
        public DataTable dtVisit;
        private void frmVisitView_Load(object sender, EventArgs e)
        {
            objHospitalDB = new HospitalDB();
            Visit objVisit = new Visit(objHospitalDB);
            DataTable dtVisit=new DataTable();
            dtVisit = objVisit.GetAllAsDataTable();
            ultraGridVisit.DataSource = dtVisit;
     
        }

        private void ultraGridVisit_AfterRowActivate(object sender, EventArgs e)
        {
            UltraGridRow row = this.ultraGridVisit.ActiveRow;
            if (row != null)
            {
                Vis_id = row.Cells["VisitorID"].Text;
                Vis_dov = row.Cells["DateOfVisit"].Text;
                Vis_dod = row.Cells["DateOfDischarge"].Text;
                Vis_symptoms = row.Cells["Symptoms"].Text;
                Vis_disease = row.Cells["Disease"].Text;
                Vis_patienttype = row.Cells["PatientType"].Text;
                Vis_treatment = row.Cells["Treatment"].Text;
                Vis_patientid = row.Cells["PatientID"].Text;
                Vis_doctorid = row.Cells["DoctorID"].Text;
                Vis_bedid = row.Cells["BedID"].Text;
             }
        }

        private void ultraBtnSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            if (ultraComboSearch.Value.ToString() == "Date Of Visit")
            {
                objHospitalDB = new HospitalDB();

                // Visit objVisit = new Visit(objHospitalDB);
                // string Name = ultraDateTimeSearch.Text;
                // DateTime DOB = System.Convert.ToDateTime(ultraDateTimeEditorPatient.Text);
                Visit objVisit = new Visit(objHospitalDB);
                SqlCommand cmd = objHospitalDB.CreateCommand("Visit_SearchByDateVisit");
                cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@DateOfVisit", ultraDateTimeSearch.Value);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                //dt = objVisit.GetAllAsDataTable();
                ultraGridVisit.DataSource = ds.Tables[0];
               /* DataView dvVisit = dtVisit.DefaultView;
                dvVisit.RowFilter = "DateOfVisit = #" + Convert.ToDateTime(ultraDateTimeSearch.Value).ToString("MM/dd/yyyy") + "#";
                ultraGridVisit.DataSource = dvVisit.ToTable();*/
            }
            else if (ultraComboSearch.Value.ToString() == "Date Of Discharge")
            {
                SqlCommand cmd = objHospitalDB.CreateCommand("Visit_SearchByDateDischarge");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DateOfDischarge", ultraDateTimeSearch.Value);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                ultraGridVisit.DataSource = ds.Tables[0];
            }

            else if (ultraComboSearch.Value.ToString() == "Patient Name")
            {
                objHospitalDB = new HospitalDB();
              
               // Visit objVisit = new Visit(objHospitalDB);
                string Name = ultraTextSearch.Text;
               // DateTime DOB = System.Convert.ToDateTime(ultraDateTimeEditorPatient.Text);
                DataTable dt = new DataTable();
                SqlCommand cmd = objHospitalDB.CreateCommand("Visit_SearchByName");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PatientName", Name);
                //cmd.Parameters.AddWithValue("@DateOfBirth", DOB);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                //dt = objVisit.GetAllAsDataTable();
                ultraGridVisit.DataSource = ds.Tables[0];
             
            // ultraGridVisit.DataSource= objVisit.Search(objVisitRow);
              //  dvVisit.RowFilter= Convert.ToString(objVisit.//Search(objVisitRow));
               // ultraGridVisit.DataSource=  dvVisit.ToTable();
               /* DataView dvVisit = dtVisit.DefaultView;
                dvVisit.RowFilter = "PatientName like '" + ultraTextSearch.Text + "%'";
                ultraGridVisit.DataSource = dvVisit.ToTable();*/
            }
        }

        private void ultraGridVisit_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {

        }
    }
}
