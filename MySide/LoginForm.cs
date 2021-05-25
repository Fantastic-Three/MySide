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

namespace MySide
{
    public partial class LoginForm : Form
    {
         
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text != string.Empty || tbPassword.Text != string.Empty)
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "Server=tcp:myside.database.windows.net,1433;Initial Catalog=mysidedb;Persist Security Info=False;User ID=myside;Password=Myadmin0;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from [dbo.User] where Email='" + tbEmail.Text + "' and Password='" + tbPassword.Text + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Visible = false;
                    HabitView habit = new HabitView();
                    habit.ShowDialog();
                    
                    tbEmail.Text = "";
                    tbPassword.Text = "";
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

        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisForm regis = new RegisForm();
            regis.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
