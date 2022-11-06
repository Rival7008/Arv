using System;

namespace Arv
{
    internal class Cat : Animal
    {
        protected bool _ShowCat = true;

        public Cat()
        {

        }
        public Cat(string name, string color, string eyecolor, int weight, int legs, bool showCat) : base(name, color, eyecolor, weight, legs)
        {
            _ShowCat = showCat;
        }

        public override string makeSound()
        {
            return $"{_name} purrss.";
        }
        public string ShowOfCat()
        {
            if (_ShowCat)
                return $"{_name} runs around you";
            else
                return $"{_name} scratches you";
        }

    }
}

