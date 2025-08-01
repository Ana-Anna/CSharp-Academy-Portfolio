using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HabitLoggerApp.Models;

namespace HabitLoggerApp.Helpers
{
    public static class InputFormatterHelper
    {
        public static string BuildHabitList(List<Habit> habits)
        {
            if (habits == null || habits.Count == 0)
                return "No habits available. Please add a habit first.";

            var sb = new StringBuilder();
            sb.AppendLine("Available Habits:");
            foreach (var habit in habits)
            {
                sb.AppendLine($"• ID: {habit.Id} | {habit.Name} ({habit.UnitOfMeasure})");
            }

            return sb.ToString();
        }

        public static string BuildHabitEntryList(List<HabitEntry> entries)
        {
            if (entries == null || entries.Count == 0)
                return "No entries found for this habit.";

            var sb = new StringBuilder();
            sb.AppendLine("Habit Entries:");
            foreach (var entry in entries)
            {
                sb.AppendLine($"• ID: {entry.Id} | {entry.Date:yyyy-MM-dd} — {entry.Quantity}");
            }

            return sb.ToString();
        }
    }
}

