using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseEval
{
    public class Question
    {
        private int id;
        private int qType;
        private string qText;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int QType
        {
            get { return qType; }
            set { qType = value; }
        }

        public string Text
        {
            get { return qText; }
            set { qText = value; }
        }

        public Question(int id, int qtype, string text)
        {
            this.id = id;
            this.qType = qtype;
            this.qText = text;
        }
    }
}
