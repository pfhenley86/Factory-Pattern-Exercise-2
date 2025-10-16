namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database type would you like to use? ('mongo', 'sql','list')");
            
            var result = Console.ReadLine();

            var showProducts = DataAccessFactory.GetDataAccess(result);

            showProducts.LoadData();
            showProducts.SaveData();
        }
    }
}
