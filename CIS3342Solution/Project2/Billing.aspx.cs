using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace Project2
{
    public partial class Billing : System.Web.UI.Page
    {
        DBConnect DB = new DBConnect();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                SqlCommand SQL = new SqlCommand();

                SQL.CommandText = "getStudent";
                DataSet DS = DB.GetDataSetUsingCmdObj(SQL);
                ddStudents.DataSource = DS;
                ddStudents.DataTextField = "StudentLastName";
                ddStudents.DataValueField = "StudentId";
                ddStudents.DataBind();
                ddStudents.Items.Insert(0, new ListItem("Select Student", "0"));
            }
        }
            protected void getFullEnrollment()
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "getEnrolledClasses";
            command.Parameters.AddWithValue("@theStudentID", ddStudents.SelectedValue);
            
            DataSet ds = DB.GetDataSetUsingCmdObj(command);
            gvCourses.DataSource = ds;
            gvCourses.DataBind();
            int amount = gvCourses.Rows.Count * 500;
            lblTuition.Text = amount.ToString();
            }

            protected void ddStudents_SelectedIndexChanged(object sender, EventArgs e)
            {
                getFullEnrollment();
            }

            protected void btnCancel_Click(object sender, EventArgs e)
            {
                Response.Redirect("Dashboard.aspx");
            }
    }
}