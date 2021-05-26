using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MySide
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisForm regis = new RegisForm();
            regis.ShowDialog();
        }

        private void SingInBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void HabitFormBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HabitForm habit = new HabitForm();
            habit.ShowDialog();
        }

        private void HabitViewBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HabitView view = new HabitView();
            view.ShowDialog();
        }

        private void RemindBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reminder remind = new Reminder();
            remind.ShowDialog();
        }
    }
}
