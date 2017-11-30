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
    public partial class frmDoctorView : Form
    {
        public frmDoctorView()
        {
            InitializeComponent();
        }
        frmNewDoctor objfrmNewDoctor;
        HospitalDB objHospitalDB;
        public DataTable dtDoctor;
        private void frmDoctorView_Load(object sender, EventArgs e)
        {
            objHospitalDB = new HospitalDB();
            Doctor objDoctor = new Doctor(objHospitalDB);
            DoctorRow objDoctorRow = new DoctorRow();
            ultraGridDoc.DataSource = objDoctor.GetAll();
            /* SqlCommand cmd = objHospitalDB.CreateCommand("SELECT * FROM Doctor");
             SqlDataAdapter sda = new SqlDataAdapter(cmd);
             dtDoctor = new DataTable();
             sda.Fill(dtDoctor);
             ultraGridDoc.DataSource = dtDoctor;*/
        }
        private void ultraBtnNew_Click(object sender, EventArgs e)
        {
            objfrmNewDoctor = new frmNewDoctor();
            objfrmNewDoctor.strFormMode = "NEW";
            objfrmNewDoctor.ShowDialog();
        }
        public string id;
        public string name;
        public string address;
        public string phone;
        private void ultraBtnEdit_Click(object sender, EventArgs e)
        {
            objfrmNewDoctor = new frmNewDoctor();
            objfrmNewDoctor.id = id.ToString();
            objfrmNewDoctor.Fullname = name.ToString();
            objfrmNewDoctor.Address = address.ToString();
            objfrmNewDoctor.PhoneNo = phone.ToString();
            objfrmNewDoctor.strFormMode = "EDIT";
            objfrmNewDoctor.ShowDialog();
        }

        private void ultraBtnDelete_Click(object sender, EventArgs e)
        {try
            {
               if(MessageBox.Show("Are you sure you want to delete?" ,"delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    objHospitalDB = new HospitalDB();
                    Doctor objDoctor = new Doctor(objHospitalDB);
                    DoctorRow objDoctorRow = new DoctorRow();
                    objDoctorRow.Doctor_ID = Convert.ToInt32(this.id);
                    objDoctor.Delete(objDoctorRow);
                    ultraGridDoc.DataSource = objDoctor.GetAll();
                }
             
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*try
            {
                objHospitalDB = new HospitalDB();
               // con.Open();
                ultraGridDoc.Rows[this.ultraGridDoc.ActiveRow.Index].Delete(true);
                SqlCommand query = objHospitalDB.CreateCommand("delete from Doctor where Doctor_ID='" + this.id + "';", false);
                int p = query.ExecuteNonQuery();
        
                MessageBox.Show(p + "Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
             if(objHospitalDB!=null)
                {
                    objHospitalDB.Dispose();
                }
            }*/
        }
        public DataSet dsDoctor;
        private void ultraBtnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                objHospitalDB = new HospitalDB();
                Doctor objDoctor = new Doctor(objHospitalDB);
                DoctorRow objDoctorRow = new DoctorRow();
                ultraGridDoc.DataSource = objDoctor.GetAll();
               /* dsDoctor = new DataSet(); 
                SqlCommand cmd = objHospitalDB.CreateCommand("Select * from [Hospital].[dbo].[Doctor]", false);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(dsDoctor);
                ultraGridDoc.DataSource = dsDoctor.Tables[0];*/
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

        private void ultraGridDoc_AfterRowActivate(object sender, EventArgs e)
        {
            UltraGridRow row = this.ultraGridDoc.ActiveRow;
            if (row != null)
            {
                //this.txtFirstName.Text = row.Cells["First Name"].Text;
                id = row.Cells["Doctor_ID"].Text;
                name = row.Cells["FullName"].Text;
                address = row.Cells["Doc_Address"].Text;
                phone = row.Cells["Phone"].Text;
                // this.txtLastName.Text = row.Cells["Last Name"].Text;
            }
        }
    }
}
