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
    public partial class RegisForm : Form
    {
        private SqlCommand cmd;
        private SqlConnection cn;
        private SqlDataReader dr;

        public RegisForm()
        {
            InitializeComponent();
        }
        private void RegisForm_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source = LAPTOP-112AQKDQ; Initial Catalog = DB_UserMySide; Integrated Security = True");
            cn.Open();
        }
        private void btnRegis_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text != string.Empty || tbUsername.Text != string.Empty || tbPassword.Text != string.Empty)
            {
                
                cmd = new SqlCommand("select * from TB_NewUser where Email='" + tbEmail.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("User Already exist, Please Login");
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("insert into TB_NewUser values(@Email,@Username,@Password)", cn);
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }
    }
    }
