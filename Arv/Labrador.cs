

namespace Arv
{
    internal class Labrador : Dog
    {
        protected int _age = 5;

        //Parameterless constructor for creating objects with default values
        public Labrador()
        {

        }

        //Constructor
        public Labrador(string name, string color, string eyecolor, int weight, int legs, bool friendly, int age) : base(name, color, eyecolor, weight, legs, friendly)
        {
            _age = age;
        }

        //Public method which overrides Interact method from class Dog
        public override string Interact()
        {
            if (_age <= 5 && _friendly == true)
                return $"{_name} the bulldog cuddles up to you";
            else if (_age <= 5 && _friendly == false)
                return $"{_name} barks and tries to gnaw your hand off.";
            else
                return $"{_name} is retired and does not interact with you.";
        }
    }
}
