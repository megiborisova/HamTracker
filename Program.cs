using System;
using System.Collections.Generic;
using System.IO;
using CalorieTracker;
using CalorieTracker.Models;

namespace CalorieTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDir = Directory.GetCurrentDirectory();
            string foodsFile = Path.Combine(currentDir, "foods.txt");
            string userFile = Path.Combine(currentDir, "user.json");

            List<Food> availableFoods = FoodLoader.LoadFoodsFromFile(foodsFile);
            User currentUser = UserManager.LoadUser(userFile);

            while (true)
            {
                Console.WriteLine("\n1. Log Food");
                Console.WriteLine("2. View Foods");
                Console.WriteLine("3. Add New Food");
                Console.WriteLine("4. View User Stats");
                Console.WriteLine("5. Save and Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        UserManager.LogEatenFoodFlow(currentUser, availableFoods);
                        break;
                    case "2":
                        FoodDisplay.DisplayFoodsOrganized(availableFoods);
                        break;
                    case "3":
                        FoodManager.AddNewFoodFlow(foodsFile, availableFoods);
                        break;
                    case "4":
                        currentUser.DisplayStats();
                        break;
                    case "5":
                        UserManager.SaveUser(currentUser, userFile);
                        Console.WriteLine("Data saved. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}