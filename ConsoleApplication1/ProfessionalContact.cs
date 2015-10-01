using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo2
{
    public class ProfessionalContact : Person
    {
        private string job;
        private int jobTelNum;
        private string jobMail;
        private List<Enterprise> listEnt;

        public List<Enterprise> ListEnt
        {
            get { return listEnt; }
            set { listEnt = value; }
        }

        public ProfessionalContact(string name, string lastname, string job, int jobTelNum, string jobMail): base(name, lastname)
        {
            Job = job;
            JobTelNum = jobTelNum;
            JobMail = jobMail;
            ListEnt = new List<Enterprise>();
            
        }

        public void AddEnterprise(Enterprise e)
        {
            ListEnt.Add(e);
        }

        public string Job
        {
            get; 
            set; 
        }

        public int JobTelNum
        {
            get;
            set;
        }

        public string JobMail
        {
            get;
            set; 
        }

        public override string ToString()
        {
            return base.ToString() + " (0" + JobTelNum + ")\n" + Job + "\n" + JobMail + "\n";
        }

        public override bool BirthdayWish()
        {
            return (false);
        }
    }
}
