using System;

namespace GC_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            double width, length, height, area, perimiter, volume;

            Console.WriteLine("Welcome to the Room Detail Generator!");

            do
            {
                Console.Write("\nEnter the Length: ");
                userInput = Console.ReadLine();
                while (!double.TryParse(userInput, out length))
                {
                    Console.Write($"\n{userInput} is invalid, please try again: ");
                    userInput = Console.ReadLine();
                }

                Console.Write("Enter the Width: ");
                userInput = Console.ReadLine();
                while (!double.TryParse(userInput, out width))
                {
                    Console.Write($"\n{userInput} is invalid, please try again: ");
                    userInput = Console.ReadLine();
                }

                area = calcArea(width, length);
                Console.WriteLine($"Area: {area}");

                perimiter = calcPerimiter(width, length);
                Console.WriteLine($"Perimiter: {perimiter}");

                Console.Write("\nWould you like to calculate the volume of the room as well? (y/n): ");
                userInput = Console.ReadLine();
                while (userInput.ToLower() != "y" && userInput.ToLower() != "n")
                {
                    Console.Write("\nInput invalid, please enter y or n: ");
                    userInput = Console.ReadLine();
                }
                if (userInput.ToLower() == "y")
                {
                    Console.Write("\nEnter the Height: ");
                    userInput = Console.ReadLine();
                    while (!double.TryParse(userInput, out height))
                    {
                        Console.Write($"\n{userInput} is invalid, please try again: ");
                        userInput = Console.ReadLine();
                    }

                    volume = calcVolume(width, length, height);
                    Console.WriteLine($"Volume: {volume}");


                    Console.Write("\nContinue? (y/n): ");
                    userInput = Console.ReadLine();
                    while (userInput.ToLower() != "y" && userInput.ToLower() != "n")
                    {
                        Console.Write("\nInput invalid, please enter y or n: ");
                        userInput = Console.ReadLine();
                    }
                }
            } while (userInput.ToLower() == "y");

            Console.WriteLine("\nThank you for using the Rom Detail Generator!");
        }


        static double calcArea(double width, double length)
        {
            double area = width * length;
            return area;
        }

        static double calcPerimiter(double width, double length)
        {
            double perimiter = (2 * width) + (2 * length);
            return perimiter;
        }

        static double calcVolume(double width, double length, double height)
        {
            double volume = width * length * height;
            return volume;
        }
    }
}
