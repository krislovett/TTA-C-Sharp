using System;

namespace ColorGuess
{
    class Program
    {
        static void Main()
        {
            //ask user to guess a color and save to color string. set correctColor to false
            Console.WriteLine("Guess a color.");
            string color = Console.ReadLine();
            bool correctColor = false;

            //check if user's guessed color is green. if not, loop switch again, if so, set correctColor to true and break loop
            do
            {
                switch (color)
                {
                    case "green":
                        Console.WriteLine("Green is correct!");
                        correctColor = true;
                        break;
                    case "blue":
                        Console.WriteLine("Blue is incorrect.");
                        Console.WriteLine("Guess a color");
                        color = Console.ReadLine();
                        break;
                    case "red":
                        Console.WriteLine("Red is incorrect.");
                        Console.WriteLine("Guess a color");
                        color = Console.ReadLine();
                        break;
                    case "yellow":
                        Console.WriteLine("Yellow is incorrect.");
                        Console.WriteLine("Guess a color");
                        color = Console.ReadLine();
                        break;
                    case "orange":
                        Console.WriteLine("Orange is incorrect.");
                        Console.WriteLine("Guess a color");
                        color = Console.ReadLine();
                        break;
                    case "purple":
                        Console.WriteLine("Purple is incorrect.");
                        Console.WriteLine("Guess a color");
                        color = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Try again.");
                        Console.WriteLine("Guess a color");
                        color = Console.ReadLine();
                        break;
                }
            }
            while (!correctColor);

            Console.Read();
        }
    }
}
