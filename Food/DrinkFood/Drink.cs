using System;

namespace CalorieTracker.Models
{
    public class NonAlcoholic : Drinks
    {
        public NonAlcoholic() { }

        public NonAlcoholic(string name, int calories, double carbs, double protein, double fats)
            : base(name, calories, carbs, protein, fats) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{Name} - {Calories} kcal - {Carbs}g carbs, {Protein}g protein, {Fats}g fats");
        }
    }
}