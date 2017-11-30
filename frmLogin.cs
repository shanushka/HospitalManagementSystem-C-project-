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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }
        frmMain objfrmMain;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Anushka\Documents\data.mdf; Integrated Security = True; Connect Timeout = 30");
            SqlDataAdapter sqa = new SqlDataAdapter("SELECT Count(*) From login where UserName = '" + txtUserName.Text + "'and Password = '" + txtPassword.Text + "'", conn);
            DataTable dt = new DataTable();
            sqa.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
              
                objfrmMain = new frmMain();
         
                objfrmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check your UserName And password");
            }
        }
    }
}
