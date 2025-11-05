using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodgerCombat
{
    public class Character
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Health { get; set; } = 100;
        public int Strength { get; set; }
        public int Speed { get; set; }

        public Character(string name, int age, int strength, int speed)
        {
            Name = name;
            Age = age;
            Strength = strength;
            Speed = speed;
        }

        public virtual void Attack(Character target)
        {
            int damage = Strength / 2;
            target.TakeDamage(damage);
            Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage!");
        }

        public void TakeDamage(int amount)
        {
            Health -= amount;
            if (Health < 0) Health = 0;
            Console.WriteLine($"{Name} now has {Health} health.");
        }

        public virtual void Speak()
        {
            Console.WriteLine($"{Name}: Ready for battle!");
        }
    }
}

