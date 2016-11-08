using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace courseEval
{   
    public partial class Login : System.Web.UI.Page
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Student"] = null;
            if (Session["finished"] != null)
            {
                FinishedAllEvals();
            }
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            Student student = Student.Login(this.inputLnum.Value, this.inputPassword.Value);            
            
            if (student.ID > 0)
            {
                Session["Student"] = student;
                Response.Redirect("~/EvaluationPage.aspx");
            }
                
            else
                loginErrorMessage.Text = "That did not match the information in our system. Try again.";
        }
        public void FinishedAllEvals()
        {
             successLabel.Text = "All evaluations completed successfully";
             successLabel.Visible = true;
        }
     }


}
