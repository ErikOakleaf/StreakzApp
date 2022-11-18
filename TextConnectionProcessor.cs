using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace StreakzApp_WindowsForm_prototype
{
    public static class TextConnectionProcessor
    {
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            else
            {
                return File.ReadAllLines(file).ToList();
            }
        }

        public static string FullFilePath(this string file)
        {
            return Path.Combine(Environment.CurrentDirectory, @"data\", file);
        }

        public static void SaveToHabitFile(this List<HabitModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (HabitModel h in models)
            {
                int boolInt;
                if (h.HabitCompleted)
                    boolInt = 1;
                else
                    boolInt = 0;

                lines.Add($"{h.Id},{h.Name},{h.Description},{h.Interval},{h.Streak},{h.MaxStreak},{boolInt},{h.TimeCreated.ToString()},{h.DueTime.ToString()}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void UpdateToHabitFile(this List<HabitModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (HabitModel h in models.OrderBy(x => x.Id))
            {
                int boolInt;
                if (h.HabitCompleted)
                    boolInt = 1;
                else
                    boolInt = 0;

                lines.Add($"{h.Id},{h.Name},{h.Description},{h.Interval},{h.Streak},{h.MaxStreak},{boolInt},{h.TimeCreated.ToString()},{h.DueTime.ToString()}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static List<HabitModel> ConvertToHabitModels(this List<string> lines)
        {
            List<HabitModel> habits = new List<HabitModel>();
            foreach (string line in lines)
            {
                HabitModel h = new HabitModel();
                string[] cols = line.Split(',');

                h.Id = int.Parse(cols[0]);
                h.Name = cols[1];
                h.Description = cols[2];
                h.Interval = int.Parse(cols[3]);
                h.Streak = int.Parse(cols[4]);
                h.MaxStreak= int.Parse(cols[5]);
                if (int.Parse(cols[6]) == 0)
                {
                    h.HabitCompleted = false;
                }
                else if (int.Parse(cols[6]) == 1)
                {
                    h.HabitCompleted = true;
                }
                h.TimeCreated = DateTime.Parse(cols[7]);
                h.DueTime = DateTime.Parse(cols[8]);
                h.SetDisplayName();

                habits.Add(h);
            }

            return habits;
        }

        public static void WriteHabitsToFile(this List<HabitModel> models)
        {
            List<string> lines = new List<string>();
            foreach (HabitModel h in models.OrderBy(x => x.Id))
            {
                int boolInt;
                if (h.HabitCompleted)
                    boolInt = 1;
                else
                    boolInt = 0;

                lines.Add($"{h.Id},{h.Name},{h.Description},{h.Interval},{h.Streak},{h.MaxStreak},{boolInt},{h.TimeCreated.ToString()},{h.DueTime.ToString()}");
            }

            File.WriteAllLines(GlobalConfig.HabitsFile.FullFilePath(), lines);
        }

    }
}
