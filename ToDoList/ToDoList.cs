using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class ToDoList
    {
        public ToDoList ()//konstruktors, kurš tiek izsaukts, kad izveido objektu. Neko neatgriež un vienmēr saucas tāpat kā klase
        {
            toDoEntries = new List<string>();
        }
        List<string> toDoEntries;//mainīgie eksistē starp figūriekavām, kur tie ir

        public void AddNewToDo(string task)// publiskas funkcijas var izsaukt no ārpuses
        {
           
            Console.WriteLine("Uzdevums pievienots:" + task);
            toDoEntries.Add(task);
        }

        public void ShowAllToDos()
        {
            for (int skaitītājs = 0; skaitītājs < toDoEntries.Count; skaitītājs += 1)// skaitītājs=skaitītājs +1 ir tas pats kas: skaitītājs +=1; vai skaitītājs ++
            {
                Console.WriteLine("Uzdevumu saraksts: " + toDoEntries[skaitītājs]);//izsaucam indeksatoru[] - izsauc pirmo elementu no saraksta
            }// programmēšanā sāk skaitīt no nulles
        }
       

    }
}
