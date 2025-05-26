using System;
using System.Collections.Generic;

namespace CalorieTracker
{
    static class UserInteraction
    {
        public static void LogEatenFood(User user, List<Food> availableFoods)
        {
            Console.WriteLine("Select food to log (enter number):");
            for (int i = 0; i < availableFoods.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                availableFoods[i].DisplayInfo();
            }

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                if (choice >= 1 && choice <= availableFoods.Count)
                {
                    Food selectedFood = availableFoods[choice - 1];
                    user.AddFood(selectedFood);
                    Console.WriteLine($"Logged {selectedFood.Name}.");
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}