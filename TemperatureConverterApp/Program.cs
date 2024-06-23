using System;

namespace TemperatureConverterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueApp = true;

            while (continueApp)
            {
                Console.Clear();
                Console.WriteLine("Temperature Converter");
                Console.WriteLine("=====================");
                Console.WriteLine("1. Convert Celsius to Fahrenheit");
                Console.WriteLine("2. Convert Fahrenheit to Celsius");
                Console.WriteLine("3. Convert Celsius to Kelvin");
                Console.WriteLine("4. Convert Kelvin to Celsius");
                Console.WriteLine("5. Convert Fahrenheit to Kelvin");
                Console.WriteLine("6. Convert Kelvin to Fahrenheit");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ConvertCelsiusToFahrenheit();
                        break;
                    case "2":
                        ConvertFahrenheitToCelsius();
                        break;
                    case "3":
                        ConvertCelsiusToKelvin();
                        break;
                    case "4":
                        ConvertKelvinToCelsius();
                        break;
                    case "5":
                        ConvertFahrenheitToKelvin();
                        break;
                    case "6":
                        ConvertKelvinToFahrenheit();
                        break;
                    case "7":
                        continueApp = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        // Method to convert Celsius to Fahrenheit
        static void ConvertCelsiusToFahrenheit()
        {
            Console.Clear();
            Console.WriteLine("Convert Celsius to Fahrenheit");
            Console.WriteLine("=============================");
            Console.Write("Enter temperature in Celsius: ");

            if (double.TryParse(Console.ReadLine(), out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit} °F");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }

        // Method to convert Fahrenheit to Celsius
        static void ConvertFahrenheitToCelsius()
        {
            Console.Clear();
            Console.WriteLine("Convert Fahrenheit to Celsius");
            Console.WriteLine("=============================");
            Console.Write("Enter temperature in Fahrenheit: ");

            if (double.TryParse(Console.ReadLine(), out double fahrenheit))
            {
                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"Temperature in Celsius: {celsius} °C");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }

        // Method to convert Celsius to Kelvin
        static void ConvertCelsiusToKelvin()
        {
            Console.Clear();
            Console.WriteLine("Convert Celsius to Kelvin");
            Console.WriteLine("=========================");
            Console.Write("Enter temperature in Celsius: ");

            if (double.TryParse(Console.ReadLine(), out double celsius))
            {
                double kelvin = celsius + 273.15;
                Console.WriteLine($"Temperature in Kelvin: {kelvin} K");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }

        // Method to convert Kelvin to Celsius
        static void ConvertKelvinToCelsius()
        {
            Console.Clear();
            Console.WriteLine("Convert Kelvin to Celsius");
            Console.WriteLine("=========================");
            Console.Write("Enter temperature in Kelvin: ");

            if (double.TryParse(Console.ReadLine(), out double kelvin))
            {
                double celsius = kelvin - 273.15;
                Console.WriteLine($"Temperature in Celsius: {celsius} °C");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }

        // Method to convert Fahrenheit to Kelvin
        static void ConvertFahrenheitToKelvin()
        {
            Console.Clear();
            Console.WriteLine("Convert Fahrenheit to Kelvin");
            Console.WriteLine("============================");
            Console.Write("Enter temperature in Fahrenheit: ");

            if (double.TryParse(Console.ReadLine(), out double fahrenheit))
            {
                double kelvin = (fahrenheit + 459.67) * 5 / 9;
                Console.WriteLine($"Temperature in Kelvin: {kelvin} K");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }

        // Method to convert Kelvin to Fahrenheit
        static void ConvertKelvinToFahrenheit()
        {
            Console.Clear();
            Console.WriteLine("Convert Kelvin to Fahrenheit");
            Console.WriteLine("============================");
            Console.Write("Enter temperature in Kelvin: ");

            if (double.TryParse(Console.ReadLine(), out double kelvin))
            {
                double fahrenheit = kelvin * 9 / 5 - 459.67;
                Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit} °F");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }
    }
}
