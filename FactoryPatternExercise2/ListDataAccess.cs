namespace FactoryPatternExercise2;

public class ListDataAccess : IDataAcess
{
    public void LoadData()
    {
        Console.WriteLine("I am reading data from SQL Database...");
    }

    public void SaveData()
    {
        Console.WriteLine("I am saving data to SQL Database...");
    }
}