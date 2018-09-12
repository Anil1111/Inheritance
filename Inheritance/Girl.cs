using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Girl : Human
    {
        public override Gender Gender
        {
            get
            {
                return Gender.Female;
            }
        }
        public override double Weight
        {
            get
            {
                return base.Weight - 5;
            }
        }
        public Cosmetics Cosmetics { set; get; }
        public override string Info => $"Name: {Name}, Age: {Age}, Gender: {Gender}, Weight: {Weight}, Favourite Cosmetics: {Cosmetics}";
    }

    enum Cosmetics
    {
        MAC,
        Loreal,
        Essence,
        Dior,
        Sephora,
        Other
    }
}
