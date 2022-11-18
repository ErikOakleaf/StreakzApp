using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreakzApp_WindowsForm_prototype
{
    public static class GlobalConfig
    {

        public const string HabitsFile = "HabitModels.csv";

        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                // TODO - Set up the sql connector properly
                SQLConnection sql = new SQLConnection();
                Connection = sql;
            }
            else if (db == DatabaseType.TextFile)
            {
                TextConnection text = new TextConnection();
                Connection = text;
            }
        }
    }
}