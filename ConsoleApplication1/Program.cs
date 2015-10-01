using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            PrivateContact pvt1 = new PrivateContact("Jean", "Louis", 123456789, "JeanLouis@gmail.com");
            PrivateContact pvt2 = new PrivateContact("Jean", "Neige", 987654321, "JeanNeige@gmail.com", DateTime.Today);
            if (pvt2.BirthdayWish())
            {
                System.Console.Write("Bon anniversaire " + pvt2.ToString());
            }
            */
            ProfessionalContact cons1 = new ProfessionalContact("Jean", "Louis", "Consultant", 645825735, "JeanLouis@outlook.com");
            ProfessionalContact cons2 = new ProfessionalContact("Jean", "Neige", "Consultant", 641545735, "JeanNeige@outlook.com");
            ProfessionalContact ind1 = new ProfessionalContact("Jean", "Victor", "Independant", 645824568, "JeanVictor@outlook.com");

            Enterprise ent1 = new Enterprise("Larian Studio", "Gand");
            Enterprise ent2 = new Enterprise("Sony", "L.A.");

            cons1.AddEnterprise(ent1);
            cons1.AddEnterprise(ent2);

            cons2.AddEnterprise(ent1);

            ind1.AddEnterprise(ent2);

            List<ProfessionalContact> listPro = new List<ProfessionalContact>();
            listPro.Add(cons1);
            listPro.Add(cons2);
            listPro.Add(ind1);

            var listInd = from p in listPro 
                          where p.ListEnt.Count() == 1 
                          select p;

            System.Console.Write("Nombre d'indépendants : "+listInd.Count()+ "\n");

            var listCons = listPro.Where(p => (p.ListEnt.Count() > 1));

            System.Console.Write("Nombre de consultants : " + listCons.Count() + "\n");

            System.Console.Read();
        }
    }
}
