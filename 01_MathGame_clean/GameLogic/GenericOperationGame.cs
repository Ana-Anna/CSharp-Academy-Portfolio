using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathGame.Models;

namespace MathGame.GameLogic
{
    public class GenericOperationGame(string operationSymbol, Func<int, int, int> operation) : GameOperation
    {
        private readonly Func<int, int, int> Operation = operation;
        private readonly string OperationSymbol = operationSymbol;
        private readonly Random _random = new();

        public override Question GenerateQuestion(DifficultyLevel difficulty)
        {
            int firstNumber = _random.Next(difficulty.MinValue, difficulty.MaxValue + 1);
            int lastNumber = _random.Next(difficulty.MinValue, difficulty.MaxValue + 1);

            var questionText = $"{firstNumber} {OperationSymbol} {lastNumber} = ?";
            var correctAnswer = Operation(firstNumber, lastNumber);
            return new Question
            {
                FirstNumber = firstNumber,
                LastNumber = lastNumber,
                Result = correctAnswer,
                QuestionText = questionText,
                Difficulty = difficulty,
            };
        }
    }
}
