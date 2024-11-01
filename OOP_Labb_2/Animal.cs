using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb_2
{
    // Making it abstract as not to instanciate it
    internal abstract class Animal
    {
        // get seters with default values
        public string Name { get; set; } = "unknown";
        public int Age { get; set; } = 0;
        public decimal Weight { get; set; } = 0.0m;
        public bool IsDomesticated { get; set; } = false;
        public string Gender { get; set; } = "N/A";
        public bool IsWild { get; set; } = true;
        public Animal() { }
        public Animal(
            string name,
            int age,
            decimal weight,
            bool isDomesticated,
            string gender,
            bool isWild
            )
        {
            Name = name;
            Age = age;
            Weight = weight;
            IsDomesticated = isDomesticated;
            Gender = gender;
            IsWild = isWild;
        }
        public string Poo()
        {
            return $"{Name} is pooing.";
        }
        public string Eat()
        {
            return $"{Name} eats food.";
        }
        public virtual string MakeSound()
        {
            return $"{Name} is making a sound.";
        }
    }
}
