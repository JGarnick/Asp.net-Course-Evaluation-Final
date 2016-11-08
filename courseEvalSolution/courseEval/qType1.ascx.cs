using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using courseEval;

namespace courseEval
{
    public partial class qType1 : System.Web.UI.UserControl
    {
        private string answer;
        private int questionID;
        public Student Student
        {
            get
            {
                object student = Session["Student"];
                if (student != null)
                    return (Student)student;
                else
                    return null;
            }
            set
            {
                Session["Student"] = value;
            }
        }
        public string Answer
        {

            get { return answer; }
            
            set { answer = value; }
           
        }
        public int QuestionID
        {
            get { return questionID; }
            set { questionID = value; }
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (q1.Checked)
                Answer = "1";
            else if (q2.Checked)
                Answer = "2";
            else if (q3.Checked)
                Answer = "3";
            else if (q4.Checked)
                Answer = "4";
            else if (q5.Checked)
                Answer = "5";
            else
                Answer = "-1";
        }
        public void SetQuestionText(string text)
        {
            qText.Text = text;            
        }
        
    }
}
//Need question ID, Answer

//make a switch statement based on the ID of the radio button and return 1