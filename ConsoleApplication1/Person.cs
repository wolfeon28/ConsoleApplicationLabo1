using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo2
{
    public abstract class Person
    {


        public Person(string name, string lastname)
        {
            Name = name;
            Lastname = lastname;

        }

        public abstract bool BirthdayWish();

        public string Name
        {
            get;
            set; 
        }

        public string Lastname
        {
            get;
            set;
        }

        public override string ToString()
        {
            return Name + " " + Lastname; 
        }

        
    }
}
