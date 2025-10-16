namespace FactoryPatternExercise2;

public class ListDataAccess : IDataAccess
{
    public List<Product> LoadData()
    {
        Console.WriteLine("Reading data from List...");

        return new List<Product>
        {
            new Product { Name = "apple", Price = 10.00 },
            new Product { Name = "banana", Price = 20.00 },
        };
    }

    public void SaveData()
    {
        Console.WriteLine("Saving data to List...");
    }
}