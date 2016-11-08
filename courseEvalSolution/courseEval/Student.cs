using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseEval
{
    public class Student
    {
        private int id;
        private string lNumber;
        private string password;

        public int ID
        {
            get
            {
                return id;
            }
        }
        public string LNumber
        {
            get 
            { 
                return lNumber; 
            }
        }
        public string Password
        {
            get 
            { 
                return password; 
            }
        }

        public Student(int id, string lnum, string pwd)
        {
            this.id = id;
            lNumber = lnum;
            password = pwd;
        }

        public static Student Login(string lnum, string pwd)
        {
            if (lnum == "L00000001" && pwd == "Student1")
                return new Student(1, lnum, pwd);
            else if (lnum == "L00000002" && pwd == "Student2")
                return new Student(2, lnum, pwd);
            else if (lnum == "L00000003" && pwd == "Student3")
                return new Student(2, lnum, pwd);
            else
                return new Student(-1, lnum, pwd);
        }

        public List<Evaluation> GetEvaluations()
        {
            List<Evaluation> allEvals = new List<Evaluation>();
            List<Evaluation> studentEvals;
            allEvals.Add(new Evaluation(1, "CS 295N", new DateTime(2015, 10, 1), new DateTime(2015, 12, 1)));
            allEvals.Add(new Evaluation(2, "CS 234N", new DateTime(2015, 10, 1), new DateTime(2015, 12, 1)));
            allEvals.Add(new Evaluation(3, "CS 296N", new DateTime(2015, 10, 1), new DateTime(2015, 12, 1)));
            allEvals.Add(new Evaluation(4, "CS 133N", new DateTime(2015, 10, 1), new DateTime(2015, 12, 1)));

            switch (id)
            {
                case 1:
                    studentEvals = allEvals.Where(e => (e.ID % 2 == 1)).ToList();
                    break;
                case 2:
                    studentEvals = allEvals.Where(e => (e.ID < 4)).ToList();
                    break;
                default:
                    studentEvals = allEvals.Where(e => (e.ID == 4)).ToList();
                    break;
            }
            return studentEvals;
        }
    }
}
