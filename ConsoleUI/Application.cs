using DemoLibrary;

namespace ConsoleUI
{
    public class Application : IApplication
    {
        private readonly IBusinessLogic _bLogic;

        public Application(IBusinessLogic bLogic)
        {
            _bLogic = bLogic;
        }

        public void Run()
        {
            _bLogic.ProcessData();
        }
    }
}