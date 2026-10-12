using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RefactoringExercise
{
    internal class Program
    {
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

            void WriteResult(int limit, int secondLimit = 0, string text = " # ", string topText = "", bool secondFor = false)
            {
                Console.WriteLine(topText);
                for (int i = 0; i < secondLimit; i++)
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
                        WriteResult(6);
                        break;

                    case 2:
                        Console.Write("How many hashtags (max 10)? ");
                        times = int.Parse(Console.ReadLine());
                        WriteResult(times);
                        break;

                    case 3:
                        WriteResult(5, 5, "##", secondFor: true);
                        break;

                    case 4:
                        Console.Write("How many hashtags (max 10)? ");
                        times = int.Parse(Console.ReadLine());
                        WriteResult(times, times, "##", secondFor: true);
                        break;

                    case 5:
                        WriteResult(17);
                        WriteResult(17, topText: "\n# Static Border #");
                        break;

                    case 6:
                        Console.WriteLine("Write a text of max 20 characters long:");
                        string innerText = Console.ReadLine();
                        WriteResult(innerText.Length + 4, text: "#");
                        WriteResult(innerText.Length + 4, text: "#", topText: "\n# " + innerText + " #");
                        break;
                }

                Console.WriteLine("\n \n Press any key to continue...");
                Console.ReadKey();

            }
        }
    }
}
