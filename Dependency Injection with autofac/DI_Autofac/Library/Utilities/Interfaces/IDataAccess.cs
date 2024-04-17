namespace Library.Utilities.Interfaces
{
    public interface IDataAccess
    {
        void LoadData();
        void SaveData(string data);
    }
}