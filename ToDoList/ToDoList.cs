using System;
using System.Collections.Generic;
using System.IO;
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
            for (int i = 0; i < toDoEntries.Count; i++)// skaitītājs=skaitītājs +1 ir tas pats kas: skaitītājs +=1; vai skaitītājs ++
            {
                Console.WriteLine((i + 1) + "." + toDoEntries[i]);
                
                //izsaucam indeksatoru[] - izsauc pirmo elementu no saraksta
            }// programmēšanā sāk skaitīt no nulles; skaitītājam lieto mainīgo i (index - kārtas skaitlis)

        }

        public void DeleteToDo(int indexOfToDo)
        {
            if (indexOfToDo >= this.toDoEntries.Count)
            {
                Console.WriteLine("Ieraksts neeksistē");
                return;
            }
            
                toDoEntries.RemoveAt(indexOfToDo);
                    
        }
        public void DeleteAllToDos()
        {
            toDoEntries.Clear();
        }

        internal void SaveToFile()
        {//Ja rāda, ka nesaprot - nospiest Ctrl + .
            for (int i = 0; i < toDoEntries.Count; i++)
            {
                //Append - pievienot, papildināt
                File.AppendAllText(@"C:\Users\Ilzīte\Documents\ToDoApplication\todos.txt", toDoEntries[i] + "\r\n");
                //@ ļauj ignorēt \, kas paši ļauj ignorēt citas lietas
                // \ var ignorēt ar otru \

            }
        }

        internal void LoadFromFile()
        {
            string[] allLinesFromFile = File.ReadAllLines(@"C:\Users\Ilzīte\Documents\ToDoApplication\todos.txt");
            foreach (string listEntry in allLinesFromFile)
            {
                toDoEntries.Add(listEntry);
            }
            
        }
    }
    }

