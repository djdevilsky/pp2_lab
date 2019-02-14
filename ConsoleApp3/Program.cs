using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {

        static bool isPrime(int n) //узнать это prime или нет
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i <=Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;

        }
        static void Main(string[] args)
        {
            int x;
            x = Int32.Parse(Console.ReadLine());
            int y;
            ArrayList PrimeNumbers = new ArrayList();
            for(int i = 0; i < x; i++)
            {
                y = Int32.Parse(Console.ReadLine());
                if (isPrime(y))
                {
                    PrimeNumbers.Add(y);
                }

            }

            Console.WriteLine(PrimeNumbers.Count);
            for(int i = 0; i < PrimeNumbers.Count; i++)
            {
                Console.Write(PrimeNumbers[i] + " ");
            }

        }
    }
}
