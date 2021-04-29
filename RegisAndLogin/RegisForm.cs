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

namespace Myside2
{
    public partial class RegisForm : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public RegisForm()
        {
            InitializeComponent();
        }
         
        private void RegisForm_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\MySideHabit.mdf;Integrated Security=True;Connect Timeout=30");
            cn.Open();
        }

        private void RegistBtn_Click(object sender, EventArgs e)
        {
            if (EmailTb.Text != string.Empty || NameTb.Text != string.Empty || PassTb.Text != string.Empty)
            {
                cmd = new SqlCommand("select * from NewUserTbl where Uname='" + NameTb.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("User Already exist, Please Login");
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("insert into NewUserTbl values(@Uemail,@Uname,@Upass)", cn);
                    cmd.Parameters.AddWithValue("Uemail", EmailTb.Text);
                    cmd.Parameters.AddWithValue("Uname", NameTb.Text);
                    cmd.Parameters.AddWithValue("Upass", PassTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field");
            }

            User iUser = new User();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

    }
}