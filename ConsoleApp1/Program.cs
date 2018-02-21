using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lūdzu ievadi vārdu: ");
            string usersLetters = Console.ReadLine();
            string pathToFile = @"C:\Users\Ilzīte\Documents\Vardnica\words.txt";
            string[] wordsFromDictionary = File.ReadAllLines(pathToFile);
            foreach (var wordsFromDict in wordsFromDictionary)
            {
                bool hasInvalidLetterBeenFound = false;
                foreach (char currentSymbol in usersLetters)
                {
                    if (wordsFromDict.Contains(currentSymbol) == false)
                    {
                        hasInvalidLetterBeenFound = true;
                    }
                }
                foreach (char wordSymbol in wordsFromDict)
                {
                    if (usersLetters.Contains(wordSymbol) == false)
                    {
                        hasInvalidLetterBeenFound = true;
                    }

                }
                if (hasInvalidLetterBeenFound == false)
                {
                   Console.WriteLine(wordsFromDict);
                   
                }
               
                


                // palūdzam lietotājam ievadīt vārdu, kura burtus izmantot meklēšanai
                // ielādējam visus vārdus no vārdnīcas faila
                // izmantojot ciklu apstrādājam katru vārdu no vārdnīcas faila

                // izveidojam mainīgo, kurā piefiksēsim to, vai vārdā ir kādi nevajadzīgi burti 
                // izmantojot ciklu, apstrādājam katru burtu lietotāja ievadītajā vārdā
                // pārbaudam, vai burts atrodas vārdnīcas vārdā
                // ja neatrodas, tad piefiksējam, ka lieks burts ir atrasts
                // izmantojot ciklu, apstrādājam katru burtu vārdnīcas vārdā
                // pārbaudām, vai burts ir atrasts lietotāja ievadītajā vārdā
                // ja neatrodas, tad piefiksējam, ka lieks burts ir atrasts
                // kad vārdu apstrāde pa burtiem beigusies,
                // pārbaudām vai vārdnīcas vārdā ir atrasti nevajadzīgi burti
                // ja nav, tad izvadām vārdu uz ekrāna

            }
            Console.ReadLine();
        }
    }
}
