using System;

namespace Arv
{
    internal class Dog : Animal
    {
        protected bool _friendly = true;

        public Dog()
        {

        }
        public Dog(string name, string color, string eyecolor, int weight, int legs, bool friendly) : base(name, color, eyecolor, weight, legs)
        {
            _friendly = friendly;
        }

        public override string makeSound()
        {
            return $"{_name} barks.";
        }
        public virtual string Interact()
        {
            if (_friendly)
                return $"{_name} lays down next to you";
            else
                return $"{_name} barks and tries to bite you";
        }

    }
}

