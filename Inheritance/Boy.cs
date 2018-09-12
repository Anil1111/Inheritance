using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Boy : Human
    {
        public override Gender Gender
        {
            get
            {
                return Gender.Male;
            }
        }
        public override double Weight
        {
            get
            {
                return base.Weight;
            }
        }
        public FavouriteCar FavCar { set; get; }
        public override string Info => $"Name: {Name}, Age: {Age}, Gender: {Gender}, Weight: {Weight}, Favourite Car: {FavCar}";
    }

    enum FavouriteCar
    {
        BMW,
        Nissan,
        Audi,
        Opel,
        Mersedes,
        Lamborghini,
        Tayota,
        Other
    }



}

