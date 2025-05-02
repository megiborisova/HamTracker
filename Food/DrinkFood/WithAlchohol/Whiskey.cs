public class Whiskey : Drink
{
    public Whiskey(string name, int calories, int protein, int carbs, int fat, double volume)
        : base(name, calories, protein, carbs, fat, volume)
    {
    }
    public void Describe()
    {
        Console.WriteLine($"This is a Whiskey: '{Name}', {Volume}L, {Calories} calories, Protein: {Protein}g, Carbs: {Carbs}g, Fat: {Fat}g.");
    }
}