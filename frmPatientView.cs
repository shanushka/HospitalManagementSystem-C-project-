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
    public partial class frmPatientView : Form
    {
        public frmPatientView()
        {
            InitializeComponent();
            comboCall();
        }
        public DataTable dtPatient;
        frmNewPatient objfrmNewPatient;
        HospitalDB objHospitalDB;
        
        private void frmPatientView_Load(object sender, EventArgs e)
        {
            objHospitalDB = new HospitalDB();
            Patient objPatient = new Patient(objHospitalDB);
            dtPatient = objPatient.GetAllAsDataTable();
            ultraGridPatient.DataSource=dtPatient;
           // con.Open();
           /* SqlCommand cmd=objHospitalDB.CreateCommand( "SELECT * FROM Patient");
            SqlDataAdapter sdap = new SqlDataAdapter(cmd);
            dtPatient = new DataTable();
            sdap.Fill(dtPatient);
            ultraGridPatient.DataSource = dtPatient;*/
          
        }
        private void ultraBtnPNew_Click(object sender, EventArgs e)
        {

            objfrmNewPatient = new frmNewPatient();
            objfrmNewPatient.strFormMode = "NEW";
            objfrmNewPatient.ShowDialog();

        }
        public void comboCall()
        {
            DataTable dtPat = Class_Files.comboClass.LoadSearch();
            ultraComboPSearch.DataSource = dtPat;
            ultraComboPSearch.BindingContext = this.BindingContext;
            ultraComboPSearch.DisplayMember = "Search";
            ultraComboPSearch.ValueMember = "Search";
        
        }
        public string Pat_id;
        public string Pat_name;
        public string Pat_phone;
        public string Pat_dob;
        public string Pat_address;
        public string Pat_emergency;
        public string Pat_dor;
        private void ultraBtnPEdit_Click(object sender, EventArgs e)
        {
            objfrmNewPatient = new frmNewPatient();
            objfrmNewPatient.id = Pat_id.ToString();
            objfrmNewPatient.name = Pat_name.ToString();
            objfrmNewPatient.phone = Pat_phone.ToString();
            objfrmNewPatient.emergencyContact = Pat_emergency.ToString();
            objfrmNewPatient.address = Pat_address.ToString();
            objfrmNewPatient.dob = Pat_dob.ToString();
            objfrmNewPatient.dor = Pat_dor.ToString();
            objfrmNewPatient.strFormMode = "EDIT";
            objfrmNewPatient.ShowDialog();
        }
   
        private void ultraBtnPDelete_Click(object sender, EventArgs e)
        {
            objHospitalDB = new HospitalDB();
            Patient objPatient = new Patient(objHospitalDB);
            PatientRow objPatientRow = new PatientRow();
            objPatientRow.Patient_ID = Convert.ToInt32(this.Pat_id);
            objPatient.Delete(objPatientRow);
            ultraGridPatient.DataSource = objPatient.GetAll();
           /* ultraGridPatient.Rows[this.ultraGridPatient.ActiveRow.Index].Delete(true);
            SqlCommand query = objHospitalDB.CreateCommand("delete from Patient where Patient_ID='" + this.Pat_id + "';", false);
            int p = query.ExecuteNonQuery();
            MessageBox.Show(p + "Deleted");*/
        }

        private void ultraGridPatient_AfterRowActivate(object sender, EventArgs e)
        {
            UltraGridRow row = this.ultraGridPatient.ActiveRow;
            if (row != null)
            {
                //this.txtFirstName.Text = row.Cells["First Name"].Text;
                Pat_id = row.Cells["Patient_ID"].Text;
                Pat_name = row.Cells["FullName"].Text;
                Pat_address = row.Cells["Patient_Address"].Text;
                Pat_dob = row.Cells["DateOfBirth"].Text;
                Pat_phone = row.Cells["Phone"].Text;
                Pat_emergency = row.Cells["Emergency_Contact"].Text;
                Pat_dor = row.Cells["DateOfRegistration"].Text;

                // this.txtLastName.Text = row.Cells["Last Name"].Text;
            }
        }
      
        private void ultraBtnPSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            if (ultraComboPSearch.Value.ToString() == "Patient Name")
            {
                try
                {
                    objHospitalDB = new HospitalDB();
                    Patient objPatient = new Patient(objHospitalDB);
                    SqlCommand cmd = objHospitalDB.CreateCommand("Patient_Search");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FullName", ultraTextPSearch.Text);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    ultraGridPatient.DataSource = ds.Tables[0];
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (ultraComboPSearch.Value.ToString() == "Date Of Registration")
            {
                objHospitalDB = new HospitalDB();
                Patient objPatient = new Patient(objHospitalDB);
                SqlCommand cmd = objHospitalDB.CreateCommand("Patient_SearchByDate");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DOR", ultraDateTimePSearch.Value);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                ultraGridPatient.DataSource = ds.Tables[0];
            }
        }
        public DataSet dsPatient;
        private void ultraBtnPRefresh_Click(object sender, EventArgs e)
        {
            dsPatient = new DataSet();
            try
            {
                ultraTextPSearch.Text = "";
                ultraDateTimePSearch.Value = "";
                   objHospitalDB = new HospitalDB();
                Patient objPatient = new Patient(objHospitalDB);
                PatientRow objPatientRow = new PatientRow();
                dtPatient = objPatient.GetAllAsDataTable();
                ultraGridPatient.DataSource = dtPatient;
                /*SqlCommand cmd = objHospitalDB.CreateCommand("Select * from [Hospital].[dbo].[Patient]", false);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(dsPatient);
                ultraGridPatient.DataSource = dsPatient.Tables[0];*/
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

        private void ultraDateTimePSearch_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
