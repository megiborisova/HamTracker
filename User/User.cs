using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace CalorieTracker
{
    public class User
    {
        public string Username { get; set; }
        public List<Food> EatenFoods { get; set; } = new List<Food>();

        public void AddFood(Food food)
        {
            EatenFoods.Add(food);
        }

        public int TotalCaloriesToday()
        {
            return EatenFoods.Sum(f => f.Calories);
        }

        public void DisplayStats()
        {
            Console.WriteLine($"\n--- {Username}'s Stats ---");
            Console.WriteLine($"Total Foods Eaten: {EatenFoods.Count}");
            Console.WriteLine($"Total Calories: {TotalCaloriesToday()}");
        }

        public void SaveToFile()
        {
            string filename = Username + ".json";
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                TypeInfoResolver = JsonTypeInfoResolver.Default
            };
            File.WriteAllText(filename, JsonSerializer.Serialize(this, options));
        }

        public static User LoadFromFile(string username)
        {
            string filename = username + ".json";
            if (File.Exists(filename))
            {
                var options = new JsonSerializerOptions
                {
                    TypeInfoResolver = JsonTypeInfoResolver.Default
                };
                string json = File.ReadAllText(filename);
                return JsonSerializer.Deserialize<User>(json, options);
            }
            return new User { Username = username };
        }
    }
}