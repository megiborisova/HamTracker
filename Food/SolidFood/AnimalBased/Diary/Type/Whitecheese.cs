public class WhiteCheese : DairyProduct
{
    public WhiteCheese(int calories, int protein, int carbs, int fat)
        : base("White Cheese", calories, protein, carbs, fat) { }
    public void Describe()
    {
        Console.WriteLine($"This dairy product is Milk with {calories} kcal, Protein: {protein}g, Carbs: {carbs}g, Fat: {fat}g.");
    }
}