using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb_2
{
    internal class Human : Mammal
    {
        public bool HomoSapiens { get; set; } = true;
        public string Occupation { get; set; } = "N/A";
        public Human() { }
        public Human(
            string name,
            int age,
            decimal weight,
            bool isDomesticated,
            string gender,
            bool isWild,
            bool isMammal,
            bool homoSapiens,
            string occupation
            )
            : base(name, age, weight, isDomesticated, gender, isWild, isMammal)
        {
            HomoSapiens = homoSapiens;
            Occupation = occupation;
        }
        public override string MakeSound()
        {
            return $"The human {Name} tjötar på!";
        }
    }
}
