using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuzzFizz
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lūdzu ievadi maksimālo skaitli: ");
            ulong maxSkaitlis = ulong.Parse(Console.ReadLine());

            for (ulong skaitlis = 1; skaitlis <= maxSkaitlis; skaitlis = skaitlis + 1)
            {
                ulong modulis1 = skaitlis % 3;
                ulong modulis2 = skaitlis % 5;
                if (modulis1 == 0 && modulis2 == 0)// ja skaitļi dalās - modulis ir 0
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (modulis1 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (modulis2 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(skaitlis);
                }
            }
            Console.ReadLine();
        }

    }

}
