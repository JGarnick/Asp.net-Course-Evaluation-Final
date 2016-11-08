using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace courseEval
{
    public partial class EvaluationPage : System.Web.UI.Page
    {
        private Student user;
        private Evaluation evaluation;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Student"] == null)
            {                
                Response.Redirect("Login.aspx");
            }
            else
                user = (Student)Session["Student"];
            
            Student student = new Student(user.ID, user.LNumber, user.Password);
            
            if(!IsPostBack)
            {
                questionSelect.DataSource = student.GetEvaluations(); //returns list of evaluations for student
                questionSelect.DataTextField = "courseNumber";
                questionSelect.DataValueField = "ID";
                questionSelect.DataBind();
            }
            if(IsPostBack)
            {
                Submit_Logic();
                if (questionSelect.Items.Count == 0)
                {
                    Session["finished"] = true;
                    Response.Redirect("~/Login.aspx");
                }
                    
            }
        }
        //protected void Page_Init(object sender, EventArgs e) //Trying to get submit button to accept the submitBtn_Click event unsuccessfully
        //{
        //    Button submit = new Button();
        //    submit.Text = "Submit Evaluation";
        //    submit.CssClass = "btn btn-warning";
        //    submit.ID = "submitBtn";
        //    submit.Click += new EventHandler(submitBtn_Click);
        //    testForm.Controls.AddAt(testForm.Controls.Count, submit); //Sets it at the bottom of the form
        //}

        protected void getQuestionsBtn_Click(object sender, EventArgs e)
        {
            List<Question> type1;
            List<Question> type2;
            List<Question> allQuestions;
            evaluation = new Evaluation(int.Parse(questionSelect.SelectedItem.Value), questionSelect.SelectedItem.Text, 
                Convert.ToDateTime("01/01/2016"), Convert.ToDateTime("01/02/2016"));
            Session["evaluation"] = evaluation;
            allQuestions = evaluation.GetQuestions();
            type1 = allQuestions.Where(q => q.QType == 1).ToList();
            type2 = allQuestions.Where(q => q.QType == 2).ToList();

            //Dynamically creating controls and adding them to the form
            for (int i = 0; i < type1.Count; i++)
            {
                qType1 c1 = (qType1)LoadControl("~/qType1.ascx");                
                c1.ID = "q1" + i;
                testForm.Controls.AddAt(testForm.Controls.Count - 2, c1);
                
                if (i == type1.Count -1)
                {
                    for (int y = 0; y < type2.Count; y++)
                    {
                        qType2 c2 = (qType2)LoadControl("~/qType2.ascx");
                        c2.ID = "q2" + y;
                        testForm.Controls.AddAt(testForm.Controls.Count - 2, c2);
                    }
                    //CreateSubmitButton();
                    submitBtn.Visible = true;
                }
            }
            SetType1Questions(type1);
            SetType2Questions(type2);
            Session["form"] = testForm;
    
        }
        //private void CreateSubmitButton() //This could take string parameters, but I don't need that right now
        //{
        //    Button submit = new Button();
        //    submit.Text = "Submit Evaluation";
        //    submit.CssClass = "btn btn-warning";
        //    submit.ID = "submitBtn";
        //    submit.Click += new EventHandler(submitBtn_Click); //Could not get this event handler to fire
        //    testForm.Controls.AddAt(testForm.Controls.Count, submit); //Sets it at the bottom of the form
        //    Session["submit"] = submit;
        //}
        protected void submitBtn_Click(object sender, EventArgs e)
        {
            //Just need the page to reload
            Session["evaluation"] = null;
            
        }
        protected void Submit_Logic()
        {
            if (Session["evaluation"] != null)
            {
                StudentEvaluation studentEvaluation = new StudentEvaluation(user, (Evaluation)Session["evaluation"]);
                System.Web.UI.HtmlControls.HtmlForm newForm = (System.Web.UI.HtmlControls.HtmlForm)Session["form"];

                foreach (qType1 qt1 in newForm.Controls.OfType<qType1>())
                {
                    studentEvaluation.AddAnswer(qt1.QuestionID, qt1.Answer);
                }
                foreach (qType2 qt2 in newForm.Controls.OfType<qType2>())
                {
                    studentEvaluation.AddAnswer(qt2.QuestionID, qt2.Answer);
                }
                studentEvaluation.Submit();
                if (studentEvaluation.IsComplete)
                {
                    Label successLabel = new Label();
                    successLabel.Text = "Form was submitted successfully!";
                    successLabel.CssClass = "bright-green col-xs-12 center";
                    testForm.Controls.Add(successLabel);
                    questionSelect.Items.RemoveAt(questionSelect.SelectedIndex);
                }
            }
        }
        //Setting the question text for Type 1 questions
        private void SetType1Questions(List<Question> type1)
        {
            int x = 0;            
            foreach (Question qt1 in type1)
            {               
                qType1 q = (qType1)testForm.FindControl("q1" + x);
                q.SetQuestionText(qt1.Text);
                q.QuestionID = qt1.ID;
                x++;
                
                if (x == type1.Count)
                {
                    x = 0;
                    break;
                }
            }
        }
        //Setting the question text for Type 2 questions
        private void SetType2Questions(List<Question> type2)
        {
            int x = 0;
            foreach (Question qt2 in type2)
            {
                qType2 q = (qType2)testForm.FindControl("q2" + x);
                q.SetQuestionText(qt2.Text);
                q.QuestionID = qt2.ID;
                x++;
                if (x == type2.Count)
                {
                    x = 0;
                    break;
                }
            }
        }
    }
}