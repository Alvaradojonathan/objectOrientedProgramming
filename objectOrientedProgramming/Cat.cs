using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectOrientedProgramming
{
    class Cat
    {
        //Object blueprint for OOP. Named using Pascal case.

        //In OOp there are two types of states...
        //fields
        //properties - A sort of mix between a field and a method that allow controlled access

        //...and behaviors
        //Methods - repeatabale/reusable sections of code - Actions
        //constructors - specialized methods that are used when instanting an object.

        //Building a class

        //Field
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;

        //Property
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
        }

        //Constructor
        public Cat()
        {
            //Default constructors take no arguments or parameters.
        }

        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }
        public void Eat()
        {
            if (isHungry)
            {
                isHungry = false;
            }
            Console.WriteLine("Is this cat hungry?" + isHungry);
        }


    }
}
