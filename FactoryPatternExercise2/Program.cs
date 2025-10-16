namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database type would you like to use? ('mongo', 'sql','list')");
    
            var result = Console.ReadLine();
            Console.WriteLine($"You entered: {result}");

            var showProducts = DataAccessFactory.GetDataAccess(result);

            var products = showProducts.LoadData(); // This should trigger the console message

            showProducts.SaveData();

            foreach (var product in products)
            {
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
