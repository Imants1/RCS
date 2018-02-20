using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersGuesingGameTurns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lūdzu ievadi maksimālo skaitli: ");
            int maxNumber = int.Parse(Console.ReadLine());

            Random randomNumberMaker = new Random();// ierakstam mainīgajā jaunizveidotu ģeneratoru
            int guesableNumber = randomNumberMaker.Next(1, maxNumber + 1);//Next - atgriež gadījuma skaitli noteiktajās robežās

            Console.WriteLine("Tev ir pieci minējumi.");

            bool hasUserWon = false;
            for (int tryCount = 1; tryCount <= 5 && !hasUserWon; tryCount = tryCount + 1)
            {
                                
                Console.WriteLine("Lūdzu ievadi minējumu #" + tryCount);
                int minējums = int.Parse(Console.ReadLine());
                if (minējums == guesableNumber || minējums == 12345)// || - nosaka alternatīvu, kad cikls beidzas
                {
                    Console.WriteLine("Pareizi");
                    hasUserWon = true;
                }
                else if (minējums > maxNumber|| minējums < 1)
                {
                    Console.WriteLine("Minējums ārpus noteiktajām robežām");
                }
                else if (minējums > guesableNumber)
                {
                    Console.WriteLine("Minējums pārāk liels");
                }
                else if (minējums < guesableNumber)
                {
                    Console.WriteLine("Minējums pārāk mazs");
                }


            }
            if (hasUserWon == false)// var rakstīt arī !hasUserwon
            {
                Console.WriteLine("Sorry! Pareizā atbilde " + guesableNumber);
            }
            Console.ReadLine();
        }
    }
}
