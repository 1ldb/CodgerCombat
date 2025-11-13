using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodgerCombat
{
    public static class DisplayHelper
    {
        public static void ShowHeroStats(ElderlyHero hero)
        {
            Console.WriteLine($"Name: {hero.Name}");
            Console.WriteLine($"Age: {hero.Age}");
            Console.WriteLine($"Health: {hero.Health}");
            Console.WriteLine($"Stamina: {hero.Stamina}");
            Console.WriteLine($"Strength: {hero.Strength}");
            Console.WriteLine($"Morale: {hero.Morale}");
            Console.WriteLine($"Emotion: {hero.Emotion}");
            Console.WriteLine($"Disease Severity: {hero.DiseaseSeverity}");
            Console.WriteLine($"Backstory: {hero.Backstory}");
            Console.WriteLine("Inventory: " + (hero.Inventory.Count == 0 ? "Empty" : string.Join(", ", hero.Inventory.Select(i => i.Name))));
        }
    }

}
