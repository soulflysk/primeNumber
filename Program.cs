using System;

namespace primeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Accept number:");
            number = Convert.ToInt32(Console.ReadLine());
            if (IsPrime(number))
            {

                Console.WriteLine("It is prime");
                var boundary = (int)Math.Floor(Math.Sqrt(number));
                for (int j = number - 1; j < number || number != 0; j -= 1)
                {
                    if (IsPrime(j))
                    {
                        int PrevPrime = j;
                        Console.WriteLine("Previous prime number is {0}", PrevPrime);
                        break;
                    }
                    else if (j == 1)
                    {
                        Console.WriteLine("No previous prime number");
                        break;
                    }
                }
                for (int k = number + 1; k > number || number < 1000; k += 1)
                {
                    if (IsPrime(k))
                    {
                        int NextPrime = k;
                        Console.WriteLine("Next prime number is {0}", NextPrime);
                        break;
                    }

                }
            }
            else
            {
                Console.WriteLine("It is not prime");
            }
        }
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
