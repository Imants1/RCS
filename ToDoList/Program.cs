using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoList list = new ToDoList();
            list.LoadFromFile();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Lūdzu izvēlies darbību:");
                Console.WriteLine("a-pievienot");
                Console.WriteLine("b-parādīt");
                Console.WriteLine("c-dzēst");
                Console.WriteLine("z-atzīmēt, kā izdarītu");
                Console.WriteLine("d-dzēst visu");
                Console.WriteLine("s-saglabāt");
                Console.WriteLine("l-ielādēt sarakstu");
                string usersInput = Console.ReadLine();
                switch (usersInput)
                {// var salikt divus case kopā, piemēram case "a" un case "add" - abos gadījumos izpilda šo zaru
                    case "a":
                    case "pievienot"://pievienot jaunu darāmo lietu
                        Console.WriteLine("Lūdzu ievadiet darāmo lietu:");
                        string toDoTask = Console.ReadLine();
                        list.AddNewToDo(toDoTask);
                        Console.ReadLine();
                        break;
                    case "b":
                        //izvadīt visas darāmās lietas uz ekrāna
                        Console.WriteLine("Uzdevumu saraksts:");
                        list.ShowAllToDos();
                        Console.ReadLine();
                        break;
                    case "c":
                        Console.WriteLine("Izvēlies, ko dzēst");
                        list.ShowAllToDos();
                        int index = int.Parse(Console.ReadLine());
                        list.DeleteToDo(index - 1);
                        Console.WriteLine("Ieraksts dzēsts!");
                        Console.ReadLine();
                        break;
                    case "z":
                        Console.WriteLine("Lūdzu ievadi paveiktā uzdevuma numuru:");
                        list.ShowAllToDos();
                        int done = int.Parse(Console.ReadLine());
                        list.MarkToDoDone(done - 1);
                        Console.ReadLine();
                        break;
                    case "d":
                        list.DeleteAllToDos();
                        Console.WriteLine("Visi ieraksti dzēsti!");
                        Console.ReadLine();
                        break;
                    case "s":
                        //saglabājam saturu failā
                        list.SaveToFile();
                        break;
                    case "l":
                        //izvadīt visas darāmās lietas uz ekrāna
                        list.LoadFromFile();
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Neatpazīta komanda");
                        Console.ReadLine();                
                        break;
                }

            }
        }

    }
}
