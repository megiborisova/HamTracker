public class Egg : AnimalBasedFood
{
    public Egg(string name, int calories, int protein, int carbs, int fat)
        : base(name, calories, protein, carbs, fat) { }

    public void Describe()
    {
        Console.WriteLine($"This is an egg product: {Name}, {Calories} kcal, Protein: {Protein}g, Carbs: {Carbs}g, Fat: {Fat}g.");
    }
}