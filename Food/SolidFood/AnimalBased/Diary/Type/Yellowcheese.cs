public class YellowCheese : DairyProduct
{
    public YellowCheese(int calories, int protein, int carbs, int fat)
        : base("Yellow Cheese", calories, protein, carbs, fat) { }
    public void Describe()
    {
        Console.WriteLine($"This dairy product is Yellow Cheese with {calories} kcal, Protein: {protein}g, Carbs: {carbs}g, Fat: {fat}g.");
    }
}