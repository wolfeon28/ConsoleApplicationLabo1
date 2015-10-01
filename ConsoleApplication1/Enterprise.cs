using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo2
{
    public class Enterprise
    {
        public Enterprise(string name, string loc)
        {
            Name = name;
            Loc = loc;
        }

        public string Loc
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set; 
        }

        public override string ToString()
        {
            return Name + "( " + Loc +" )\n";
        }
    }
}
