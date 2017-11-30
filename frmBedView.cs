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
    public partial class frmBedView : Form
    {
        public frmBedView()
        {
            InitializeComponent();
        }
        HospitalDB objHospitalDB = null;
        frmBed objfrmBed;
        private void ultraBtnBNew_Click(object sender, EventArgs e)
        {
            objfrmBed = new frmBed();
            objfrmBed.strFormMode = "NEW";
            objfrmBed.ShowDialog();
        }

        private void ultraBtnBEdit_Click(object sender, EventArgs e)
        {
            objfrmBed = new frmBed();
            objfrmBed.id = bed_id.ToString();
            objfrmBed.name = bed_name.ToString();
            objfrmBed.rpd = bed_rpd.ToString();
            objfrmBed.bedtype = bed_type.ToString();
            objfrmBed.strFormMode = "EDIT";
            objfrmBed.ShowDialog();
        }

        private void ultraBtnBDelete_Click(object sender, EventArgs e)
        {
            try
            {
                objHospitalDB = new HospitalDB();
                Bed objBed = new Bed(objHospitalDB);
                BedRow objBedRow = new BedRow();
                objBedRow.Bed_ID = Convert.ToInt32(this.bed_id);
                objBed.Delete(objBedRow);
                ultraGridBed.DataSource = objBed.GetAll();
                /*ultraGridBed.Rows[this.ultraGridBed.ActiveRow.Index].Delete(true);
                SqlCommand query = objHospitalDB.CreateCommand("delete from Bed where Bed_ID='" + this.bed_id + "';", false);
                int p = query.ExecuteNonQuery();
                MessageBox.Show(p + "Deleted");*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if(objHospitalDB!=null)
                {
                    objHospitalDB.Dispose();
                }
            }
        }
        public string bed_id;
        public string bed_name;
        public string bed_rpd;
        public string bed_type;
        private void ultraGridBed_AfterRowActivate(object sender, EventArgs e)
        {
            UltraGridRow row = this.ultraGridBed.ActiveRow;
            if (row != null)
            {

                bed_id = row.Cells["Bed_ID"].Text;
                bed_name = row.Cells["BedName"].Text;
                bed_rpd = row.Cells["RatePerDay"].Text;
                bed_type = row.Cells["BedType"].Text;

            }
        }
        public DataSet dsBed;
        private void ultraBtnBRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                objHospitalDB = new HospitalDB();
                dsBed = new DataSet();
                SqlCommand cmd = objHospitalDB.CreateCommand("Select * from [Hospital].[dbo].[Bed]", false);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(dsBed);
                ultraGridBed.DataSource = dsBed.Tables[0];
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
        public DataTable dtBed;
        private void frmBedView_Load(object sender, EventArgs e)
        {
            objHospitalDB = new HospitalDB();
            SqlCommand cmd = objHospitalDB.CreateCommand("SELECT * FROM Bed");
            SqlDataAdapter sdab = new SqlDataAdapter(cmd);
            dtBed = new DataTable();
            sdab.Fill(dtBed);
            ultraGridBed.DataSource = dtBed;
         
        }
    }
}
