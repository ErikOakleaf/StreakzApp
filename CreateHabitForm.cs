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
    public partial class CreateHabitForm : Form
    {
        public CreateHabitForm()
        {
            InitializeComponent();
        }

        private void createHabitButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                HabitModel h = new HabitModel();
                h.Name = nameTextBox.Text;
                h.Interval = int.Parse(intervalTextBox.Text);
                h.Description = descriptionTextBox.Text;

                GlobalConfig.Connection.CreateHabit(h);

                nameTextBox.Text = "";
                intervalTextBox.Text = "";
                descriptionTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("All nescesary fields must be filled");
            }

            ButtonWasClicked();
        }

        public delegate void ClickButton();
        public event ClickButton ButtonWasClicked;

        private bool ValidateForm()
        {
            if (nameTextBox.Text.Length == 0)
                return false;
            if (intervalTextBox.Text.Length == 0)
                return false;
            return true;
        }
    }
}
