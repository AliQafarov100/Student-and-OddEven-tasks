using System;

namespace EvenAndOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Number is even?: " + isEven(num));
            Console.WriteLine("Number is odd?: " + isOdd(num));
        }
        static bool isEven(int numb)
        {
            bool check = false;
            if (numb % 2 == 0)
            {
                check = true;
            }

            return check;
        }
        static bool isOdd(int number)
        {
            bool TrueOrFalse = false;

            if (number % 2 != 0)
            {
                TrueOrFalse = true;
            }

            return TrueOrFalse;
        }
    }
}
