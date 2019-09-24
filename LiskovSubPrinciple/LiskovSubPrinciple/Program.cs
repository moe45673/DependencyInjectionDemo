using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiskovSubPrinciple.ConcreteClass;

namespace LiskovSubPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boilerplate Code
            var app = new AppRunner();
            app.Run(new ElectricDuck());

            Console.WriteLine();
            Console.WriteLine("Press any key to exit....");
            Console.ReadLine();

        }
    }
}
