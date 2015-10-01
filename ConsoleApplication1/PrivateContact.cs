using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo2
{
   public class PrivateContact : Person
    {
        private int privateTelNum;
        private string mail;
        private DateTime birthdate;

        public PrivateContact(string name, string lastname, int privateTelNum, string mail, DateTime birthdate): this(name, lastname, privateTelNum, mail)
        {
            Birthdate = birthdate;
        }

        public PrivateContact(string name, string lastname, int privateTelNum, string mail): base(name,lastname)
        {
            PrivateTelNum = privateTelNum;
            Mail = mail;
        }

        public int PrivateTelNum
        {
            get { return privateTelNum; }
            set { privateTelNum = value; }
        }

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public DateTime Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " (0" + PrivateTelNum + ")\n" + Mail + "\n"; 
        }

        public override bool BirthdayWish()
        {
            return(DateTime.Today.Month == Birthdate.Month &&  DateTime.Today.Day == Birthdate.Day);
        }
    }
}
