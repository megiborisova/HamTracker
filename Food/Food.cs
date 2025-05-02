public abstract class FoodItem
{
    public string Name { get; set; }
    public string Variant { get; set; }
    public int Calories { get; set; }
    public int Protein { get; set; }
    public int Carbs { get; set; }
    public int Fat { get; set; }

    public FoodItem(string name, string variant, int calories, int protein, int carbs, int fat)
    {
        Name = name;
        Variant = variant;
        Calories = calories;
        Protein = protein;
        Carbs = carbs;
        Fat = fat;
    }

    public bool ValidateCalories()
    {
        return Calories == (Fat * 9 + Protein * 4 + Carbs * 4);
    }
}
