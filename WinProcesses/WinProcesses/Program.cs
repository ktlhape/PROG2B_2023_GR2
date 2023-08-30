using System.Diagnostics;

namespace WinProcesses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myPC = Environment.MachineName;
            List<Process> runningProcess = (from proc in Process.GetProcesses(myPC)
                                 orderby proc.ProcessName
                                 select proc).ToList();


            Process[] processTasks = (from proc in Process.GetProcessesByName("ssms")
                               orderby proc.Id
                               select proc).ToArray();

            //foreach (Process p in processTasks)
            //{
            //    Console.WriteLine($"{p.Id}\t{p.ProcessName}");
            //}
            Console.WriteLine("Notepad = 1. Word = 2, Paint = 3");
            int option = Convert.ToInt32(Console.ReadLine());
            string app = "";

            if (option == 1)
            {
                app = "notepad";
            }else if (option == 2)
            {
                app = @"C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE";
            }
            else if(option == 3)
            {
                app = "mspaint";
            }
            else
            {
                Console.WriteLine("Application not found");
            }

            Process.Start(app);

           

        }
    }
}