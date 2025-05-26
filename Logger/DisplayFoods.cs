using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CalorieTracker
{
    static class FoodUtils
    {
        public static void DisplayFoodsOrganized(List<Food> foods)
        {
            var grouped = foods.GroupBy(f => f.GetType().Name);

            foreach (var group in grouped)
            {
                Console.WriteLine($"\n-- {group.Key} --");
                foreach (var food in group)
                {
                    food.DisplayInfo();
                }
            }
        }
    }
}