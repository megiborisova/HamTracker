public class Wine : Drink
{
    public Wine(string name, int calories, int protein, int carbs, int fat, double volume)
        : base(name, calories, protein, carbs, fat, volume)
    {
    }
    public void Describe()
    {
        Console.WriteLine($"This is a Wine: '{Name}', {Volume}L, {Calories} calories, Protein: {Protein}g, Carbs: {Carbs}g, Fat: {Fat}g.");
    }
}