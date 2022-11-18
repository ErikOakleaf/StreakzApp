using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace StreakzApp_WindowsForm_prototype
{
    public partial class MainWindow : Form
    {
        List<HabitModel> habits;
        public MainWindow()
        {
            InitializeComponent();

            WireUpLists();

            descriptionTextBox.ReadOnly = true;
        }

        private void WireUpLists()
        {
            habits = GlobalConfig.HabitsFile.FullFilePath().LoadFile().ConvertToHabitModels();
            habitsListBox.DataSource = habits;
            habitsListBox.DisplayMember = "DisplayName";
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            dateTimer.Start();
        }

        private void dateTimer_Tick(object sender, EventArgs e)
        {
            dateTimeLabel.Text = DateTime.Now.ToString();

            foreach (HabitModel h in habits)
            {
                DateTime dt = DateTime.Now;
                //DateTime dt = DateTime.Now.AddDays(0);
                if (dt > h.DueTime.AddDays(h.Interval))
                {
                    h.DueTime = dt.AddDays(h.Interval);
                    h.Streak = 0;
                    h.HabitCompleted = false;
                    GlobalConfig.Connection.UpdateHabit(h);
                    WireUpLists();
                }
                else if (dt > h.DueTime && h.HabitCompleted)
                {
                    h.DueTime = h.DueTime.AddDays(h.Interval);
                    h.Streak += h.Interval;
                    h.SetMaxStreak();
                    h.HabitCompleted = false;

                    GlobalConfig.Connection.UpdateHabit(h);
                    WireUpLists();
                }
                else if (dt > h.DueTime && !h.HabitCompleted)
                {
                    h.DueTime = dt.AddDays(h.Interval);
                    h.Streak = 0;
                    GlobalConfig.Connection.UpdateHabit(h);
                    WireUpLists();
                }
            }
        }

        private void completeHabitButton_Click(object sender, EventArgs e)
        {
            HabitModel h = (HabitModel)habitsListBox.SelectedItem;

            if (h.HabitCompleted)
            {
                h.HabitCompleted = false;
            }
            else if (!h.HabitCompleted)
            {
                h.HabitCompleted = true;
            }
            h.SetDisplayName();


            GlobalConfig.Connection.UpdateHabit(h);
            int tmpInd = habitsListBox.SelectedIndex;
            WireUpLists();
            habitsListBox.SelectedIndex = tmpInd;
        }

        private void createHabitButton_Click(object sender, EventArgs e)
        {
            CreateHabitForm chf = new CreateHabitForm();
            chf.Show();
            chf.ButtonWasClicked += new CreateHabitForm.ClickButton(WireUpLists);
        }

        private void editHabitButton_Click(object sender, EventArgs e)
        {
            EditHabitForm ehf = new EditHabitForm((HabitModel)habitsListBox.SelectedItem);
            ehf.Show();
            ehf.ButtonWasClicked += new EditHabitForm.ClickButton(WireUpLists);
        }

        private void habitsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            WireUpTextBox();
        }

        private void WireUpTextBox()
        {
            HabitModel h = (HabitModel)habitsListBox.SelectedItem;
            if (h.Description.Length == 0)
            {
                descriptionTextBox.Hide();
            }
            else
            {
                descriptionTextBox.Show();
            }
            descriptionTextBox.Text = h.Description;
        }
    }
}
