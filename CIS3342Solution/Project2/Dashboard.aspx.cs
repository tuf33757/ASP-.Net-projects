using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project2
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void lblRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        protected void lblAddStudent_Click(object sender, EventArgs e)
        {
            Response.Redirect("XIAddStudent.aspx");
        }

        protected void lblAddCourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("XIAddCourse.aspx");
        }

        protected void btnBilling_Click(object sender, EventArgs e)
        {
            Response.Redirect("Billing.aspx");
        }

        protected void btnEditCourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditCourse.aspx");
        }
    }
}