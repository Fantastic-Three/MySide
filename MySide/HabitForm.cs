﻿using System;
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
    public partial class HabitForm : Form
    {
        string Opsi;
        
        public HabitForm()
        {
            InitializeComponent();
            
        }

        private void HabitForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Server=tcp:myside.database.windows.net,1433;Initial Catalog=mysidedb;Persist Security Info=False;User ID=myside;Password=Myadmin0;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            
            SqlCommand cmd = sqlcon.CreateCommand();
            if (cmd.Connection.State != ConnectionState.Open) 
                cmd.Connection.Open();
            
            

            cmd = new SqlCommand("INSERT INTO [dbo].[DaftarHabit](namahabit, keterangan, hdate) VALUES ('" + tbHabitName.Text + "', '" + tbHabitDesc.Text + "', '" + dateTimePicker1.Value.ToString() + "')", sqlcon);
            
            cmd.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("Data Habit Berhasil Disimpan");
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home homeform = new Home();
            homeform.ShowDialog();
        }
    }
}
