using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Resource:IDisposable
    {
        string Name;
        string s = new string('*', 256 * 341);
        public Resource(string name)
        {
            Name = name;
        }
        // protected override void Finalize(string name)
        public void Dispose()
        {
            WriteLine("Dispose");
        }
        ~Resource()
        {
            WriteLine(Name + " has been finalized");
        }
        /*
          protected override void Finalize()
        {

        }
        */
        
    }
    class Program
    {
        static void CreateResource(string name)
        {

            WriteLine(name + " has been finalized");

        }
        static void Main(string[] args)
        {   // поколения
            //  0 - 256 Кб
            //  1 - 2 Мб
            //  2 - 10 Мб
            /*
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
            */
            Resource r = new Resource("01");
            try
            {
                CreateResource("CreateResource ");
            }
            finally
            {
                r.Dispose();
                //  r = null;
            }
            
            GC.Collect();
            ReadKey();
        }
        static void FillMemory(int size)
        {
            string sHidden = new string('*', 341 * size);
            
        }
        
    }
}
