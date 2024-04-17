using Library.Utilities.Interfaces;

namespace Library.Utilities;
public class DataAccess : IDataAccess
{
    public void LoadData()
    {
        Console.WriteLine("Loading data");
    }

    public void SaveData(string data)
    {
        Console.WriteLine($"Saveing {data}");
    }
}
