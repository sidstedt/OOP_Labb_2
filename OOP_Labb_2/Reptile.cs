using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Labb_2
{
    internal abstract class Reptile : Animal
    {
        public bool IsColdBlood { get; set; } = true;
        public Reptile() { }
        public Reptile(
            string name,
            int age,
            decimal weight,
            bool isDomesticated,
            string gender,
            bool isWild,
            bool isColdBlood
            )
            : base(name, age, weight, isDomesticated, gender, isWild)
        {
            IsColdBlood = isColdBlood;
        }
    }
    class Snake : Reptile
    {
        public bool ForkedTongue { get; set; } = true;
        public Snake() { }
        public Snake(
            string name, 
            int age,
            decimal weight,
            bool isDomesticated,
            string gender,
            bool isWild,
            bool isColdBlood,
            bool forkedTongue
            ) 
            : base(name, age, weight, isDomesticated, gender, isWild, isColdBlood)
        {
            ForkedTongue = forkedTongue;
        }
        public override string MakeSound()
        {
            return $"{Name} hisses at Harry Fötter!";
        }
    }
}
