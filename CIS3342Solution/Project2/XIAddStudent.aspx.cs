using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project2
{
    public partial class XIAddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (checkValues())
            {
                Student newKid = new Student(txtFirstName.Text, txtLastName.Text,
                                                double.Parse(txtGPA.Text), ddMajor.SelectedValue, 0);
                newKid.saveStudent();
                clearPage();
            }
        }
        protected void clearPage() {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtGPA.Text = "";
            ddMajor.ClearSelection();
        }

        protected bool checkValues() {
            if ((txtFirstName.Text != "") && (txtLastName.Text != "") && (txtGPA.Text != ""))
            {
                return true;
            }
            else return false;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx");
        }
    }
}