using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrasiLogin
{
    public partial class LoadingPage : Form
    {
        public LoadingPage()
        {
            InitializeComponent();
        }

        int startpoint = 0; 

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            progressBar.Value = startpoint;
            if (progressBar.Value == 100)
            {
                progressBar.Value = 0;
                timer1.Stop();
                RegisForm regis = new RegisForm();
                regis.Show();
                this.Hide();
            }
        }

        private void LoadingPage_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
