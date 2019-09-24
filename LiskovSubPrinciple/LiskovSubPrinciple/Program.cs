using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using LiskovSubPrinciple.ConcreteClass;

namespace LiskovSubPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var processor = new DuckProcessor();
            processor.Process(new RegularDuck());

            Console.WriteLine();
            Console.WriteLine("Press any key to exit....");
            Console.ReadLine();

        }
    }
}
