namespace FactoryPatternExercise2;

public class MongoDataAccess : IDataAccess
{
    public List<Product> LoadData()
    {
        Console.WriteLine("Loading from the Mongo Database...");
        
        return new List<Product>
        {
            new Product { Name = "frank", Price = 33.42 },
            new Product { Name = "beans", Price = 42.33 },
        };
    }

    public void SaveData()
    {
        Console.WriteLine("Saving to the Mongo Database...");
    }
}