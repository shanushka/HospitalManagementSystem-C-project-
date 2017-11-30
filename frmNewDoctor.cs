using MyCompany.MyProject.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class frmNewDoctor : Form
    {
        public frmNewDoctor()
        {
            InitializeComponent();
        }
        public string id;
        public string Fullname;
        public string Address;
        public string PhoneNo;
        public string strFormMode;
     

        frmMain objfrmDoctorDetail;
        
        private void frmNewDoctor_Load(object sender, EventArgs e)
        {
            ultraTextEditorID.Text = id;
            ultraTextFullName.Text = Fullname;
            ultraTextAddress.Text = Address;
            ultraTextPhoneNumber.Text = PhoneNo;
        }
        private void ultraBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        HospitalDB objHospitalDB = null;

        private void ultraBtnSave_Click(object sender, EventArgs e)
        {

            objHospitalDB = new MyCompany.MyProject.Db.HospitalDB();
            Doctor objDoctor = new Doctor(objHospitalDB);
            DoctorRow objDoctorRow = new MyCompany.MyProject.Db.DoctorRow();
            objDoctorRow.FullName = ultraTextFullName.Text;
            objDoctorRow.Phone = ultraTextPhoneNumber.Text;
            objDoctorRow.Doc_Address = ultraTextAddress.Text;

            if (strFormMode == "NEW")
                objDoctor.Insert(objDoctorRow);
            else if (strFormMode == "EDIT")
                objDoctorRow.Doctor_ID =Convert.ToInt32( ultraTextEditorID.Text); 
                
                objDoctor.Update(objDoctorRow);
            //string query = "insert into Doctor Values('" + ultraTextFullName.Text + "','" + ultraTextAddress.Text + "','" + ultraTextPhoneNumber.Text + "')";


            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-89LF16D;Initial Catalog=Hospital;Integrated Security=True");
            /* if (strFormMode == "NEW")
             {
                 try
                 {

                     objHospitalDB = new HospitalDB();
                     string query1 = "insert into Doctor Values('" + ultraTextFullName.Text + "','" + ultraTextAddress.Text + "','" + ultraTextPhoneNumber.Text + "')";
                     SqlCommand cmd = objHospitalDB.CreateCommand(query1, false);
                     //  cmd.Parameters.Add(new SqlParameter("@images", images));
                     int p = cmd.ExecuteNonQuery();

                     MessageBox.Show(p.ToString() + "registerd");
                     this.Close();
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
             else
             {
                 try
                 {

                     objHospitalDB = new HospitalDB();
                     SqlCommand cmd = objHospitalDB.CreateCommand("update Doctor set FullName='" + ultraTextFullName.Text + "',Doc_Address='" + ultraTextAddress.Text + "',Phone='" + ultraTextPhoneNumber.Text + "' where Doctor_ID= '" + ultraTextEditorID.Text + "'",false);
                     int o = cmd.ExecuteNonQuery();

                     MessageBox.Show(o + ":updated");
                     this.Close();
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                     if (objHospitalDB != null)
                     {
                         objHospitalDB.Dispose();
                     }
                 }
             }*/
        }

        private void ultraTextPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"^[0-9\b]"))
            {
                e.Handled = true;
            }
        }
        string imgLocation = "";
        private void ultraBtnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "images| *.JPG; *.PNG; *.GJF"; // you can add any other image type 
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgLocation = ofd.FileName.ToString();
                //pictureBox1.ImageLocation = imgLocation;
            }
        }

        private void ultraGroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
