using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> elements = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();

            string[] comand = Console.ReadLine().Split(" ");

            int wonCounter = 0;
            bool flag = true;

            while (comand[0] != "end")
            {
                StringBuilder messages = new StringBuilder();

                int firstNumber = int.Parse(comand[0]);
                int secondNumber = int.Parse(comand[1]);

                wonCounter++;

                if (flag)
                {
                    if (firstNumber >= 0 && firstNumber < elements.Count && secondNumber >= 0 && secondNumber < elements.Count && firstNumber != secondNumber)
                    {

                        if (elements[firstNumber] == elements[secondNumber])
                        {
                            messages.AppendLine($"Congrats! You have found matching elements - {elements[firstNumber]}!");

                            if (firstNumber > secondNumber)
                            {
                                elements.RemoveAt(firstNumber);
                                elements.RemoveAt(secondNumber);
                            }
                            else
                            {
                                elements.RemoveAt(secondNumber);
                                elements.RemoveAt(firstNumber);
                            }
                            if (elements.Count == 0)
                            {
                                messages.AppendLine($"You have won in {wonCounter} turns!");
                                flag = false;

                            }
                        }

                        else
                        {
                            messages.AppendLine("Try again!");
                        }

                    }
                    else
                    {
                        elements.Insert(elements.Count / 2, $"-{wonCounter}a");
                        elements.Insert(elements.Count / 2, $"-{wonCounter}a");
                        messages.AppendLine("Invalid input! Adding additional elements to the board");
                    }
                }

                Console.Write(messages);
                comand = Console.ReadLine().Split(" ");
               
            }

            if (flag)
            {
                Console.WriteLine($"Sorry you lose :( ");
                Console.WriteLine(string.Join(" ", elements));
            }

        }
    }
}
