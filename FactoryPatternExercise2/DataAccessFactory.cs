namespace FactoryPatternExercise2;

public static class DataAccessFactory
{
    public static IDataAcess GetDataAccess(string databaseType)
    {
        switch (databaseType.ToLower())
        {
            case "list":
               return new ListDataAccess();
            case "sql":
                return new SQLDataAccess();
            case "mongo":
                return new MongoDataAccess();
            default:
                return new ListDataAccess();
        }
    }
}