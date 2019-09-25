using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;
using DemoLibrary.Utilities;
using Unity;
using Unity.Lifetime;

namespace ConsoleUI
{
    public static class ContainerConfig
    {
        public static IUnityContainer Configure()
        {
            var container = new UnityContainer();
            container.RegisterInstance<IUnityContainer>(container);
            container.RegisterType<IApplication, Application>(new SingletonLifetimeManager());

            container.RegisterType<IDataAccess, DataAccess>(new TransientLifetimeManager());
            container.RegisterType<IBusinessLogic, BusinessLogic2>();
            container.RegisterType<ILogger, Logger>();

            return container;

        }
    }
}
