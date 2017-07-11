using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectOrientedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating: Initializing a new object or creating a new instance.
            //Objects need to be instantiated before use
            //All objects of a specific type are created from the same template/Class.
            //Each object instance has unique values.

            //Instantiating format:
            //ClassName objectName = new ClassName();


            Superhero firstHero = new Superhero();
            //firstHero.StrengthLvl = 100;
            //firstHero.HasCape = true;

            //firstHero.BattleNemessis();
            //Console.WriteLine(firstHero.HasCape);
            //Console.WriteLine(firstHero.StrengthLvl);

            //firstHero.BattleNemessis();
            //Console.WriteLine(firstHero.HasCape + firstHero.Costume);
            //Console.WriteLine(firstHero.StrengthLvl);

            Superhero secondHero = new Superhero("Diamond Daniel");
            //Console.WriteLine(secondHero.StrengthLvl);

            //secondHero.AllyGained();
            //Console.WriteLine(secondHero.StrengthLvl);

            Superhero thirdHero = new Superhero("black Kevlar body armor", "The Best Ever", 1000, "Being the best!", false );
            thirdHero.BattleNemessis();
            Console.WriteLine("Oh no! My costume is {0} and my strength has diminished to {1}.", thirdHero.Costume, thirdHero.StrengthLvl);





            //Cat kitty = new Cat("kitty",2,"golden");
            //Cat oz = new Cat();
            //kitty.Name = "Oz";
            //Console.WriteLine(kitty.Name);
            //Console.WriteLine(kitty.Age);
            //kitty.Eat();
            //Dog sparky = new Dog(2.3, 15, "short");
            //Console.WriteLine("Height: " + sparky.Height + "\nHair Length: " + sparky.HairLength);
            //sparky.Bark();
            //sparky.Cuddle();
        }
    }
}
