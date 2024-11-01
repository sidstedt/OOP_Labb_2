using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb_2
{
    internal class Horse : Mammal
    {
        public bool IsRaceHorse { get; set; } = false;
        public Horse() { }
        public Horse(string name,
            int age, 
            decimal weight, 
            bool isDomesticated,
            string gender,
            bool isWild,
            bool isMammal,
            bool isRaceHorse
            )
            : base(name, age, weight, isDomesticated, gender, isWild, isMammal)
        {
            IsRaceHorse = isRaceHorse;
        }
        public override string MakeSound()
        {
            if (IsRaceHorse)
            {
                return $"The horse {Name} neighs!";
            }
            else
            {
                return $"The horse {Name} shrieks out loud!";
            }
        }
    }
}
