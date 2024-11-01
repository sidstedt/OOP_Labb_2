using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb_2
{
    internal class Plant
    {
        public string Species { get; set; } = "N/A";
        public Plant(string species)
        {
            Species = species;
        }
    }
    class Tree : Plant
    {
        public int Height { get; set; } = 0;
        public Tree(
            string species,
            int height
            ) 
            : base (species)
        {
            Height = height;
        }
        public virtual string Photosynthesize()
        {
            return $"{Species} is taking in sunlight for photosynthesizing!";
        }
    }
    class NeedleTree : Tree
    {
        public bool HasNeedles { get; set; } = true;
        public NeedleTree(
            string species,
            int height,
            bool hasNeedles
            )
            : base(species, height)
        {
            HasNeedles = hasNeedles;
        }
        public override string Photosynthesize()
        {
            return $"{Species}-tree with needles is photosynthesizing!";
        }
    }
    class BroadLeafTree : Tree
    {
        public bool ShedLeavesInAutumn { get; set; } = true;
        public BroadLeafTree(
            string species,
            int height,
            bool shedLeavesInAutumn
            )
            : base(species, height)
        {
            ShedLeavesInAutumn = shedLeavesInAutumn;
        }
        public override string Photosynthesize()
        {
            return $"{Species}-tree with broadleaf is photosynthesizing!";
        }
    }
}
