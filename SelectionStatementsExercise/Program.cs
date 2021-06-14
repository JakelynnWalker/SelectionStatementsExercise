using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("Try to guess my favorite number!");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput > favNumber)
            {
                Console.WriteLine("Too High");
            }
            else if (userInput < favNumber)
            {
                Console.WriteLine("Too Low");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }


            Console.WriteLine("What is your favorite subject?");
            string userSubject = Console.ReadLine();

            switch (userSubject)
            {
                case "Math":
                    Console.WriteLine("Cool Subject");
                    break;
                case "English":
                    Console.WriteLine("Thats a good one");
                    break;
                case "Science":
                    Console.WriteLine("My Favorite");
                    break;
                case "Reading":
                    Console.WriteLine("I hate reading");
                    break;
                case "Gym Class":
                    Console.WriteLine("Everyone likes this one");
                    break;
                default:
                    Console.WriteLine("Please put a subject");
                    break;
            }
        }
    }
}
