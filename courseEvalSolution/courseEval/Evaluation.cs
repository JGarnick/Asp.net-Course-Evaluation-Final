using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseEval
{
    public class Evaluation
    {
        private int id;
        private string courseNumber;
        private DateTime startDate;
        private DateTime endDate;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string CourseNumber
        {
            get { return courseNumber; }
            set { courseNumber = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public Evaluation(int id, string course, DateTime start, DateTime end)
        {
            this.id = id;
            courseNumber = course;
            startDate = start;
            endDate = end;
        }

        public List<Question> GetQuestions()
        {
            List<Question> allQuestions = new List<Question>();
            List<Question> evalQuestions;
            allQuestions.Add(new Question(1, 1, 
                "What was taught agreed with the objectives stated in the catalog or course outline"));
            allQuestions.Add(new Question(2, 1,
                "The instructor exhibited an enthusiasm and interest in the subject."));
            allQuestions.Add(new Question(3, 1,
                "The instructor was knowledgeable in the subject."));
            allQuestions.Add(new Question(4, 1,
                "The instructor used class time effectively."));
            allQuestions.Add(new Question(5, 1,
                "The instructor respected people including those of different genders, religions, ethnic backgrounds, class status, abilities and lifestyles"));
            allQuestions.Add(new Question(6, 1,
                "The instructor encouraged students to think."));
            allQuestions.Add(new Question(7, 1,
                "The instructor's teaching methods were effective in helping me learn the material."));
            allQuestions.Add(new Question(8, 1,
                "The instructor made an effort to be available to students."));
            allQuestions.Add(new Question(9, 1,
                "The instructor helped students understand the course material and find answers to relevant questions."));
            allQuestions.Add(new Question(10, 1,
                "The instructor treated students fairly and reasonably"));
            allQuestions.Add(new Question(11, 2, "What did you like about this class?"));
            allQuestions.Add(new Question(12, 2, "How could this class be improved?"));

            switch (id)
            {
                case 1:
                    evalQuestions = allQuestions.Where(q => (q.ID % 2 == 0)).ToList();
                    break;
                case 2:
                    evalQuestions = allQuestions.Where(q => (q.ID % 2 == 1)).ToList();
                    break;
                default:
                    evalQuestions = allQuestions;
                    break;
            }
            return evalQuestions;
        }


    }
}
