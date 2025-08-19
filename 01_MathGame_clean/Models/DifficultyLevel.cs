using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Models
{
    public class DifficultyLevel
    {
        public required string Name { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public int PointPerCorrectAnswer { get; set; }
        public TimeSpan TimeLimitPerQuestion { get; set; }


        public static readonly DifficultyLevel Easy = new()
        {
            Name = "Easy",
            MinValue = 1,
            MaxValue = 10,
            PointPerCorrectAnswer = 1,
            TimeLimitPerQuestion = TimeSpan.FromSeconds(20)
        };

        public static readonly DifficultyLevel Medium = new()
        {
            Name = "Medium",
            MinValue = 10,
            MaxValue = 50,
            PointPerCorrectAnswer = 2,
            TimeLimitPerQuestion = TimeSpan.FromSeconds(15)
        };

        public static readonly DifficultyLevel Hard = new()
        {
            Name = "Hard",
            MinValue = 50,
            MaxValue = 100,
            PointPerCorrectAnswer = 3,
            TimeLimitPerQuestion = TimeSpan.FromSeconds(10)
        };

        public static DifficultyLevel ChooseDifficulty()
        {
            while (true)
            {
                Console.WriteLine("\nChoose difficulty level:");
                Console.WriteLine("1: Easy (numbers from 1–10)");
                Console.WriteLine("2: Medium (numbers from 10–50)");
                Console.WriteLine("3: Hard (numbers from 50–100)");
                Console.Write("Enter your choice (1-3): ");

                var input = Console.ReadLine();

                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 1: return DifficultyLevel.Easy;
                        case 2: return DifficultyLevel.Medium;
                        case 3: return DifficultyLevel.Hard;
                    }
                }

                Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
            }
        }
    }
}