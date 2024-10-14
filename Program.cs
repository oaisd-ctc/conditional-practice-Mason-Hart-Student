using System;
using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        FahrenheitToCelsius(68); // Test FahrenheitToCelsius Function with a random value
        // Test your functions by calling them below:
        CheckForPositiveNegativeZero(-1); // This should output: "Your number is negative"
        CheckForPositiveNegativeZero(0); // This should output: "Your number is zero"
        CheckForPositiveNegativeZero(1); // This should output: "Your number is positive"
        FindMinimum(4, 10, 2);
        FindMaximum(4, 10, 2);
        IsDivisibleBy5(4);
        IsDivisibleBy5(40);
        CheckEvenOrOdd(4);
        CheckEvenOrOdd(5);
        CheckVowelOrConsonant('A');
        CheckVowelOrConsonant('y');
        DisplayDayOfWeek(0); // This should output: "Sunday"
        DisplayDayOfWeek(3); // This should output: "Wednesday"

    }
    // Define your functions below:
    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }

    public static void CheckForPositiveNegativeZero(int number)
    {
        if (number < 0)
        {
            Console.WriteLine("Your number is negative");
        }
        if (number == 0)
        {
            Console.WriteLine("Your number is zero");
        }
        if (number > 0)
        {
            Console.WriteLine("Your number is positive");
        }
    }

    public static void FindMinimum(int num1, int num2, int num3)
    {
        Console.WriteLine("The minimum value is " + Math.Min(num1, Math.Min(num2, num3)));
    }

    public static void FindMaximum(int num1, int num2, int num3)
    {
        Console.WriteLine("The maximum value is " + Math.Max(num1, Math.Max(num2, num3)));
    }

    public static void IsDivisibleBy5(int number)
    {
        int ans = number % 5;
        if (ans == 0)
        {
            Console.WriteLine(number + " is divisible by 5");
        }
        else
        {
            Console.WriteLine(number + " is not divisible by 5");
        }
    }

    public static void CheckEvenOrOdd(int number)
    {
        int div = number % 2;
        if (div == 0)
        {
            Console.WriteLine(number + " is an even number");
        }
        else
        {
            Console.WriteLine(number + " is an odd number");
        }
    }

    public static void CheckVowelOrConsonant(char letter)
    {

        if (letter == 'a')
        {
            Console.WriteLine(letter + " is a vowel");
        }
        else
        {
            if (letter == 'e')
            {
                Console.WriteLine(letter + " is a vowel");
            }
            else
            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter + " is a vowel");
                }
                else
                {
                    if (letter == 'o')
                    {
                        Console.WriteLine(letter + " is a vowel");
                    }
                    else
                    {
                        if (letter == 'u')
                        {
                            Console.WriteLine(letter + " is a vowel");
                        }
                        else
                        {
                            Console.WriteLine(letter + " is a consonant");
                        }
                    }
                }
            }
        }

    }

    public static void DisplayDayOfWeek(int dayCode)
    {
        if (dayCode == 0)
        {
            Console.WriteLine("Sunday");
        }
        if (dayCode == 1)
        {
            Console.WriteLine("Monday");
        }
        if (dayCode == 2)
        {
            Console.WriteLine("Tuesday");
        }
        if (dayCode == 3)
        {
            Console.WriteLine("Wednesday");
        }
        if (dayCode == 4)
        {
            Console.WriteLine("Thursday");
        }
        if (dayCode == 5)
        {
            Console.WriteLine("Friday");
        }
        if (dayCode == 6)
        {
            Console.WriteLine("Saturday");
        }
    }
}
