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
    public partial class HabitForm : Form
    {
        public Habit habit;
        public enum Mode {Insert, Edit}
        Mode mode;
        
        public HabitForm()
        {
            InitializeComponent();
            mode = Mode.Insert;
            btnAction.Text = "Add";
        }

        public HabitForm(string namahabit, string keterangan, string calendar, string yesorno)
        {
            InitializeComponent();
            mode = Mode.Edit;
            habit = new Habit
            {
                NamaHabit = namahabit,
                Keterangan = keterangan,
                Calendar = calendar,
                YesOrNo = yesorno
            };
            tbNamaHabit.Text = namahabit;
            tbKeterangan.Text = keterangan;
            tbCalendar.Text = calendar;
            tbYesOrNo.Text = yesorno;
            btnAction.Text = "Save";
        }

        private void AddHabit()
        {
            if (tbNamaHabit.Text != "" && tbKeterangan.Text != "" && tbCalendar.Text != "")
            {
                using (var db = new HabitModel())
                {
                    habit = new Habit
                    {
                        NamaHabit = tbNamaHabit.Text,
                        Keterangan = tbKeterangan.Text,
                        Calendar = tbCalendar.Text,
                        YesOrNo = tbYesOrNo.Text,
                    };
                    db.Habits.Add(habit);
                    db.SaveChanges();
                    MessageBox.Show("Habit Added Successfully");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Data must be filled");
            }
        }

        private void EditHabit()
        {
            using (var db = new HabitModel())
            {
                var result = db.Habits.SingleOrDefault(k => k.NamaHabit == habit.NamaHabit);
                if (result != null)
                {
                    if (tbNamaHabit.Text != "" && tbKeterangan.Text != "" && tbCalendar.Text != "")
                    {
                        result.NamaHabit = tbNamaHabit.Text;
                        result.Keterangan = tbKeterangan.Text;
                        result.Calendar = tbCalendar.Text;
                        result.YesOrNo = tbYesOrNo.Text;
                        db.SaveChanges();
                        MessageBox.Show("Habit Updated Successfully");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Data must be filled");
                    }
                }
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Insert)
                AddHabit();
            else if (mode == Mode.Edit)
                EditHabit();
        }
    }
}
