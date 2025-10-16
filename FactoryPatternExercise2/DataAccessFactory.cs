namespace FactoryPatternExercise2;

public static class DataAccessFactory
{
    public static IDataAccess GetDataAccess(string databaseType)
    {
        switch (databaseType.ToLower())
        {
            case "list":
               return new ListDataAccess();
            case "sql":
                return new SqlDataAccess();
            case "mongo":
                return new MongoDataAccess();
            default:
                throw new ArgumentException("Invalid database type");
        }
    }
}