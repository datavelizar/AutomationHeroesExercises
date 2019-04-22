using System;

namespace _10._YourAgeAfter10Years
{
    class YourAgeAfter10Years
    {
        static void Main()
        {
            Console.Write("Please, enter your age: ");
            bool couldBeParsed = double.TryParse(Console.ReadLine(), out double currentAge);

            if (couldBeParsed)
            {
                Console.WriteLine($"In 10 years time your age will be: {currentAge + 10}");
            }
            else
            {
                Console.WriteLine("You should enter a number for the age!");
                Main();
            }
        }
    }
}
