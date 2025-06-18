using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathGame.GameLogic;
using MathGame.Models;

namespace MathGame.Session
{
    public class GameSession
    {
        public required GameOperation GameOperation;
        public required DifficultyLevel DifficultyLevel;
        public List<Question> Questions { get; set; } = [];
        public int Score { get; set; }
        public int NumberOfQuestions { get; set; }
        public TimeSpan TotalTimeTaken { get; set; }
        public void Play()
        {
            var totalTimer = Stopwatch.StartNew();
            Score = 0;
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                var questionTimer = Stopwatch.StartNew();
                var question = GameOperation.GenerateQuestion(DifficultyLevel);

                Console.WriteLine(question.QuestionText);
                question.UserAnswer = GetUserAnswer();
                if (question.IsCorrect)
                {
                    Score += DifficultyLevel.PointPerCorrectAnswer;
                }

                Questions.Add(question);
                questionTimer.Stop();
                question.TimeTaken = questionTimer.Elapsed;
                TotalTimeTaken += question.TimeTaken;
            }

            totalTimer.Stop();
        }

        public int GetUserAnswer()
        {
            while (true)
            {
                Console.WriteLine("Please enter your answer:");
                var input = Console.ReadLine();
                if (int.TryParse(input, out int answer))
                {
                    return answer;
                }
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        }
    }
}
