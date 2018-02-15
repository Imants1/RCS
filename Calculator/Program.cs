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
            string usersInput = "0";
            while (true)// veido ciklu, kas izpild bloku kamēr tas ir patiess, atšķirībā no if, kas to dara vienu reizi
            {
                Console.WriteLine("Lūdzu izvēlies darbību");
                Console.WriteLine("a - aprēķināt riņķa laukumu");
                Console.WriteLine("b - saskaitīt divus skaitļus");
                Console.WriteLine("c - vai skaitlis dalās");
                Console.WriteLine("x - iziet");
                usersInput = Console.ReadLine();
                if (usersInput == "a")// if - else if - else - programma izpildīs tikai vienu bloku; else if var būt cik tik grib
                {
                    CalculateCircleArea();
                }
                else if (usersInput == "b")
                {
                    CountTwoNumbersTogether();
                }
                else if (usersInput == "c")
                {
                    DoesTheNumberDivide();
                }
                else if (usersInput == "x")
                {
                    break;
                }
                                else
                {
                    Console.WriteLine("Sorry, did not understand");
                }
            }
            
            Console.ReadLine();



        }
        static void CalculateCircleArea()//semikolu šeit neliek, jo nav darbība
                                         //Aiz apaļajām iekavām ir vai nu semikols, vai figūriekavas
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
        static void CountTwoNumbersTogether()//Funkcijas nosaukums, norāda arī ko atgriezīs. Void - vienkārši izpildās.
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
            //izveidojam mainīgo, kur glabāt  skaitliC:\Users\Ilzīte\Documents\GitHub\RCS\Calculator\Program.cs
            double parsedNumber;
            //pārveidojam tekstu par skaitli un ierakstam mainīgajā
            bool parseWasSuccses = double.TryParse(textInput, out parsedNumber);//bool - true or false
            if (parseWasSuccses == false) //Ja neatbilst - izpildīsies šis
            {
                Console.WriteLine("Slikti ievadīts skaitlis: " + textInput); // \ ļauj tekstā ielikt pēdiņas
                Console.WriteLine("Ievadi skaitli vēlreiz");
                parsedNumber = GetNumberFromUser(msg);// funkcija var izsaukt pati sevi
            }
           
            return parsedNumber;//return beigās, jo tālāk neies, ja tas būs sākumā.
            //Return vajadzīgs, lai funkcija atgrieztu vērtību
        }
        static void DoesTheNumberDivide()
        {
            double dalāmais = GetNumberFromUser("Lūdzu ievadiet dalāmo");
            double dalītājs = GetNumberFromUser("Lūdzu ievadiet dalītāju");
            double modulis = dalāmais % dalītājs;// dala tuvāko veselo skaitli un modulī parādās atlikums
            if (modulis == 0)// ja skaitļi dalās - modulis ir 0
            {
                Console.WriteLine("Skaitļi dalās");
            }
            else
            {
                Console.WriteLine("Skaitļi nedalās");
            }
        }



    }
}
