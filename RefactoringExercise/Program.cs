using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RefactoringExercise
{
    internal class Program
    {
        /// <summary>
        /// Determines the maximum amount of hashtags
        /// </summary>
        /// <param name="userInput">Amount the user wants</param>
        /// <param name="userChoice">The choice the user made</param>
        /// <returns>Whether the hashtag amount is not within bounds</returns>
        static bool MaxHashTag(int userInput, int userChoice)
        {
            if ((userChoice == 2 && userInput > 10) || (userChoice == 2 && userInput < 0))
            {
                return true;
            }
            if ((userChoice == 4 && userInput > 10) || (userChoice == 4 && userInput < 0))
            {
                return true;
            }
            return false;
        }

        static bool NumberInput(int userInput, int userChoice)
        {
            if (userChoice == 2 && (userInput == 1 || userInput == 2 || userInput == 3 || userInput == 4 || userInput == 5 || userInput == 6))
            {
                return false;
            }
            if (userChoice == 4 && (userInput == 1 || userInput == 2 || userInput == 3 || userInput == 4 || userInput == 5 || userInput == 6))
            {
                return false;
            }
            return true;
        }
        
        static void Main(string[] args)
        {

            //REFAKTORISERA KODEN
            //Fixa koden så den blir bättre att läsa och underhålla.
            //Lägg fokus på:
            //1- Undvik Repeterad kod. Ersätt den för metoder
            //2- Lägg kommentarer. Du kan väl gyssa vad koden gör och lägga den som kommentärer
            //3- Validera input. dvs, parsa och kolla att det är i rätt typ
            //4- Hantera errors. Informera om fel och/eller skapa kod som inte crashar.
            //5- Ge feedback till användaren. Om den skriver fel ska den få veta varför.


            void WriteResult(int limit, int userChoice, int times = 0, int secondLimit = 0, string text = " # ", string topText = "", bool secondFor = false)
            {
                if (NumberInput(times, userChoice) && MaxHashTag(times, userChoice))
                {
                    Console.WriteLine("Number out of bounds");
                }
                else
                {
                    Console.WriteLine(topText);
                    for (int i = 0; i <= secondLimit; i++)
                    {
                        for (int j = 0; j < limit; j++)
                        {
                            Console.Write(text);
                        }
                        if (secondFor)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }

            int answer;
            int times;

            bool stop = false;
            while (!stop)
            {
                Console.Clear();
                Console.WriteLine("What do you want to do?\n 1. A line\n 2. My Line\n 3. A Square\n 4. My Square\n 5. A border\n 6. My border\n 0. Exit");
                answer = int.Parse(Console.ReadLine());

                switch (answer)
                {
                    case 1:
                        WriteResult(6, 1);
                        break;

                    case 2:
                        Console.Write("How many hashtags (max 10)? ");
                        times = int.Parse(Console.ReadLine());
                        WriteResult(times, 2, times);
                        break;

                    case 3:
                        WriteResult(5, 5, 3, text: "##", secondFor: true);
                        break;

                    case 4:
                        Console.Write("How many hashtags (max 10)? ");
                        times = int.Parse(Console.ReadLine());
                        WriteResult(times, times, 4, text: "##", secondFor: true);
                        break;

                    case 5:
                        WriteResult(17, 5);
                        WriteResult(17, 5, topText: "\n# Static Border #");
                        break;

                    case 6:
                        Console.WriteLine("Write a text of max 20 characters long:");
                        string innerText = Console.ReadLine();
                        WriteResult(innerText.Length + 4, 6, text: "#");
                        WriteResult(innerText.Length + 4, 6, text: "#", topText: "\n# " + innerText + " #");
                        break;

                    case 0:
                        stop = true;
                        break;
                }

                Console.WriteLine("\n \n Press any key to continue...");
                Console.ReadKey();

            }
        }
    }
}