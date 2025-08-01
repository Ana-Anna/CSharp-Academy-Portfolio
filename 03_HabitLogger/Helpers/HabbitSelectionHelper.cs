using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HabitLoggerApp.Models;

namespace HabitLoggerApp.Helpers
{
    public static class HabitSelectionHelper
    {

        public static bool IsValidHabitId(int selectedId, List<Habit> habits)
        {
            return habits.Any(h => h.Id == selectedId);
        }
    }
}
