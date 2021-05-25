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

namespace RegistrasiLogin
{
    public partial class LoginForm : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source = LAPTOP-112AQKDQ; Initial Catalog = DB_UserMySide; Integrated Security = True");
            cn.Open();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text != string.Empty || tbPassword.Text != string.Empty)
            {
                cmd = new SqlCommand("select * from TB_NewUser where Email='" + tbEmail.Text + "' and Password='" + tbPassword.Text + "'", cn);
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    //Habit habit = new Habit();
                    //habit.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account available with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisForm regis = new RegisForm();
            regis.ShowDialog();
        }

       
    }
}
