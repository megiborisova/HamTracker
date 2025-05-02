public class Vegetable : PlantBasedFood
{
    public Vegetable(string name, int calories, int protein, int carbs, int fat)
        : base(name, calories, protein, carbs, fat)
    {
    }

    public void Describe()
    {
        Console.WriteLine($"This is a vegetable: {Name}, {Calories} kcal, Protein: {Protein}g, Carbs: {Carbs}g, Fat: {Fat}g.");
    }
}
