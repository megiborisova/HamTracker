using System;

namespace CalorieTracker.Models
{
    public class Alcoholic : Drinks
    {
        public double AlcoholPercentage { get; set; }

        public Alcoholic() { }

        public Alcoholic(string name, int calories, double alcoholPercent, double carbs, double protein, double fats)
            : base(name, calories, carbs, protein, fats)
        {
            AlcoholPercentage = alcoholPercent;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{Name} - {Calories} kcal - {AlcoholPercentage}% alcohol - {Carbs}g carbs, {Protein}g protein, {Fats}g fats");
        }
    }
}