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

        public Tasks(string task, string deadline) 
        {
            Task = task;
            Deadline = deadline;
        }

        public void AddTask(string task, string deadline)
        {
            Console.WriteLine("Skriv inn oppgaven som må gjøres.");
            task = Console.ReadLine();
            Console.WriteLine("Skriv inn frist for når oppgaven må være utført.");
            deadline = Console.ReadLine();
            ListOfTasks.Add(new Tasks(task, deadline));
            Console.WriteLine("Oppgave og frist er lagt til listen.");
        }

        public void ShowTasks(string task, string deadline)
        {
            foreach(var x in ListOfTasks) 
            {
                Console.WriteLine($" *  {this.Task}, frist: {this.Deadline}");
            }
            Console.WriteLine();
        }

        public void DeleteTask(string task, string deadline)
        {

        }
    }
}
