using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace courseEval
{
    public partial class EvaluationMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Request.RawUrl == "/Login.aspx")
                logoutBtn.Visible = false;           
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            logoutBtn.ServerClick += new EventHandler(logoutBtn_ServerClick);
        }

        protected void logoutBtn_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }
    }
}