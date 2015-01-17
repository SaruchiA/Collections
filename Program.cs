using System;
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
            
            var x = System.Diagnostics.Process.GetProcesses();
            String userInputProc,processStr;
            List <String> SingleProcessSplit=new List<String> ();
            List<String> ConcatProcesses = new List<String>();
            int idxPara,idxPara2;
            List<String> listOfrunningProcess = new List<String>();
            List<String> filteredList = new List<String>();
            foreach (var item in x)
            {                
              //  Console.WriteLine(item.ProcessName + "is running with process id " + item.Id);
                listOfrunningProcess.Add(item+"" );
            }
            Console.WriteLine("total no. of processes are:"+listOfrunningProcess.Count());
            listOfrunningProcess.Sort();
            Console.WriteLine("\r\n \r\n \r\n part 1: list of processes in ascending order \r\n");
            for (int i = 0; i < listOfrunningProcess.Count; i++) 
            {
                processStr = listOfrunningProcess[i];
                //idxPara =29;
                //idxPara2 = list[i].LastIndexOf (')');
                SingleProcessSplit.AddRange( processStr.Split(new string[] { "(", ")" }, StringSplitOptions.None));
                for (int f = 1; f < SingleProcessSplit.Count; f+=2)
                {
                    ConcatProcesses.Add(SingleProcessSplit[f]);
                }
                SingleProcessSplit.Clear();
                //finalStr = d.Substring(idxPara,idxPara2 );           
                
            }
            for (int i = 0; i < ConcatProcesses.Count; i++)
            {
                Console.WriteLine(ConcatProcesses [i]);
            }
            //list.Reverse();
            Console.WriteLine("\r\n \r\n \r\n part 1: list of processes in descending order \r\n");
            for (int i = ConcatProcesses.Count - 1; i > 0; i--)
            {
                Console.WriteLine(ConcatProcesses[i]);
            }

            Console.WriteLine("enter the process name that needs to be added in list2 ");
            userInputProc = Console.ReadLine();
            Console.WriteLine("\r\n \r\n part 2:- show processes with particular suffix \r\n");
           
            for (int i = 0; i < listOfrunningProcess.Count; i++)
            {
                if (listOfrunningProcess[i] == userInputProc)
                {
                    filteredList.Add(listOfrunningProcess[i]+"");
                }
            }

            for (int i = 0; i < filteredList.Count; i++)
            {
               Console.WriteLine(filteredList[i] );
            } 
            Console.ReadKey();
           

        }
    }
}
