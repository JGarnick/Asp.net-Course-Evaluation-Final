using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace courseEval
{
    public partial class qType2 : System.Web.UI.UserControl
    {
        private string answer;
        private int questionID;
        public string Answer
        {
            get
            {
                return answer;
            }
            set
            {
                answer = value;
            }
        }
        public int QuestionID
        {
            get { return questionID; }
            set { questionID = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Answer = textResponse.Value;
        }
        public void SetQuestionText(string text)
        {
            qText.Text = text;
        }
    }
}