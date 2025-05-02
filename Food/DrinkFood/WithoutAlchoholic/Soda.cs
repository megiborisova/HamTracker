public class Soda : Drink
{
    public Soda(string name, int calories, int protein, int carbs, int fat)
        : base(name, calories, protein, carbs, fat)
    {
    }
    public void Describe()
    {
        Console.WriteLine($"This is a soda named '{Name}' with {Calories} calories, " +
                          $"Protein: {Protein}g, Carbs: {Carbs}g, Fat: {Fat}g.");
    }
}