namespace GA_ToDo
{
    internal class Program
    {
        static void Main()
        {
            var taskProgram = new TaskProgram();
            taskProgram.Run();
        }
    }

    internal class TaskProgram
    { 
        Tasks TasksInstance = new Tasks("", "", "");
        bool RunProgram = true;

        public void Run()
        { 
            while (RunProgram == true)
            {
                MainMenu();
               
                var UserChoice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (UserChoice)
                {
                    case '1':
                        TasksInstance.AddTask("","","");
                        break;
                    case '2':
                        TasksInstance.ShowTasks("", "");
                        break;
                    case '3':
                        TasksInstance.DeleteTask("", "", "");
                        break;
                    case '4':
                        Console.WriteLine("Ha en fin dag!");
                        RunProgram = false;
                        break;
                    default:
                        break;
                }
            }
        }

        public void MainMenu()
        {
            Console.WriteLine("*** To Do Console App ***");
            Console.WriteLine();
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Legg til oppgave.");
            Console.WriteLine("2. Vis liste med oppgaver.");
            Console.WriteLine("3. Slett oppgave fra listen.");
            Console.WriteLine("4. Exit.");
        }
    }
}
