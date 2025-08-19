using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Models
{
    public class Question
    {
        public int FirstNumber;
        public int LastNumber;
        public int Result;
        public required string QuestionText;
        public int? UserAnswer;
        public bool IsCorrect => UserAnswer.HasValue && UserAnswer.Value == Result;
        public TimeSpan TimeTaken { get; set; }
        public required DifficultyLevel Difficulty { get; set; }
    }
}
