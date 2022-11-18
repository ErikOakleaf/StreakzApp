using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreakzApp_WindowsForm_prototype
{
    public partial class EditHabitForm : Form
    {
        public HabitModel Habit { get; set; }
        public EditHabitForm(HabitModel habit)
        {
            InitializeComponent();

            Habit = habit;
            
            WireUpLists();
        }

        private void WireUpLists()
        {
            timeCreatedLabel.Text = "Created: " + Habit.TimeCreated.ToShortDateString();
            maxStreakLabel.Text = "Max Streak: " + Habit.MaxStreak.ToString();
            nameTextBox.Text = Habit.Name;
            intervalTextBox.Text = Habit.Interval.ToString();
            descriptionTextBox.Text = Habit.Description;
        }

        private void editHabitButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                HabitModel h = Habit;
                h.Name = nameTextBox.Text;
                h.Interval = int.Parse(intervalTextBox.Text);
                h.Description = descriptionTextBox.Text;

                GlobalConfig.Connection.UpdateHabit(h);

                ButtonWasClicked();
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Form invalid");
            }
        }

        public delegate void ClickButton();
        public event ClickButton ButtonWasClicked;

        private void removeHabitButton_Click(object sender, EventArgs e)
        {
            GlobalConfig.Connection.RemoveHabit(Habit);
            ButtonWasClicked();
            this.Close();
        }

        private bool ValidateForm()
        {
            if (nameTextBox.Text.Length < 1)
            {
                return false;
            }
            if (!int.TryParse(intervalTextBox.Text, out int n) || n < 1)
            {
                return false;
            }

            return true;
        }
    }
}
