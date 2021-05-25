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
    public partial class Reminder : Form
    {
        public Reminder()
        {
            InitializeComponent();
        }

        private void Reminder_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=tcp:myside.database.windows.net,1433;Initial Catalog=mysidedb;Persist Security Info=False;User ID=myside;Password=Myadmin0;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT namahabit FROM [dbo.DaftarHabit] WHERE hdate = CURDATE()");
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                checkedListBox1.Items.Add(reader["namahabit"].ToString());
            }
            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedItems.Count > 0)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=tcp:myside.database.windows.net,1433;Initial Catalog=mysidedb;Persist Security Info=False;User ID=myside;Password=Myadmin0;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                con.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT namahabit FROM [dbo.DaftarHabit] WHERE hdate = CURDATE()");

                //loop through all selected items
                foreach (object item in checkedListBox1.CheckedItems)
                {
                    //convert item to string
                    string checkedItem = item.ToString();

                    //insert item to database
                    SqlCommand cmd2 = new SqlCommand("Insert into [dbo.DaftarHabit] Values (@checklist)", con);
                    cmd2.Parameters.AddWithValue("@checklist", checkedItem); //add item
                    cmd2.ExecuteNonQuery();
                }

                //close connection
                con.Close();
                MessageBox.Show("Data has been saved");
            }
        }
    }
}
