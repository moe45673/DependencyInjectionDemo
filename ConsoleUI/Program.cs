using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var _container = ContainerConfig.Configure();
            IApplication app = _container.Resolve<IApplication>();

            app.Run();

            Console.ReadLine();
        }
    }
}
