public class Coffee : Drink
{
    public Coffee(string name, int calories, int protein, int carbs, int fat)
        : base(name, calories, protein, carbs, fat)
    {
    }
    public void Describe()
    {
        Console.WriteLine($"This drink is a coffee named '{Name}' with {Calories} calories, " +
                          $"Protein: {Protein}g, Carbs: {Carbs}g, Fat: {Fat}g.");
    }
}