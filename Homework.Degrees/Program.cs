using System;

namespace Homework.Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            string userChoice;
            double userAnswer;
            

            Console.WriteLine("Choose Celsius or Fahrenheit C/F: "); // user chooses C or F
            userChoice = Console.ReadLine();

            if (userChoice.ToUpper() == "F") //user chooses F, then converts to C
            {
                Console.WriteLine("Write a degree in Fahrenheit: ");
                userAnswer = Double.Parse(Console.ReadLine());
                GetFahrenheitToCelsius( userAnswer); //kutsub funktsiooni
            }

            else if (userChoice.ToUpper() == "C") //user chooses C, then converts to F
            {
                Console.WriteLine("Write a degree in Celsius: ");
                userAnswer = Double.Parse(Console.ReadLine());
                GetCelsiusToFahrenheit( userAnswer);//kutsub funktsiooni
            }
            else
            {
                Console.WriteLine("Choose F (fahrenheit) or C (celsius)");

            }
            goto Start;

        }

       public static void GetFahrenheitToCelsius ( double userAnswer) //convert to Celsius
        {
            double celsius = (userAnswer - 32) * 5 / 9;
            double celsius2 = Math.Round(celsius, 2); //ümardab 
            
            Console.WriteLine($"{userAnswer} is converted to celsius: {celsius2} C.");
        }

        public static void GetCelsiusToFahrenheit ( double userAnswer) //convert to Fahrenheit
        {
            double fahrenheit = (userAnswer * 9 / 5) + 32;
            double fahrenheit2 = Math.Round(fahrenheit, 2); // ümardab
            Console.WriteLine($"{userAnswer} is converted to fahrenheit: {fahrenheit} F.");
        }
        
    }
}
