using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodgerCombat
{

    public class ElderlyHero
    {
        private static Random rng = new Random();

        // Basic stats
        public string Name { get; set; }
        public int Age { get; set; }
        public int Health { get; set; }
        public int Stamina { get; set; }
        public int Strength { get; set; }
        public int Morale { get; set; }
        public string Emotion { get; set; }
        public int DiseaseSeverity { get; set; }

        // Inventory
        public List<Item> Inventory { get; set; }

        // Flavor
        public string Backstory { get; set; }

        // Flags
        public bool LastBattleWon { get; set; }

        // Constructor
        public ElderlyHero(string name, string backstory)
        {
            Name = name;
            Backstory = backstory;

            // Randomize stats
            Health = rng.Next(50, 101); // 50-100
            Stamina = rng.Next(30, 81); // 30-80
            Strength = rng.Next(5, 21); // 5-20
            Morale = rng.Next(40, 101); // 40-100
            DiseaseSeverity = rng.Next(10, 51); // 10-50
            Emotion = "Neutral";

            Inventory = new List<Item>();
            LastBattleWon = false;
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Item(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
