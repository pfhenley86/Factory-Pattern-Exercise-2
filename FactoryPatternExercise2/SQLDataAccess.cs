namespace FactoryPatternExercise2;

public class SQLDataAccess : IDataAcess
{
    public void LoadData()
    {
        Console.WriteLine("Accessing the SQL Database...");
    }

    public void SaveData()
    {
        Console.WriteLine("Saving to the SQL Database...");
    }
}