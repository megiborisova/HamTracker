using System;
using System.Collections.Generic;
using System.IO;

namespace CalorieTracker
{
    public static class FoodLoader
    {
        // Load foods from file
        static List<Food> LoadFoodsFromFile(string filepath)
        {
            var foods = new List<Food>();
            if (!File.Exists(filepath))
            {
                Console.WriteLine($"Food file {filepath} not found. Starting empty.");
                return foods;
            }

            string[] lines = File.ReadAllLines(filepath);
            string currentCategory = "";

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                if (line.StartsWith("#"))
                {
                    currentCategory = line.Substring(1).Trim();
                    continue;
                }

                string[] parts = line.Split(';');
                try
                {
                    switch (currentCategory.ToLower())
                    {
                        case "fruit":
                            foods.Add(new Fruit(parts[0], int.Parse(parts[1]), double.Parse(parts[2]), double.Parse(parts[3]), double.Parse(parts[4])));
                            break;
                        case "vegetable":
                            foods.Add(new Vegetable(parts[0], int.Parse(parts[1]), double.Parse(parts[2]), double.Parse(parts[3]), double.Parse(parts[4])));
                            break;
                        case "alcoholic":
                            foods.Add(new Alcoholic(parts[0], int.Parse(parts[1]), double.Parse(parts[2]), double.Parse(parts[3]), double.Parse(parts[4]), double.Parse(parts[5]), double.Parse(parts[6])));
                            break;
                        case "nonalcoholic":
                            foods.Add(new NonAlcoholic(parts[0], int.Parse(parts[1]), double.Parse(parts[2]), double.Parse(parts[3]), double.Parse(parts[4]), double.Parse(parts[5])));
                            break;
                        case "meat":
                            foods.Add(new Meat(parts[0], int.Parse(parts[1]), double.Parse(parts[2]), double.Parse(parts[3]), double.Parse(parts[4])));
                            break;
                        case "dairy":
                            foods.Add(new Dairy(parts[0], int.Parse(parts[1]), double.Parse(parts[2]), double.Parse(parts[3]), double.Parse(parts[4])));
                            break;
                        case "otheranimalbased":
                            foods.Add(new OtherAnimalProduct(parts[0], int.Parse(parts[1]), double.Parse(parts[2]), double.Parse(parts[3]), double.Parse(parts[4])));
                            break;
                        default:
                            Console.WriteLine($"Unknown category {currentCategory}, skipping {line}");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error parsing line: {line} - {ex.Message}");
                }
            }

            return foods;
        }

    }
}