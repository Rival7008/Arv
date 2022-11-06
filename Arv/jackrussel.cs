
namespace Arv
{
    internal class Jackrussel : Dog
    {
        protected string _language = "Default";

        public Jackrussel()
        {

        }

        public Jackrussel(string name, string color, string eyecolor, int weight, int legs, bool friendly, string language) : base(name, color, eyecolor, weight, legs, friendly)
        {
            _language = language;
        }

        public override string makeSound()
        {
            return $"{_name} barks in {_language}";
        }
    }
}
