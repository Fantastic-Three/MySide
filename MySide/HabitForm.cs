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
    public partial class HabitForm : Form
    {
        string Opsi;
        
        public HabitForm()
        {
            InitializeComponent();
            
        }

        private void HabitForm_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Server=tcp:myside.database.windows.net,1433;Initial Catalog=mysidedb;Persist Security Info=False;User ID=myside;Password=Myadmin0;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            sqlcon.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Masukkan nilai ke dalam tabel ('" + tbHabitName.Text + "', '" + tbHabitDesc.Text + "', '" + dateTimePicker1.Value.ToString() + "')";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("Data Habit Berhasil Disimpan");
        }
    }
}
