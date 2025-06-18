using System.ComponentModel.Design;
using MathGame.GameLogic;
using MathGame.Models;
using MathGame.Session;

int userChoice;
int choiceCount = 7;
var sessionHistory = new List<GameSession>();

do
{
    GameMenu.ShowMenu();

    userChoice = GameMenu.GetUserChoice();
    GameOperation? selectedOperation = null;

    // Display the menu options
    switch (userChoice)
    {
        case 1:
            Console.WriteLine("You chose Addition!");
            selectedOperation = new GenericOperationGame("+", (a, b) => a + b);
            break;
        case 2:
            Console.WriteLine("You chose Subtraction!");
            selectedOperation = new GenericOperationGame("-", (a, b) => a>=b? a - b : b-a);
            break;
        case 3:
            Console.WriteLine("You chose Multiplication!");
           selectedOperation = new GenericOperationGame("*", (a, b) => a * b);
            break;
        case 4:
            Console.WriteLine("You chose Division!");
            selectedOperation= new GenericOperationGame("/", (Func<int, int, int>)((a, b) =>
            {
                return Helpers.SafeDivision(a, ref b);
            }));
            break;
        case 5:
            Console.WriteLine("You chose Random Game!");
            selectedOperation = new RandomGameOperation();
            break;
        case 6:
            Console.WriteLine("Game history.");
            Helpers.ViewGameHistory(sessionHistory);
            break;
        case 7:
            Console.WriteLine("Thank you for playing! Goodbye!");
            break;
    }

    if (selectedOperation != null)
    {
        var gameSession = new GameSession
        {
            GameOperation = selectedOperation,
            DifficultyLevel = DifficultyLevel.ChooseDifficulty(),
            NumberOfQuestions = 5
        };

        gameSession.Play();
        sessionHistory.Add(gameSession);

        Console.WriteLine($"\nGame Over! You scored {gameSession.Score} points.");
        Console.WriteLine($"Correct answers: {gameSession.Questions.Count(q => q.IsCorrect)}");
        Console.WriteLine($"Total time: {gameSession.TotalTimeTaken.TotalSeconds:F1} seconds\n");

        Console.WriteLine($"\nGame Over! You scored {gameSession.Score} points.");
        Console.WriteLine($"Correct answers: {gameSession.Questions.Count(q => q.IsCorrect)}");
        Console.WriteLine($"Total time: {gameSession.TotalTimeTaken.TotalSeconds:F1} seconds\n");

    }
}

while (userChoice != choiceCount);
