using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MySide
{
    
    public partial class HabitView : Form
    {
        
        public HabitView()
        {
            InitializeComponent();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HabitForm habitForm = new HabitForm();
            habitForm.ShowDialog();
        }


        
        
private void HabitView_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=tcp:myside.database.windows.net,1433;Initial Catalog=mysidedb;Persist Security Info=False;User ID=myside;Password=Myadmin0;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlDataReader reader = null;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT namahabit FROM [dbo].[DaftarHabit]");
            cmd.Connection = con;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(reader["namahabit"].ToString());
            }
            con.Close();
        }

        private void btnReminder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reminder reminder = new Reminder();
            reminder.ShowDialog();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home homeform = new Home();
            homeform.ShowDialog();

        }
    }
}
