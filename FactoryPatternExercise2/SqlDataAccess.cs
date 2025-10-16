namespace FactoryPatternExercise2;

public class SqlDataAccess : IDataAccess
{
    public List<Product> LoadData()
    {
        Console.WriteLine("Accessing the SQL Database...");
        
        return new List<Product>
        {
            new Product { Name = "carrots", Price = 22.00 },
            new Product { Name = "peas", Price = 32.27 },
        };
    }

    public void SaveData()
    {
        Console.WriteLine("Saving to the SQL Database...");
    }
}