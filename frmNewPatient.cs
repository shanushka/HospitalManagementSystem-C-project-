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
using MyCompany.MyProject.Db;

namespace Hospital
{
    public partial class frmNewPatient : Form
    {
        public frmNewPatient()
        {
            InitializeComponent();
        }
        public string id;
        public string strFormMode;
        public string name;
        public string phone;
        public string address;
        public string emergencyContact;
        public string dob;
        public string dor;
        private void frmNewPatient_Load(object sender, EventArgs e)
        {
            ultraTextEditorID.Text = id;
            ultraTextFullName.Text = name;
            ultraTextPhoneNumber.Text = phone;
            ultraTextEmergencyContact.Text = emergencyContact;
            ultraTextAddress.Text = address;
            ultraCalendarComboDOB.Text = dob;
            ultraCalendarComboDOR.Text = dor;
        }
        HospitalDB objHospitalDB = null;
      
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                objHospitalDB = new HospitalDB();
                Patient objPatient = new Patient(objHospitalDB);
                PatientRow objPatientRow = new PatientRow();
                objPatientRow.Patient_Address = ultraTextAddress.Text;
                objPatientRow.DateOfBirth = Convert.ToDateTime(ultraCalendarComboDOB.Text);
                objPatientRow.DateOfRegistration = Convert.ToDateTime(ultraCalendarComboDOR.Text);
                objPatientRow.FullName = ultraTextFullName.Text;
                objPatientRow.Phone = Convert.ToInt32(ultraTextPhoneNumber.Text);
                objPatientRow.Emergency_Contact = Convert.ToInt32(ultraTextEmergencyContact.Text);



                //DataTable dtPatient = new DataTable();

                if (strFormMode == "NEW")
                {
                    if (MessageBox.Show("Are you sure You want to save", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objPatient.Insert(objPatientRow);
                        this.Hide();
                    }
                }
                else if (strFormMode == "EDIT")
                {
                    try
                    {
                        objPatientRow.Patient_ID = Convert.ToInt32(this.id);
                        objPatient.Update(objPatientRow);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ultraGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void ultraTextEditorID_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ultraTextFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ultraTextAddress_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ultraCalendarComboDOB_BeforeDropDown(object sender, CancelEventArgs e)
        {

        }

        private void ultraTextPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void ultraTextEmergencyContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void ultraCalendarComboDOR_BeforeDropDown(object sender, CancelEventArgs e)
        {

        }

        private void ultraBtnPUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "images| *.JPG; *.PNG; *.GJF"; // you can add any other image type 
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ultraPictureBoxPatient.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
