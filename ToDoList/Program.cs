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
                Console.WriteLine("d-dzēst visu");
                Console.WriteLine("s-saglabāt");
                string usersInput = Console.ReadLine();
                switch (usersInput)
                {
                    case "a": //pievienot jaunu darāmo lietu
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
                    case "d":
                        list.DeleteAllToDos();
                        Console.WriteLine("Visi ieraksti dzēsti!");
                        Console.ReadLine();
                        break;
                    case "s":
                        //saglabājam saturu failā
                        list.SaveToFile();
                        break;
                                    }



            }
        }

    }
}
