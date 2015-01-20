using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        
        static void Main(string[] args)
        {

            //workWithLists();          
            workWithDictionary();
            Console.ReadKey();
        }

        private static void workWithLists()
        {
            var x = Process.GetProcesses();
            var inputProcess = "";
            List<Process> running_processes = new List<Process>();
            List<String> Process_Name = new List<String>();
            running_processes.AddRange(x);
            foreach (var item in x)
            {
                Process_Name.Add("" + item.ProcessName);
                Console.WriteLine(item.ProcessName + " is running with process id " + item.Id);
            }
            Process_Name.Sort();
            Console.WriteLine("List of Processes sorted in Ascending order:- ");
            foreach (var item in Process_Name)
            {
                Console.WriteLine("\n" + item);
            }

            Console.WriteLine("List of Processes sorted in Descending order:- ");
            Process_Name.Reverse();
            foreach (var item in Process_Name)
            {
                Console.WriteLine("\n" + item);
            }

            Console.WriteLine("Enter the process name:- ");
            inputProcess = Console.ReadLine();

            foreach (var item in running_processes)
            {
                if (inputProcess == item.ProcessName)
                    Console.WriteLine("Process " + item.ProcessName + " is running with ID " + item.Id);
            }
        } // end of method workWithLists()

        private static void workWithDictionary()
        {
            Dictionary <int,String> runningProcesses= new Dictionary<int,string> () ;
            List<String> processName = new List<string>();
            String inputProcess;
            var x = Process.GetProcesses();
            foreach (var item in x)
            {
                runningProcesses.Add(item.Id, item.ProcessName);
            }
            //runningProcesses.Values.ToList();
            processName = runningProcesses.Values.ToList();
            //foreach (var item in x)
            //{
            //    processName.Add(""+runningProcesses .Values );
            //}
            processName.Sort();

            Console.WriteLine("\n\n Processes in ascending order:=");
            foreach (var item in processName)
            {
                Console.WriteLine("\n" + item );
            }

            processName.Reverse();
            Console.WriteLine("\n\n Processes in descending order:=");
            foreach (var item in processName)
            {
                Console.WriteLine("\n" + item );
            }

            Console.WriteLine("Specify a process to be shown with its ID:");
            inputProcess = Console.ReadLine();

            foreach (var item in runningProcesses )
            {
                    if (inputProcess == item.Value )
                    {
                        Console.WriteLine(" Specified Process \" " + item.Value + "\" is running with id " + item.Key);
                    }
            }
        
        
        } // end of method workWithDictionary() 

    }
}
