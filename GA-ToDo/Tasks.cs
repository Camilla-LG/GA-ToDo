using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_ToDo
{
    internal class Tasks
    {
        public List<Tasks> ListOfTasks = new List<Tasks>();
        public string Task {  get; set; }
        public string Deadline { get; set; }

        public string DeleteObject;

        public Tasks(string task, string deadline, string deleteObject) 
        {
            Task = task;
            Deadline = deadline;
            DeleteObject = deleteObject;
        }

        public void AddTask(string task, string deadline, string deleteObject)
        {
            Console.WriteLine("Skriv inn oppgaven som må gjøres.");
            task = Console.ReadLine();
            Console.WriteLine("Skriv inn frist for når oppgaven må være utført.");
            deadline = Console.ReadLine();
            ListOfTasks.Add(new Tasks(task, deadline, deleteObject));
            Console.WriteLine("Oppgave og frist er lagt til listen.");
        }

        public void ShowTasks(string task, string deadline)
        {
            foreach(var x in ListOfTasks) 
            {
                Console.WriteLine($" *  {x.Task}, frist: {x.Deadline}");
            }
            Console.WriteLine();
        }

        public void DeleteTask(string task, string deadline, string deleteObject)
        {
            Console.WriteLine("Hvilken oppgave vil du slette fra listen?");
            DeleteObject = Console.ReadLine();

            for (int i = 0; i < ListOfTasks.Count; i++)
            {
                if (DeleteObject.ToLower() == ListOfTasks[i].Task.ToLower())
                {
                    Console.WriteLine($"Vil du fjerne oppgaven {ListOfTasks[i].Task} med frist {ListOfTasks[i].Deadline}? J/N");
                    string UserInput = Console.ReadLine();

                    if (UserInput.ToLower() == "j")
                    {
                        ListOfTasks.RemoveAt(i);
                        Console.WriteLine($"{ListOfTasks[i].Task} med frist {ListOfTasks[i].Deadline} er fjernet fra listen.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Finner ikke oppgaven i listen.");
                    }
                }
            }
        }
    }
}
