using Library.Utilities.Interfaces;

namespace Library;
public class BusinessLogic : IBusinessLogic
{
    protected ILogger _logger;
    protected IDataAccess _dataAccess;
    public BusinessLogic(ILogger logger, IDataAccess dataAccess)
    {
        _logger = logger;
        _dataAccess = dataAccess;
    }

    public void ProcessData()
    {
        _logger.Log("Starting the processnig");
        Console.WriteLine("Processing the data");

        _dataAccess.LoadData();
        _dataAccess.SaveData("ProcessedInfo");

        _logger.Log("Finished processing");
    }
}
