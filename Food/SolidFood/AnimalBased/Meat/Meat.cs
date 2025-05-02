public abstract class Meat : AnimalBasedFood
{
    protected Meat(string name, int calories, int protein, int carbs, int fat)
        : base(name, calories, protein, carbs, fat) { }
}