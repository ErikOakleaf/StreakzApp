using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreakzApp_WindowsForm_prototype
{
    public interface IDataConnection
    {
        public void CreateHabit(HabitModel habit);
        public void UpdateHabit(HabitModel habit);
        public void RemoveHabit(HabitModel habit);
    }
}
