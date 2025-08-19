using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Session
{
    public class GameMenu
    {
        public static void ShowMenu()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Welcome to the Math Game!");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Choose from the following:\n1: Addition\r\n2: Subtraction\r\n3: Multiplication\r\n4: Division\r\n5. Random game \r\n6.Show all games\r\n7: Or you can QUIT ");
            Console.WriteLine("--------------------------");
            Console.Write("Please enter your choice (1-7): ");


        }

        public static int GetUserChoice()
        {
            while (true)
            {
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 7)
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                }
            }
        }
    }
}
