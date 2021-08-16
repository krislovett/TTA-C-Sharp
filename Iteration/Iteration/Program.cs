using System;
using System.Collections.Generic;
using System.Linq;

namespace Iteration
{
    class Program
    {
        static void Main()
        {
            //append user's input to each item in array
            string[] stringArray = { "car", "truck", "van", "motorcycle", };

            Console.WriteLine("Enter text:");
            string addText = Console.ReadLine();

            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i] + addText;
                Console.WriteLine(stringArray[i]);
            }
            Console.WriteLine();

            //print each number in array
            int[] intArray = { 0, 1, 2, 3, 4, 5 };
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(intArray[i]);
            }
            Console.WriteLine();

            //create list of planets and have user enter a search query
            List<string> planets = new List<string>() { "mercury", "venus", "earth", "mars", "jupiter", "saturn", "uranus", "neptune", "pluto" };
            Console.WriteLine("Search for a planet in this solar system:");
            string search = Console.ReadLine();

            foreach (string planet in planets)
            {
                //if search matches a planet, print index of matching planet
                if (planets.Contains(search))
                {
                    Console.WriteLine("This planet's index is: " + planets.IndexOf(search));
                    break;
                }

                //if search isn't in list, print error
                else
                {
                    Console.WriteLine(search + " is not a planet in our solar system.");
                    break;
                }
            }
            Console.WriteLine();

            //create list of pets and have user enter a search query
            List<string> pets = new List<string>() { "dog", "cat", "fish", "hamster", "lizard", "dog" };
            Console.WriteLine("Search for a common pet:");
            search = Console.ReadLine();
            bool searchFound = pets.Contains(search);
            Console.WriteLine();

            for (int i = 0; i < pets.Count(); i++ )
            {
                //if search isn't found, break loop
                if (!searchFound)
                {
                    Console.WriteLine(search + " is not on this list.");
                    break;
                }
                //if search matches a pet, print index of matching pet
                if (search == pets[i])
                {
                    Console.WriteLine(pets[i] + " index: " + i);
                }
                else if (search != pets[i])
                {
                    Console.WriteLine(pets[i]);
                }
            }
            Console.WriteLine();

            List<string> colors = new List<string>() { "red", "orange", "yellow", "green", "red", "blue", "purple" };
            List<string> colorsCopy = new List<string>();

            //use colorsCopy list to hold a copies of previous colors from main list to compare if current color has been on the list already
            Console.WriteLine("Colors:");
            foreach (string color in colors)
            {
                foreach (string colorCopy in colorsCopy)
                {
                    if (colorCopy == color)
                    {
                        Console.WriteLine("\"" + color + "\"" + " occurs more than once.");
                    }
                }
                colorsCopy.Add(color);
            }

            Console.Read();
        }
    }
}
