﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class Person
    {
        private int age;

        public int Age
        {
            get { return age; }
            set {age = (value >0) ? value : 1 ;}
        } 

        public String Name
        {
            get;
            set;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return Name + " âgé de " + Age +" ans "; 
        }

    }
}
