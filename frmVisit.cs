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
    public partial class frmVisit : Form
    {
        public frmVisit()
        {
            InitializeComponent();
          
        }

        private void ultraBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string strFormMode;

        public string id;
        public string dov;
        public string dod;
        public string symptoms;
        public string disease;
        public string treatment;
        public string patienttype;
        public string patientid;
        HospitalDB objHospitalDB = null;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-89LF16D;Initial Catalog=Hospital;Integrated Security=True");
        private void ultraBtnSave_Click(object sender, EventArgs e)
        {
            objHospitalDB = new HospitalDB();
            Visit objVisit = new Visit(objHospitalDB);
            VisitRow objVisitRow = new VisitRow();
            objVisitRow.DateOfDischarge = Convert.ToDateTime(ultraCalendarComboDOD.Text);
            objVisitRow.DateOfVisit = Convert.ToDateTime(ultraCalendarComboDOV.Text);
            objVisitRow.Disease = ultraTextDisease.Text;
            objVisitRow.Symptoms = ultraTextSymtoms.Text;
            objVisitRow.Treatment = ultraTextTreatment.Text;
            objVisitRow.DoctorID = Convert.ToInt32(ultraComboEditorDoctorID.Text);
            objVisitRow.BedID = Convert.ToInt32(ultraComboBedID.Text);
            objVisitRow.PatientID = Convert.ToInt32(ultraComboEditorPatientID.Text);
            if (strFormMode=="NEW")
            {
                try
                {
                   
                    if (radioBtnInPatient.Checked == true)
                    {
                        objVisitRow.PatientType = radioBtnInPatient.Text;
                        objVisit.Insert(objVisitRow);
              
                    }
                    else if (radioBtnOutPatient.Checked == true)
                    {
                        objVisitRow.PatientType = radioBtnOutPatient.Text;
                        objVisit.Insert(objVisitRow);
                    
                        //query = objHospitalDB.CreateCommand("insert into Visit(PatientType,PatientName,PatientID,BedID,DoctorID,DateOfVisit,DateOfDischarge,Symptoms,Disease,Treatment) Values('" + c + "','" + ultraComboEditorPName.Text + "','" + ultraComboEditorPatientID.Text + "','" + ultraComboBedID.Text + "','" + ultraComboEditorDoctorID.Text + "','" + ultraCalendarComboDOV.Text + "','" + ultraCalendarComboDOV.Text + "','" + ultraTextSymtoms.Text + "','" + ultraTextDisease.Text + "','" + ultraTextTreatment.Text + "')", false);
                    }
                    else
                    {
                        objVisit.Insert(objVisitRow);
                    
                       // query = objHospitalDB.CreateCommand("insert into Visit(PatientName,PatientID,DoctorID,BedID,DateOfVisit,DateOfDischarge,Symptoms,Disease,Treatment) Values('" + ultraComboEditorPName.Text + "','" + ultraComboEditorPatientID.Text + "','" + ultraComboEditorDoctorID.Text + "','" + ultraComboBedID.Text + "','" + ultraCalendarComboDOV.Text + "','" + ultraCalendarComboDOD.Text + "','" + ultraTextSymtoms.Text + "','" + ultraTextDisease.Text + "','" + ultraTextTreatment.Text + "')", false);
                    }
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
          
                    if (radioBtnInPatient.Checked == true)

                    {
                        objVisitRow.PatientType = radioBtnInPatient.Text;
                        objVisitRow.VisitorID = Convert.ToInt32(this.id);
                        objVisit.Update(objVisitRow);
                    }
                    else if (radioBtnOutPatient.Checked == true)
                    {
                        objVisitRow.PatientType = radioBtnOutPatient.Text;
                        objVisitRow.VisitorID = Convert.ToInt32(this.id);
                        objVisit.Update(objVisitRow);
                    }
                    else
                    {
                        objVisitRow.VisitorID = Convert.ToInt32(this.id);
                        objVisit.Update(objVisitRow);
                    }
                   this.Hide();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    if(objHospitalDB!=null)
                    {
                        objHospitalDB.Dispose();
                    }
                }
            }
        }
        DataTable dtVisit=new DataTable();
        DataTable dtVisitDoctor = new DataTable();
        DataTable dtVisitPatient = new DataTable();
        DataTable dtVisitPatientN = new DataTable();
        public string patid;
        public string bedid;
        public string docid;
        public string patname;

        private void frmVisit_Load(object sender, EventArgs e)
        {
            ultraTextVisitorID.Text = id;
            ultraCalendarComboDOD.Text = dod;
            ultraCalendarComboDOV.Text = dov;
            ultraTextSymtoms.Text = symptoms;
            ultraTextTreatment.Text = treatment;
            ultraTextDisease.Text = disease;
            ultraComboEditorPatientID.Text = patid;
            ultraComboBedID.Text = bedid;
            ultraComboEditorDoctorID.Text = docid;
            /* if(radioBtnOutPatient.Checked==true)
                 { radioBtnOutPatient.Text = patienttype; }
             else
             { radioBtnInPatient.Text = patienttype; }*/
            ComboCall();
        }
            
    
                
        public void ComboCall()
        {
            SqlCommand cmd = new SqlCommand("select distinct Bed_ID from Bed ", con);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(dtVisit);
            ultraComboBedID.Items.Add("--select--");
            foreach (DataRow Row in dtVisit.Rows)
            {
                ultraComboBedID.Items.Add(Row["Bed_ID"].ToString());
            }
            SqlCommand cmdd = new SqlCommand("select distinct Doctor_ID from Doctor ", con);
            SqlDataAdapter sdad = new SqlDataAdapter();
            sdad.SelectCommand = cmdd;
            sdad.Fill(dtVisitDoctor);
            ultraComboEditorDoctorID.Items.Add("--select--");
            foreach (DataRow Row in dtVisitDoctor.Rows)
            {
            ultraComboEditorDoctorID.Items.Add(Row["Doctor_ID"].ToString());
            }
            SqlCommand cmdp = new SqlCommand("select distinct Patient_ID from Patient ", con);
            SqlDataAdapter sdap = new SqlDataAdapter();
            sdad.SelectCommand = cmdp;
            sdad.Fill(dtVisitPatient);
            ultraComboEditorPatientID.Items.Add("--select--");
            foreach (DataRow Row in dtVisitPatient.Rows)
            {
                ultraComboEditorPatientID.Items.Add(Row["Patient_ID"].ToString());
            }
            SqlCommand cmdpn = new SqlCommand("select distinct FullName from Patient ", con);
            SqlDataAdapter sdapn = new SqlDataAdapter();
            sdad.SelectCommand = cmdpn;
            sdad.Fill(dtVisitPatientN);
          /*  ultraComboEditorPName.Items.Add("--select--");
            foreach (DataRow Row in dtVisitPatientN.Rows)
            {
                ultraComboEditorPName.Items.Add(Row["FullName"].ToString());
            }*/
        }
    }

}
