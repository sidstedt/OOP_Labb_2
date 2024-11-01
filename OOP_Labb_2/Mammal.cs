using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb_2
{
    internal abstract class Mammal : Animal
    {
        public bool IsMammal { get; set; } = true;
        public Mammal() { }
        public Mammal(
            string name,
            int age,
            decimal weight,
            bool isDomesticated,
            string gender,
            bool isWild,
            bool isMammal
            )
            : base(name, age, weight, isDomesticated, gender, isWild)
        {
            IsMammal = isMammal;
        }
    }
}
