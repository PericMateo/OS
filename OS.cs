using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Process[] processesList = Process.GetProcesses();

            //ispisati za svaki proces 
            //-identifikatori
            //-naziv procesa
            //-da li proces "Živ" (Responding)
            //-Kolicina radne memorije(Workingset64)
            foreach (Process proces in processesList)
            {
                Console.WriteLine("Process: {0} , ID: {1}, Running:{2}, Memory: {3} bytes \n", proces.ProcessName, proces.Id,proces.Responding,proces.WorkingSet64);
                
            }
            var najveci = processesList[0];
            for(int i=0; i < processesList.Length; i++)
            {
                for (int j = 0; j < processesList.Length; j++)
                {
                    var p1 = processesList[i];
                    var p2 = processesList[j];
                    if (processesList[i].WorkingSet64 > processesList[j].WorkingSet64)
                    {
                        var drzi = processesList[i];
                        processesList[i] = processesList[j];
                        processesList[j] = drzi;
                    }
                    
                }
                

            }
            for (int i = 0; i < 10; i++)
            {
                var p = processesList[i];
                Console.WriteLine("{0} - {1}", p.WorkingSet64, p.ProcessName);
            }








            //-Ispisati 10 procesa koji troše najvise memorije










        }
    }
}
