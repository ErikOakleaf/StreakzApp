using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreakzApp_WindowsForm_prototype
{
    public class TextConnection : IDataConnection
    {
        public void CreateHabit(HabitModel h)
        {
            List<HabitModel> habits = GlobalConfig.HabitsFile.FullFilePath().LoadFile().ConvertToHabitModels();

            if (habits.Count > 0)
            {
                h.Id = habits.OrderByDescending(x => x.Id).First().Id + 1;
            }
            else
            {
                h.Id = 1;
            }

            h.TimeCreated = DateTime.Now;
            h.DueTime = DateTime.Today.AddDays(h.Interval) + new TimeSpan(0);
            h.Streak = 1;
            h.SetMaxStreak();
            h.HabitCompleted = false;
            h.SetDisplayName();

            habits.Add(h);

            habits.SaveToHabitFile(GlobalConfig.HabitsFile);
        }

        public void RemoveHabit(HabitModel habit)
        {
            List<HabitModel> habits = GlobalConfig.HabitsFile.FullFilePath().LoadFile().ConvertToHabitModels();
            int removeInd = 0;
            for (int i = 0; i < habits.Count; i++)
            {
                if (habits[i].Id == habit.Id)
                {
                    removeInd = i;
                }
            }
            habits.RemoveAt(removeInd);
            habits.WriteHabitsToFile();
        }

        public void UpdateHabit(HabitModel habit)
        {
            List<HabitModel> habits = GlobalConfig.HabitsFile.FullFilePath().LoadFile().ConvertToHabitModels();

            for (int i = 0; i < habits.Count; i++)
            {
                if (habits[i].Id == habit.Id)
                {
                    habits[i] = habit;
                }
            }

            habits.UpdateToHabitFile(GlobalConfig.HabitsFile);
        }
    }
}
