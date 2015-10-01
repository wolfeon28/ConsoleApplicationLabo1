using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class Pupil : Person
    {
        private int grade;

        public Pupil(string name, int age, int grade) : base(name,age)
        {
            Grade = grade;
            //ListActivities = new List<Activity>();
            //pupilEvaluations = new char[Parameter.DIX];
        }

        public Pupil(string name ,int age) : this(name,age,1)
        { 
        }

       /* public void AddActivity(Activity activity)
        {
            ListActivities.Add(activity);
        }

        public void AddEvaluation(String title = null, char evaluation =(char)Parameter.Eval.S)
        {
            int i = 0;
            if (title != null)
            {
                if (ListActivities.Count() != 0)
                {
                    foreach (Activity activity in ListActivities)
                    {
                        if (activity.Title.Equals(title)) break;
                        i++;
                    }
                    pupilEvaluations[i] = evaluation;
                }
                else
                {
                    System.Console.Write("Aucune activité choisie par l'élève.");
                }
            }
        }
        */
        public override string ToString()
        {
            string ch = Header();
            ch = PrintCourses(ch);
            return ch ;
        }

       /* private string PrintActivities(string ch)
        {
            int i;
            for (i = 0; i < ListActivities.Count(); i++)
            {
                ch += ListActivities[i].ToString() + "\n";
            }
            return ch;
        }
        
        private string Header()
        {
            return base.ToString() + ((ListActivities.Count() != 0) ? "a choisi :\n" : "n’a pas encore choisi d’activité\n");
        }

        */
        public int Grade
        {
            get { return grade; }
            set { grade = (value > 0) ? value : 1; }
        }

       /* public char[] pupilEvaluations
        {
            get;
            set;
        }
        
       public List<Activity> ListActivities
        {
            get;
            set;
        }
        */
private Dictionary<String, char> pupilActivities= new Dictionary<String, char>();

public Dictionary<String, char> PupilActivities
{

    get { return pupilActivities; }
    set { pupilActivities= value; }

}

public void AddActivity(String activityTitle)

{

    PupilActivities.Add(activityTitle, '0');
}
public void AddEvaluation(String title = null, char evaluation='S')
{


    if (title != null)
    PupilActivities [title] = evaluation;
}

private string PrintCourses(string ch)
{
    int i;
    for(i=0;i<PupilActivities.Count();i++)
    ch += "\n" + PupilActivities.ElementAt(i).Key.ToString() + " : "+ PupilActivities.ElementAt(i).Value ;
    return ch;
}

private string Header()

{
    return base.ToString() + ((PupilActivities.Count() != 0) ? " a choisi ...\n" :" n’a pas encore choisi,d’activité\n");
}
    }
}