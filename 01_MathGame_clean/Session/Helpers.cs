using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Session
{
     public static class Helpers
    {
       public static int SafeDivision(int a, ref int b)
        {
            b = b == 0 ? 1 : b;
            int result = new Random().Next(1, 10);
            return a / b * result;
        }

        public static void ViewGameHistory(List<GameSession> sessionHistory)
        {
            if (sessionHistory.Count == 0)
            {
                Console.WriteLine("You haven't played any games yet.");
            }
            else
            {
                for (int i = 0; i < sessionHistory.Count; i++)
                {
                    var session = sessionHistory[i];
                    var operationName = session.GameOperation.GetType().Name;

                    Console.WriteLine($"\nGame {i + 1}: {operationName}");
                    Console.WriteLine($"- Difficulty: {session.DifficultyLevel.Name}");
                    Console.WriteLine($"- Score: {session.Score}");
                    Console.WriteLine($"- Correct answers: {session.Questions.Count(q => q.IsCorrect)} / {session.NumberOfQuestions}");
                    Console.WriteLine($"- Time taken: {session.TotalTimeTaken.TotalSeconds:F1} seconds");
                }
            }
        }
    }
}
