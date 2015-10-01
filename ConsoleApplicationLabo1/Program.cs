using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Pupil pupil;
            List<Pupil> listPupil = new List<Pupil>()
            {
                new Pupil("Squall", 7, 1),
                new Pupil("Lolita", 5, 1),
            };
            Activity act1, act2, act3;

            pupil = new Pupil("Leon", 6, 1);
            act1 = new Activity("Gaming", true);
            act2 = new Activity("Sleeping", true);
            act3 = new Activity("Working", false);

            pupil.AddActivity(act1);
            pupil.AddActivity(act2);
            pupil.AddActivity(act3);
            pupil.AddEvaluation("Gaming");
            listPupil.Add(pupil);

            var pupilGrade1Plus6 = from p in listPupil
                                   where p.Age > 6 && p.Grade == 1
                                   select p;
            */

            /*var pupilGrade1Plus6 = listPupil.Where(p => p.Age > 6 && p.Grade == 1);
            foreach(var p in pupilGrade1Plus6)
            {
                System.Console.Write(p);
            }
            */
            //System.Console.Write(pupil);


            List <Pupil> listPupilsDuplicated= new List <Pupil>()
            {
                new Pupil("Leonidas",21,2),
                new Pupil("Leonidas",21,3),
                new Pupil("Leonk",22,2),
            };
            /*
            List<Person> listPersons = new List<Person>()
            {
                new Person("Jhon", 32),
                new Person("Sabrina", 54),
            };

            var listFusion = listPersons.Union(listPupils);

            foreach (var p in listFusion)
            {
                System.Console.Write(p.Name+"\n");
            }
            */
            IEnumerable<Pupil> listPupilsNoDuplicated = listPupilsDuplicated.Distinct<Pupil>(new PersonComparer());
            System.Console.Write("" + listPupilsNoDuplicated.Count()+"\n");

            foreach (var p in listPupilsNoDuplicated)
            {
                System.Console.Write(p.Name + "\n");
            }

            System.Console.Read();

        }
    }
}
