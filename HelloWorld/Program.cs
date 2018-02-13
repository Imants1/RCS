using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //izsaucam sevis izveidoto funkciju
            SayHello();
            //izsaucam otru izveidoto funkciju
            SayHelloToUser();
            SayHelloAge();
        }

        static void SayHelloToUser()
        {
            //palūdzam lietotājam ierakstīt vārdu
            Console.WriteLine("Please enter your name:");
            //izveidojam mainīgo, kur glabāt lietotāja vērtību
            string usersName;
            //paprasam konsolei izvadīt
            usersName = Console.ReadLine();
            Console.WriteLine("Labdien," + usersName + "!");
            
        }

        static void SayHello()
        {
            Console.WriteLine("Hello, world!");
            Console.ReadLine();
        }

        static void SayHelloAge()
        {
            Console.WriteLine("Your age?");
            string usersAge;
            usersAge = Console.ReadLine();
            Console.WriteLine(usersAge + ", that's good!");
            Console.ReadLine();
        }
    }
}
