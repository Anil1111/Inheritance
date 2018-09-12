using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Human man = new Human
            {
                Name = "Jack",
                Age = 20,
                Weight = 50,
                Gender = Gender.Male
            };
            Girl girl = new Girl
            {
                Name = "Mary",
                Age = 18,
                Weight = 70,
                Cosmetics = Cosmetics.MAC
            };
            Boy boy = new Boy
            {
                Name = "Paul",
                Age = 15,
                Weight = 70,
                FavCar = FavouriteCar.BMW
            };
            Console.WriteLine(man.Info);
            Console.WriteLine(girl.Info);
            Console.WriteLine(boy.Info);
            Console.ReadLine();

        }
    }
}
