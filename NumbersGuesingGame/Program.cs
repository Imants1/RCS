using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersGuesingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lūdzu ievadi maksimālo skaitli: ");
            int maxNumber = int.Parse(Console.ReadLine());

            Random randomNumberMaker = new Random();// ierakstam mainīgajā jaunizveidotu ģeneratoru
            int guesableNumber = randomNumberMaker.Next(1, maxNumber + 1);//Next - atgriež gadījuma skaitli noteiktajās robežās

            Console.WriteLine("Skaitlis: " + guesableNumber);



            while (true)
            {
                Console.WriteLine("Ievadiet minējumu: ");
                int minējums = int.Parse(Console.ReadLine());
                if (minējums > guesableNumber)
                {
                    Console.WriteLine("Minējums pārāk liels");

                }
                else if (minējums < guesableNumber)
                {
                    Console.WriteLine("Minējums pārāk mazs");

                }

                else if (minējums == guesableNumber)
                {
                    Console.WriteLine("Pareizi");
                    break;
                }

            }

            Console.ReadLine();

        }
    }
}//paprasīt lietotājam, cik lielu skaitli viņš grib minēt
 //uzģenerēt gadījuma skaitli līdz šai robežai
 //cikls: kamēr lietotājs neuzmin:
 //paprasīt lietotājam lai viņš min kāds skaitlis ir izveidots (iegūt ievadi)
 //salīdzināt, vai lietotājs ir uzminējis
 //ja ir, tad izbeigt spēli
 //ja nav uzminējis, tad pateikt lietotājam
 //vai viņa minējums ir lielāks vai mazāks par minamo skaitli
