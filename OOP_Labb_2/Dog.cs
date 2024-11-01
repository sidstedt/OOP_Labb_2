using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb_2
{
    internal class Dog : Mammal
    {
        public string FavoriteToy { get; set; } = "N/A";
        public Dog() { }
        public Dog(
            string name,
            int age,
            decimal weight,
            bool isDomesticated,
            string gender,
            bool isWild,
            bool isMammal,
            string favoriteToy
            )
            : base(name, age, weight, isDomesticated, gender, isWild, isMammal)
        {
            FavoriteToy = favoriteToy;
        }
        public override string MakeSound()
        {
            return $"The dog {Name} is barking!";
        }
    }
    class Chihuahua : Dog
    {
        public bool Tiny { get; set; } = true;
        public Chihuahua() { }
        public Chihuahua(
            string name,
            int age,
            decimal weight,
            bool isDomesticated,
            string gender,
            bool isWild,
            bool isMammal,
            string favoriteToy,
            bool tiny
            )
            : base(name, age, weight, isDomesticated, gender, isWild, isMammal, favoriteToy)
        {
            Tiny = tiny;
        }
        public override string MakeSound()
        {
            return base.MakeSound() + " But it can't be heard!";
        }
    }
    class Rottweiler : Dog
    {
        public bool Big { get; set; } = true;
        public Rottweiler() { }
        public Rottweiler(
            string name, 
            int age, 
            decimal weight,
            bool isDomesticated, 
            string gender, 
            bool isWild,
            bool isMammal,
            string favoriteToy,
            bool big
            )
            : base(name, age, weight, isDomesticated, gender, isWild, isMammal, favoriteToy)
        {
            Big = big;
        }
        public override string MakeSound()
        {
            return base.MakeSound() + " And it makes your eardrum burst!";
        }
    }
}
