using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodgerCombat
{
    public class Elder : Character
    {
        public Elder(string name, int age, int strength, int speed) : base(name, age, strength, speed)
        {
            string Disease = "Dementia";
        }

        public override void Speak()
        {
            Console.WriteLine("Eh? Speak up, sonny");
        }
    }
}
