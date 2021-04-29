using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HabitForm
{
    public partial class Form1 : Form
    {
        //private object habit;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HabitForm habitForm = new HabitForm();
            habitForm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblNamaHabit.Text = "-";
            lblKeterangan.Text = "-";
            lblCalendar.Text = "-";
            lblYesOrNo.Text = "-";
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            using (var db = new HabitModel())
            {
                var query = from kontak in db.Habits where habit.NamaHabit == tbHabitSearch.Text select habit;
                foreach(var item in query)
                {
                    lblNamaHabit.Text = item.NamaHabit;
                    lblKeterangan.Text = item.Keterangan;
                    lblCalendar.Text = item.Calendar;
                    lblYesOrNo.Text = item.YesOrNo;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            HabitForm habitForm = new HabitForm(lblNamaHabit.Text, lblKeterangan.Text, lblCalendar.Text, lblYesOrNo.Text);
            habitForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using(var db = new HabitModel())
            {
                db.Habits.RemoveRange(db.Habits.Where(item => item.NamaHabit == lblNamaHabit.Text));
                db.SaveChanges();
                lblNamaHabit.Text = "-";
                lblKeterangan.Text = "-";
                lblCalendar.Text = "-";
                lblYesOrNo.Text = "-";
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
    }
}
