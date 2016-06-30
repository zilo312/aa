using System;
using System.Collections.Generic;
using System.Text;

namespace Wrox.ProCSharp.Arrays
{
    public class Racer
    {
        public Racer(string name)
        {
            this.name = name;
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string team;

        public string Team
        {
            get { return team; }
            set { team = value; }
        }
	
    }
}
