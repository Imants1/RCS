using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)//Ctrl+KD - sakārto kodu
        {
            CalculateCircleArea();
            CountTwoNumbersTogether();


        }
        static void CalculateCircleArea()
        {
            //izveidojam mainīgo, kur glabāt rādiusu
            double radius;
            //izveidojam mainīgo, kur glabāt rezultātu
            double result;
            //piešķirsim rādiusa mainīgajam vērtību
            radius = GetNumberFromUser("Lūdzu ievadiet rādiusu");
            //veicam aprēķināšanas operāciju
            result = radius * radius * 3.14;
            //parādam rezultātu lietotājam
            Console.WriteLine("Rezultāts: " + result);
            Console.ReadLine();
        }
        static void CountTwoNumbersTogether()
        {
            double firstNumber;//izveidojam mainīgo pirmajam skaitlim
            firstNumber = GetNumberFromUser("Lūdzu ievadiet pirmo skaitli");//izsaucam funkciju skaitļa iegūšanai
            double secondNumber;//izveidojam mainīgo otram skaitlim
            secondNumber = GetNumberFromUser("Lūdzu ievadiet otro skaitli");//izsaucam funkciju skaitļa iegūšanai
            double result;//izveidojam mainīgo rezultātam
            result = firstNumber + secondNumber;//iegūstam rezultātu
            Console.WriteLine("Rezultāts:" + result);
            Console.ReadLine();
        }
        static double GetNumberFromUser(string msg)//iekavās - arguments
        {
            //izvadam funkcijai iedoto paziņojumu
            Console.WriteLine(msg);
            //nolasām lietotāja ievadi no ekrāna un ierakstām teksta mainīgo
            string textInput = Console.ReadLine();
            //izveidojam mainīgo, kur glabāt  skaitli
            double parsedNumber;
            //pārveidojam tekstu par skaitli un ierakstam mainīgajā
            bool parseWasSuccses = double.TryParse(textInput, out parsedNumber);//bool - true or false
            if (parseWasSuccses == false) //Ja neatbilst - izpildīsies šis
            {
                Console.WriteLine("Slikti ievadīts skaitlis: " + textInput); // \ ļauj tekstā ielikt pēdiņas
                Console.WriteLine("Ievadi skaitli vēlreiz");
                parsedNumber = GetNumberFromUser(msg);// funkcija var izsaukt pati sevi
            }
            else
            {
                Console.WriteLine("Brīnišķīgi ievadīts skaitlis");
            }
            return parsedNumber;//return beigās, jo tālāk neies, ja tas būs sākumā
        }
       


    }
}
