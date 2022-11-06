namespace Arv
{
    internal class Monkey : Animal
    {
    protected int _iq = 50;

    //Parameterless constructor for creating objects with default values
        public Monkey()
        {

        }

    //Constructor
        public Monkey(string name, string color, string eyecolor, int weight, int legs, int iq) : base(name, color, eyecolor, weight, legs)
        {
            _iq = iq;
        }

        //Method to return monkey sound in string form
        public override string makeSound()
        {
            return $"{_name} screeches in a monkeylike manor.";
        }

        public string AddNumbers(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            if (_iq <= 50)
                return $"{_name} scratches its head and eats a banana.";
            else
                return $"{_name} says in a fancy english accent: It is {sum} my dear fellow, can you give me a real problem next time old chap?";
        }
    }

    //Method for Monkey object to add two integers and return string answer
    
}
