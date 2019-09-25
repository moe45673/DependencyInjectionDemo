using DemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class BusinessLogic2 : IBusinessLogic
    {
        private readonly ILogger _logger;
        private readonly IDataAccess _dataAccess;

        public BusinessLogic2(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }

        public void ProcessData()
        {
            Console.WriteLine("This is BUsinesslogic2!!!!! YAYyyyyyyy!");
            _logger.Log("Starting the processing of data.");
            Console.WriteLine("Processing the data");
            _dataAccess.LoadData();
            _dataAccess.SaveData("ProcessedInfo");
            _logger.Log("Finished processing of the data.");
        }
    }
}
