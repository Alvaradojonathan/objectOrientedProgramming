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
            Cat mittens = new Cat("kitty",2,"golden");
        }
    }
}
