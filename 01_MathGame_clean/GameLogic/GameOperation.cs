using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathGame.Models;

namespace MathGame.GameLogic
{
    public abstract class GameOperation
    {
        public abstract Question GenerateQuestion(DifficultyLevel difficulty);
       
    }
}
