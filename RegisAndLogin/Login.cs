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
    public partial class Login : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\MySideHabit.mdf;Integrated Security=True;Connect Timeout=30");
            cn.Open();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            User iUser = new User();

            if (EmailLogTb.Text != string.Empty || PassLogTb.Text != string.Empty)
            {
                cmd = new SqlCommand("select * from NewUserTbl where Uemail='" + EmailLogTb.Text + "' and Upass='" + PassLogTb.Text + "'", cn);
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
    }
}
