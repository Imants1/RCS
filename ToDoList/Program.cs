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
            while (true)
            {
                //pievienot jaunu darāmo lietu
                Console.WriteLine("Lūdzu ievadiet darāmo lietu:");
                string toDoTask = Console.ReadLine();
                list.AddNewToDo(toDoTask);
                //dzēst visas darāmās lietas
                //izvadīt visas darāmās lietas uz ekrāna
                list.ShowAllToDos();
            }
        }

    }
}
