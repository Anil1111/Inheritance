using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Human
    {
        public string Name { set; get; }
        public int Age { set; get; }
        public virtual Gender Gender { set; get; }
        public virtual double Weight { set; get; }
        public virtual string Info => $"Name: {Name}, Age: {Age}, Gender: {Gender}, Weight: {Weight}";       
    }
    enum Gender
    {
        Male,
        Female
    }
}
