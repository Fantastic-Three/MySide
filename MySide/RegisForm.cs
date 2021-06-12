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
    public partial class RegisForm : Form
    {
        private SqlCommand cmd;
        private SqlConnection cn;
        private SqlDataReader dr; 
        public RegisForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Server=tcp:myside.database.windows.net,1433;Initial Catalog=mysidedb;Persist Security Info=False;User ID=myside;Password=Myadmin0;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            cn.Open();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            
            if (tbEmail.Text != string.Empty || tbUsername.Text != string.Empty || tbPassword.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from [dbo].[User] where Email='" + tbEmail.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("User Already exist, Please Login");
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("insert into [dbo].[User] values (@Email,@Username,@Password)", cn);
                    cmd.Parameters.AddWithValue("Email", tbEmail.Text);
                    cmd.Parameters.AddWithValue("Username", tbUsername.Text);
                    cmd.Parameters.AddWithValue("Password", tbPassword.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field");
            }
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home homeform = new Home();
            homeform.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
