namespace FactoryPatternExercise2;

public interface IDataAcess
{
    public List<Product> LoadData();
    public void SaveData();
}