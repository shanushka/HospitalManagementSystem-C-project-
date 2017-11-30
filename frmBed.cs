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
    public partial class frmBed : Form
    {
        public frmBed()
        {
            InitializeComponent();
            comboCall();
        }
        public string strFormMode;
        public string id;
        public string name;
        public string rpd;
        public string bedtype;
        private void frmBed_Load(object sender, EventArgs e)
        {
            ultraTextEditorBedID.Text = id;
            ultraTextBedName.Text = name;
            ultraTextRatePerDay.Text = rpd;
            ultraComboBed.Text = bedtype;
        }
        public void comboCall()
        {
            DataTable dt = Class_Files.comboClass.LoadComboBed();
            ultraComboBed.DataSource = dt;
            ultraComboBed.BindingContext = this.BindingContext;
            ultraComboBed.DisplayMember = "Types Of Bed";
            ultraComboBed.ValueMember = "Types Of Bed";
           
        }
        HospitalDB objHospitalDB = new HospitalDB();
       // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-89LF16D;Initial Catalog=Hospital;Integrated Security=True");

        private void ultraBtnSave_Click(object sender, EventArgs e)
        {
            objHospitalDB = new HospitalDB();
            Bed objBed = new Bed(objHospitalDB);
            BedRow objBedRow = new BedRow();
            objBedRow.BedName = ultraTextBedName.Text;
            objBedRow.BedType = ultraComboBed.Text;
            objBedRow.RatePerDay = Convert.ToInt32(ultraTextRatePerDay.Text);

            if (strFormMode == "NEW")
            {
                if (MessageBox.Show("Are you sure you want to save", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objBed.Insert(objBedRow);
                    this.Hide();
                }
            }
            /*SqlCommand query = objHospitalDB.CreateCommand("insert into Bed Values('" + ultraTextBedName.Text + "','" + ultraTextRatePerDay.Text + "','" + ultraComboBed.Text + "')", false);
            // SqlDataAdapter sda = new SqlDataAdapter(query, con);
            int p = query.ExecuteNonQuery();
           MessageBox.Show(p + "Value is registerd");
            this.Hide();*/

            else
            {

                objBedRow.Bed_ID = Convert.ToInt32(this.id);
                objBed.Update(objBedRow);
            }
            }
        

        private void ultraBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
