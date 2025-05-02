public class Yogurt : DairyProduct
{
    public Yogurt(int calories, int protein, int carbs, int fat)
        : base("Yogurt", calories, protein, carbs, fat) { }
    public void Describe()
    {
        Console.WriteLine($"This dairy product is Yogurt with {calories} kcal, Protein: {protein}g, Carbs: {carbs}g, Fat: {fat}g.");
    }
}