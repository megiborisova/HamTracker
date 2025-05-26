class Alcoholic : Drinks
    {
        public double AlcoholPercentage { get; set; }

        public Alcoholic(string name, int calories, double volume, double alcoholPercent, double carbs, double protein, double fats)
            : base(name, calories, volume, carbs, protein, fats)
        {
            AlcoholPercentage = alcoholPercent;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{Name} - {Calories} kcal - {VolumeMl}ml - {AlcoholPercentage}% alcohol - {Carbs}g carbs, {Protein}g protein, {Fats}g fats");
        }
    }