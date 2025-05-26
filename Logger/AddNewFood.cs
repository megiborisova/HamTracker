using System;
using System.Collections.Generic;

namespace CalorieTracker
{
    static class FoodManager
    {
        public static void AddNewFoodFlow(string foodsFile, List<Food> availableFoods)
        {
            Console.WriteLine("Enter category (Fruit, Vegetable, Alcoholic, NonAlcoholic, Meat, Dairy, OtherAnimalBased):");
            string category = Console.ReadLine();

            Console.Write("Enter food name: ");
            string name = Console.ReadLine();

            Console.Write("Enter calories: ");
            if (!int.TryParse(Console.ReadLine(), out int calories))
            {
                Console.WriteLine("Invalid calories input.");
                return;
            }

            Console.Write("Enter carbs (g): ");
            if (!double.TryParse(Console.ReadLine(), out double carbs))
            {
                Console.WriteLine("Invalid carbs input.");
                return;
            }

            Console.Write("Enter protein (g): ");
            if (!double.TryParse(Console.ReadLine(), out double protein))
            {
                Console.WriteLine("Invalid protein input.");
                return;
            }

            Console.Write("Enter fats (g): ");
            if (!double.TryParse(Console.ReadLine(), out double fats))
            {
                Console.WriteLine("Invalid fats input.");
                return;
            }

            string foodLine = "";
            Food newFood = null;

            switch (category.ToLower())
            {
                case "fruit":
                    newFood = new Fruit(name, calories, carbs, protein, fats);
                    foodLine = $"{name};{calories};{carbs};{protein};{fats}";
                    break;
                case "vegetable":
                    newFood = new Vegetable(name, calories, carbs, protein, fats);
                    foodLine = $"{name};{calories};{carbs};{protein};{fats}";
                    break;
                case "alcoholic":
                    Console.Write("Enter volume (ml): ");
                    if (!double.TryParse(Console.ReadLine(), out double volumeA))
                    {
                        Console.WriteLine("Invalid volume input.");
                        return;
                    }
                    Console.Write("Enter alcohol percentage: ");
                    if (!double.TryParse(Console.ReadLine(), out double alcPercent))
                    {
                        Console.WriteLine("Invalid alcohol percentage input.");
                        return;
                    }
                    newFood = new Alcoholic(name, calories, volumeA, alcPercent, carbs, protein, fats);
                    foodLine = $"{name};{calories};{volumeA};{alcPercent};{carbs};{protein};{fats}";
                    break;
                case "nonalcoholic":
                    Console.Write("Enter volume (ml): ");
                    if (!double.TryParse(Console.ReadLine(), out double volumeNA))
                    {
                        Console.WriteLine("Invalid volume input.");
                        return;
                    }
                    newFood = new NonAlcoholic(name, calories, volumeNA, carbs, protein, fats);
                    foodLine = $"{name};{calories};{volumeNA};{carbs};{protein};{fats}";
                    break;
                case "meat":
                    newFood = new Meat(name, calories, carbs, protein, fats);
                    foodLine = $"{name};{calories};{carbs};{protein};{fats}";
                    break;
                case "dairy":
                    newFood = new Dairy(name, calories, carbs, protein, fats);
                    foodLine = $"{name};{calories};{carbs};{protein};{fats}";
                    break;
                case "otheranimalbased":
                    newFood = new OtherAnimalProduct(name, calories, carbs, protein, fats);
                    foodLine = $"{name};{calories};{carbs};{protein};{fats}";
                    break;
                default:
                    Console.WriteLine("Unknown category.");
                    return;
            }

            availableFoods.Add(newFood);

            // Append food line to the file in the right category section
            FoodFileManager.AppendFoodToFile(foodsFile, category, foodLine);
            Console.WriteLine("Food added successfully.");
        }
    }
}