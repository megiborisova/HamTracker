using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CalorieTracker
{
    static class FoodFileManager
    {
        public static void AppendFoodToFile(string filepath, string category, string foodLine)
        {
            var lines = File.Exists(filepath) ? File.ReadAllLines(filepath).ToList() : new List<string>();

            int categoryLineIndex = lines.FindIndex(l => l.Trim().Equals($"#{category}", StringComparison.OrdinalIgnoreCase));

            if (categoryLineIndex == -1)
            {
                // Category not found, add at the end
                lines.Add("");
                lines.Add("#" + category);
                lines.Add(foodLine);
            }
            else
            {
                // Insert food after category line or at the end of category block
                int insertIndex = categoryLineIndex + 1;
                // Insert before next category or end of file
                while (insertIndex < lines.Count && !lines[insertIndex].StartsWith("#"))
                {
                    insertIndex++;
                }
                lines.Insert(insertIndex, foodLine);
            }

            File.WriteAllLines(filepath, lines);
        }
    }
}