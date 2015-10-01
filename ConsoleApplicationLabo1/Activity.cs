using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class Activity
    {
        public string Title
        {
            get;
            set;
        }

        public Boolean Compulsory
        {
            get;
            set;
        }

        public Activity(string title, Boolean compulsory)
        {
            Title = title;
            Compulsory = compulsory ;

        }

        public override string ToString()
        {
            if (Compulsory)
            {
                return Title + " ( obligatoire ).";
            }
            else
            {
                return Title + "( non-obligatoire ).";
            }
        }


    }
}
