using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathGame.Models;
using MathGame.Session;

namespace MathGame.GameLogic
{   
    public class RandomGameOperation : GameOperation
    {
        private readonly List<GenericOperationGame>? _operations;
        private readonly Random _random = new();

        public RandomGameOperation()
        {
            _operations = new List<GenericOperationGame>
            {
                new ("+",(a, b)=> a + b),
                new ("-", (a, b) => a>=b? a - b : b-a),
                new ("*", (a, b) => a * b),
                new ("/", (Func<int, int, int>)((a, b) =>
                {
                    return Helpers.SafeDivision(a, ref b);
                }))
            } ?? throw new InvalidOperationException("Failed to initialize operations list.");
        }
        public override Question GenerateQuestion(DifficultyLevel difficulty)
        {
            if (_operations == null || _operations.Count == 0)
            {
                throw new InvalidOperationException("Operations list is not initialized or empty.");
            }

            int index = _random.Next(_operations.Count);
            return _operations[index].GenerateQuestion(difficulty);
        }
    }
    
    }

