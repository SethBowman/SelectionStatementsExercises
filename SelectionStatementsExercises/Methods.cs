using System;

namespace SelectionStatementsExercises
{
    public class Methods
    {
        //Exercise 1
        public static void GuessingGame()
        {
            var r = new Random();
            var favNumber = r.Next(1, 10);
            Console.WriteLine("Guess a number between 1 and 10");
            var response = int.Parse(Console.ReadLine());

            if (response < favNumber)
            {
                Console.WriteLine($"Too low\nYour Guess: {response}");
            }
            else if (response > favNumber)
            {
                Console.WriteLine($"Too high\nYour Guess: {response}");
            }
            else
            {
                Console.WriteLine($"You guessed correctly!\nThe number was {response}");
            }

            //var response = 0;
            //while (response != favNumber)
            //{
            //    var canParse = false;
            //    Console.WriteLine("Guess a number between 1 and 10");
            //    canParse = int.TryParse(Console.ReadLine(), out response);
            //    while (canParse == false)
            //    {
            //        Console.WriteLine("That was not a correct choice, try again.");
            //        Console.WriteLine("Guess a number between 1 and 10");
            //        canParse = int.TryParse(Console.ReadLine(), out response);
            //        Console.Clear();
            //    }

                //    Console.WriteLine((response < favNumber) ? $"Too low\nYour Guess: {response}" :
                //        (response > favNumber) ? $"Too high\nYour Guess: {response}" :
                //        $"You guessed correctly!\nThe number was {response}");


                //    Thread.Sleep(3000);
                //    Console.Clear();

                //}

        }
        public static void FavoriteSubject()
        {
            Console.WriteLine("What is your favorite subject?");
            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I hate Math");
                    break;
                case "science":
                    Console.WriteLine("I love Science");
                    break;
                case "pe":
                    Console.WriteLine("PE is awesome");
                    break;
                case "history":
                    Console.WriteLine("History is my favorite");
                    break;
                default:
                    Console.WriteLine("Oh.. nice.");
                    break;
            }
        }
    }
}
