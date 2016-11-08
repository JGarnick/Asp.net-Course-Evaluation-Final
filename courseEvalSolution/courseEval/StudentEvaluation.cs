using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseEval
{
    public class StudentEvaluation
    {
        private Student student;
        private Evaluation evaluation;
        private DateTime completionDate = DateTime.MinValue;
        private Dictionary<int, string> answers;
        List<Question> questions;
        private int id;

        public StudentEvaluation(Student s, Evaluation e)
        {
            student = s;
            evaluation = e;
            answers = new Dictionary<int, string>();
            questions = evaluation.GetQuestions();
        }

        public bool IsComplete
        {
            get
            {
                return (completionDate != DateTime.MinValue);
            }
        }

        public void AddAnswer(int questionNumber, string answer)
        {
            if (!IsComplete)
            {
                if (questions.FindIndex(q => q.ID == questionNumber) != -1)
                {
                    if (answers.ContainsKey(questionNumber))
                        answers[questionNumber] = answer;
                    else
                        answers.Add(questionNumber, answer);
                }
            }
            else
                throw new Exception("Evaluation has already been submitted.");
        }

        public void Submit()
        {
            if (!IsComplete)
            {
                Random rnd = new Random();
                id = rnd.Next(1, Int32.MaxValue);
                completionDate = DateTime.Now;
                // this should also record that the evaluation was submitted
                // and save all of the answers to the database.  That will happen in a later lab.
            }
            else
                throw new Exception("Evaluation has already been submitted.");
        }
    }
}
