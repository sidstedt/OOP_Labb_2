using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb_2
{
    internal class Cat : Mammal
    {
        public bool Whiskers { get; set; } = true;
        public Cat() { }
        public Cat(
            string name, 
            int age, 
            decimal weight, 
            bool isDomesticated, 
            string gender, 
            bool isWild,
            bool isMammal,
            bool whiskers
            )
            : base(name, age, weight, isDomesticated, gender, isWild, isMammal)
        {
            Whiskers = whiskers;
        }
        public override string MakeSound()
        {
            return $"The cat {Name} is purring!";
        }
    }
}
