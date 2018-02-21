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

        public ToDoList()//konstruktors, kurš tiek izsaukts, kad izveido objektu. Neko neatgriež un vienmēr saucas tāpat kā klase
        {
            toDoEntries = new List<ToDoListEntry>();
        }
        List<ToDoListEntry> toDoEntries;//mainīgie eksistē starp figūriekavām, kur tie ir
        string pathToToDoFile = @"C:\Users\Ilzīte\Documents\ToDoApplication\todos.txt";

        public void AddNewToDo(string task)// publiskas funkcijas var izsaukt no ārpuses
        {

            Console.WriteLine("Uzdevums pievienots:" + task);
            ToDoListEntry usersToDo = new ToDoListEntry();
            usersToDo.Name = task;
            toDoEntries.Add(usersToDo);

        }



        public void ShowAllToDos()
        {
            for (int i = 0; i < toDoEntries.Count; i++)// skaitītājs=skaitītājs +1 ir tas pats kas: skaitītājs +=1; vai skaitītājs ++
            {
                Console.Write((i + 1) + "." + toDoEntries[i].Name);// WriteLine - uzraksta tekstu un nospiež enter, Write - tikai uzraksta
                if (toDoEntries[i].IsCompleted)
                {
                    Console.Write(" DONE");
                }
                Console.WriteLine();

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
            else
            {
                toDoEntries.RemoveAt(indexOfToDo);
            }
        }
        public void DeleteAllToDos()
        {
            toDoEntries.Clear();
        }

        internal void SaveToFile()
        {//Ja rāda, ka nesaprot - nospiest Ctrl + .
            File.Delete(pathToToDoFile);

            for (int i = 0; i < toDoEntries.Count; i++)
            {
                //Append - pievienot, papildināt

                string nameOfToDo = toDoEntries[i].Name;
                File.AppendAllText(pathToToDoFile, nameOfToDo + "\r\n");
                //@ ļauj ignorēt \, kas paši ļauj ignorēt citas lietas
                // \ var ignorēt ar otru \
                bool IsCompleted = toDoEntries[i].IsCompleted;
                File.AppendAllText(pathToToDoFile, IsCompleted + "\r\n");
            }
        }

        internal void MarkToDoDone(int done)
        {
            if (done >= this.toDoEntries.Count)
            {
                Console.WriteLine("Ieraksts neeksistē");
                return;
            }
            else
            {
                toDoEntries[done].IsCompleted = true;
                Console.WriteLine(toDoEntries[done].Name + " - atzīmēts, kā izpildīts");
            }
        }

        internal void LoadFromFile()
        {
            if (File.Exists(pathToToDoFile) == false)//ja faila nav, pārtrauc. false var rakstīt arī kā !File.Exists...
            {
                return;
            }
            toDoEntries.Clear();
            string[] allLinesFromFile = File.ReadAllLines(pathToToDoFile);//[]izveido masīvu - nav dinamiska garuma, nevar pievienot jaunus, dzēst, var izgūt skaitu
            //dodamies cauri sarakstam ar teksta rindām
            for (var index = 0; index < allLinesFromFile.Length; index += 2)
            {
                string toDoEntries = allLinesFromFile[index];
                ToDoListEntry fileToDo = new ToDoListEntry();//izveidojam jaunu uzdevumu
                fileToDo.Name = toDoEntries;
                fileToDo.IsCompleted = bool.Parse(allLinesFromFile[index + 1]);
                this.toDoEntries.Add(fileToDo);


            }




        }

    }
}

