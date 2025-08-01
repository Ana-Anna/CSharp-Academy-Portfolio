using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HabitLoggerApp.Models;

namespace HabitLoggerApp.Utils
{
    public static class InputHelper
    {
        public static string GetNonEmptyInput(string prompt, Func<string?> readInput, Action<string> writeOutput)
        {
            string? input;
            do
            {
                writeOutput($"{prompt}: ");
                input = readInput();

                if (string.IsNullOrWhiteSpace(input))
                {
                    writeOutput($"{prompt} cannot be empty. Please try again.");
                }

            } while (string.IsNullOrWhiteSpace(input));

            return input.Trim();
        }

        public static string GetNonEmptyInput(string prompt)
        {
            return GetNonEmptyInput(prompt, Console.ReadLine, Console.WriteLine);
        }

        public static int GetIntInput(string prompt, Func<string?> readInput, Action<string> writeOutput)
        {
            while (true)
            {
                writeOutput($"{prompt}: ");
                string? input = readInput();

                if (int.TryParse(input, out int value) && value > 0)
                    return value;

                writeOutput("Invalid number. Please enter a valid positive integer.");
            }
        }

        public static DateTime GetDateInput(string prompt, Func<string?> readInput, Action<string> writeOutput)
        {
            while (true)
            {
                writeOutput($"{prompt} (yyyy-MM-dd) or press Enter for today:");
                string? input = readInput();

                if (string.IsNullOrWhiteSpace(input))
                    return DateTime.Today;

                if (DateTime.TryParse(input, out DateTime date))
                    return date;

                writeOutput("Invalid date format. Please try again.");
            }
        }
        public static string GetNameInput(string prompt, Func<string?> readInput, Action<string> writeOutput)
        {
            return GetNonEmptyInput(prompt, readInput, writeOutput);
        }
    }
}
