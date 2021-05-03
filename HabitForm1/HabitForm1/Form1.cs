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

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        string Opsi;
        SqlConnection sqlcon = new SqlConnection(@"Data Source = DESKTOP-AGMG99M; Initial Catalog=datetime; Integrated Security=True; Pooling=False");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Masukkan nilai ke dalam tabel ('"+ tbNamaHabit.Text +"', '"+ tbKeterangan.Text +"', '"+ dateTimePicker1.Value.ToString() +"', '" + Opsi +"')";
            cmd.ExecuteNonQuery(); 
            sqlcon.Close();
            MessageBox.Show("Data Habit Berhasil Disimpan");
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            Opsi = "Done";
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            Opsi = "Not Yet";
        }
    }
}
