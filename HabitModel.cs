using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace StreakzApp_WindowsForm_prototype
{
    public class HabitModel
    {
        /// <summary>
        /// Unique identifier for habit.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the habit.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the habit ie what should be completed.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Integer representing the ammount of days in a row the habit has been completed.
        /// </summary>
        public int Interval { get; set; }

        /// <summary>
        /// Integer that represents how many days in a row the habit has been completed.
        /// </summary>
        public int Streak { get; set; }

        /// <summary>
        /// Bool that represents if the habit is completed or not.
        /// </summary>
        public bool HabitCompleted { get; set; }

        /// <summary>
        /// DateTime that the HabitModel was instanciated.
        /// </summary>
        public DateTime TimeCreated { get; set; }

        /// <summary>
        /// The ammount of days before a habit must be completed.
        /// </summary>
        public DateTime DueTime { get; set; }

        /// <summary>
        /// The name that will be shown in the form.
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// Max ammount of days that a habit has been completed in a row.
        /// </summary>
        public int MaxStreak { get; set; }

        /// <summary>
        /// Set the display name depending on if the habit is completed or not.
        /// </summary>
        public void SetDisplayName()
        {
            int daysLeft = DueTime.Day - DateTime.Now.Day;
            DisplayName = $"{Name} {Streak}:{daysLeft}";

            if (HabitCompleted)
            {
                DisplayName += " 🔥 ";
            }
            else if (!HabitCompleted)
            {
                DisplayName += " 🕑 ";
            }
        }

        public void SetMaxStreak()
        {
            if (MaxStreak < Streak && !(MaxStreak > Streak))
            {
                MaxStreak = Streak;
            }
        }
    }
}
