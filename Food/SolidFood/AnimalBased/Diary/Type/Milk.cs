public class Milk : DairyProduct
{
    public Milk(int calories, int protein, int carbs, int fat)
        : base("Milk", calories, protein, carbs, fat) { }
    public void Describe()
    {
        Console.WriteLine($"This dairy product is Milk with {calories} kcal, Protein: {protein}g, Carbs: {carbs}g, Fat: {fat}g.");
    }

}
