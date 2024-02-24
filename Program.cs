using System;

namespace urban_fortnight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string today = "    monday     ";

            Console.WriteLine($"Today is {today}, with white space");

            string noWhiteSpace = today.Trim();

            Console.WriteLine($"Today is {noWhiteSpace}, without white space");

            string changeDay = today.Replace("monday", "tuesday");

            Console.WriteLine($"Today is {changeDay}");

        }
    }
}
