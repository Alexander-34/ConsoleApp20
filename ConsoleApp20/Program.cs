using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {   // поколения
            //  0 - 256 Кб
            //  1 - 2 Мб
            //  2 - 10 Мб
            string s1 = new string('*',100);
            WriteLine(GC.MaxGeneration);

            WriteLine(GC.GetTotalMemory(false));
            WriteLine("{0: ### ### ### ###}", GC.GetTotalMemory(false));
            WriteLine("Generation is " + GC.GetGeneration(s1));
            
            
            FillMemory(16);
            //FillMemory(16);


            //GC.Collect();
            WriteLine("{0: ### ### ### ###}", GC.GetTotalMemory(true));
            WriteLine("Generation is " + GC.GetGeneration(s1));
            ReadKey();
        }
        static void FillMemory(int size)
        {
            string sHidden = new string('*', 341 * size);
        }
    }
}
