using System;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog DefaultDog = new Dog();
            Dog dogOzzie = new Dog("Ozzie", "Black", "White", 5, 4, false);
            Jackrussel dogGizmo = new Jackrussel("Gizmo", "White", "Black", 5, 4, true, "swedish");
            Labrador dogZigge = new Labrador("Zigge", "Black", "White", 20, 4, true, 2);
            Cat defaultCat = new Cat();
            Cat catÅke = new Cat("Åke", "Orange", "White", 5, 4, true);
            Cat catMjau = new Cat("Mjau", "Black", "White", 4, 4, true);
            Monkey defaultMonkey = new Monkey();
            Monkey monkeyMama = new Monkey("Mama", "Black", "White", 50, 4, 80);
            Monkey monkeyPapa = new Monkey("Papa", "Black", "White", 60, 4, 70);

            Console.WriteLine(DefaultDog.Run());
            Console.WriteLine(dogOzzie.Eat("Dogfood"));
            Console.WriteLine(dogOzzie.makeSound());
            Console.WriteLine(dogGizmo.Interact());
            Console.WriteLine(dogGizmo.makeSound());
            Console.WriteLine(dogZigge.makeSound());
            Console.WriteLine(defaultCat.makeSound());
            Console.WriteLine(catÅke.makeSound());
            Console.WriteLine(catÅke.ShowOfCat());
            Console.WriteLine(catMjau.ShowOfCat());
            Console.WriteLine(monkeyMama.makeSound());
            Console.WriteLine(monkeyMama.AddNumbers(10, 5));
            Console.WriteLine(monkeyPapa.makeSound());
            Console.WriteLine(monkeyPapa.AddNumbers(10, 5));
        }
    }
}
