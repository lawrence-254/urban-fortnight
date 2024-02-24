using System;

namespace urban_fortnight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string today = "    monday     ";

            Console.WriteLine($"Today is {today}");

            string noWhiteSpace = today.Trim();

            Console.WriteLine($"Today is {noWhiteSpace}");

            string changeDay = today.Replace("monday", "tuesday");

            Console.WriteLine($"Today is {changeDay}");

        }
    }
}
