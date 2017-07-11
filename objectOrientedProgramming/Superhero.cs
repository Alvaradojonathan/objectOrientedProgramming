using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectOrientedProgramming
{
    class Superhero
    {
        //5 fields
        private string costume;
        private string name;
        private int strengthLvl;
        private string power;
        private bool hasCape;

        //5 properties
        public string Costume
        {
            get { return this.costume; }
            set { this.costume = value; }
        }
        public string Name
        {
            get { return this.name; }
        }
        public int StrengthLvl
        {
            get { return this.strengthLvl; }
            set { this.strengthLvl = value; }
        }
        public string Power
        {
            get { return this.power; }
        }
        public bool HasCape
        {
            get { return this.hasCape; }
            set { this.hasCape = value; }
        }
        //3 constructors
        public Superhero()
        {
            //DEFAULT
        }
        public Superhero(string name)
        {
            this.name = name;
            this.strengthLvl = 100;
        }
        public Superhero(string costume, string name,  int strengthLvl, string power, bool hasCape)
        {
            this.costume = costume;
            this.name = name;
            this.strengthLvl = strengthLvl;
            this.power = power;
            this.hasCape = hasCape;
        }


        //2 methods
    }
}
