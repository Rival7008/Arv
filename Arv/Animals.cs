using System;

namespace Arv
{
    internal abstract class Animal
    {
        protected string _name = "Default name";
        protected string _color = "Default color";
        protected string _Eyecolor = "Default eyecolor";
        protected int _weight = 100;
        protected int _legs = 4;
        public Animal()
        {

        }

        public Animal(string name, string color, string Eyecolor, int weight, int legs)
        {
            _name = name;
            _color = color;
            _Eyecolor = Eyecolor;
            _weight = weight;
            _legs = legs;
        }
        public abstract string makeSound();

        public string Sleep()
        {
            return _name + "lies down and sleeps";
        }
        public string Eat(string food)
        {
            return $"{_name} eats the {food}";
                   
        }
        public string Run()
        {
            return $"{_name} runs with its {_legs} legs";
        }
    }
}
