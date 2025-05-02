public abstract class AnimalBasedFood : SolidFood
{
    protected AnimalBasedFood(string name, int calories, int protein, int carbs, int fat)
        : base(name, calories, protein, carbs, fat) { }
}
