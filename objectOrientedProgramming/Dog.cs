using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectOrientedProgramming
{
    class Dog
    {
        private double height;
        private string hairLength;
        private double weight;
        private double runningSpeed;
        private bool isHappy = true;

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
        public double RunningSpeed { get; set; }

        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        public Dog()
        {
            //default
        }

        public Dog(double height, double weight,string hairLength)
        {
            this.height = height;
            this.weight = weight;
            this.hairLength = hairLength;
        }
        public void Run()
        {

        }
        public void Bark()
        {            
            Console.WriteLine("bark");
        }
        public void Potty()
        {

        }
        public void Cuddle()
        {           
            Console.WriteLine("Does he want to cuddle? " + isHappy);
        }
    }
}
