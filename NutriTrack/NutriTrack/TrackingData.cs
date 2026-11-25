using System;
using System.Collections.Generic;
using System.Linq;
namespace NutriTrack
{
    // Shared session data. Sample entries reproduce the original dashboard.
    internal static class TrackingData
    {
        internal record Meal(string Name, string Type, DateTime Date, decimal Calories, decimal Protein, decimal Carbs, decimal Fat);
        internal static readonly List<Meal> Meals = new()
        {
            new("Oatmeal Bowl", "Breakfast", DateTime.Today, 450, 15, 60, 12),
            new("Grilled Chicken Salad", "Lunch", DateTime.Today, 600, 45, 65, 18),
            new("Yogurt & Granola", "Snack", DateTime.Today, 400, 22, 55, 15)
        };
        internal static readonly SortedDictionary<DateTime, decimal> Weights = new()
        {
            [DateTime.Today.AddDays(-28)] = 69m, [DateTime.Today.AddDays(-21)] = 68.9m,
            [DateTime.Today.AddDays(-14)] = 68.8m, [DateTime.Today.AddDays(-7)] = 68.4m,
            [DateTime.Today] = 68.5m
        };
        // Water is recorded separately from meals, in millilitres, by date.
        internal static readonly Dictionary<DateTime, int> WaterRecords = new()
        {
            [DateTime.Today] = 1500
        };
        internal const int WaterGoalMl = 2500;
        internal static int WaterTodayMl => WaterRecords.TryGetValue(DateTime.Today, out int ml) ? ml : 0;
        internal static int WaterPercent => (int)Math.Round(100m * WaterTodayMl / WaterGoalMl, MidpointRounding.AwayFromZero);
        internal static void LogWater(int ml)
        {
            if (ml <= 0) throw new ArgumentOutOfRangeException(nameof(ml));
            WaterRecords[DateTime.Today] = checked(WaterTodayMl + ml);
        }
        internal static int CalorieGoal = 2000;
        internal static decimal WeightGoal = 65m, Height = 165m;
        internal static IEnumerable<Meal> Today => Meals.Where(m => m.Date.Date == DateTime.Today);
        internal static decimal Calories => Today.Sum(m => m.Calories);
        internal static decimal Protein => Today.Sum(m => m.Protein);
        internal static decimal Carbs => Today.Sum(m => m.Carbs);
        internal static decimal Fat => Today.Sum(m => m.Fat);
        internal static int MacroPercent(decimal grams, decimal goal) =>
            (int)Math.Round(100m * grams / goal, MidpointRounding.AwayFromZero);
        internal static int MacroScale
        {
            get
            {
                int highest = Math.Max(MacroPercent(Protein, 120m),
                    Math.Max(MacroPercent(Carbs, 250m), MacroPercent(Fat, 70m)));
                return Math.Max(100, (int)(Math.Ceiling(highest / 100m) * 100));
            }
        }
        internal static int Percent => (int)(100 * Calories / CalorieGoal);
        internal static string Remaining => Calories <= CalorieGoal ? $"{CalorieGoal - Calories:N0} kcal remaining today" : $"{Calories - CalorieGoal:N0} kcal over goal";
        internal static decimal Start => Weights.First().Value;
        internal static decimal Current => Weights.Last().Value;
        internal static decimal Change => Current - Start;
        internal static KeyValuePair<DateTime,decimal>[] WeightPeriod(int days) => Weights.Where(w => w.Key >= DateTime.Today.AddDays(1-days) && w.Key <= DateTime.Today).ToArray();
    }
}
