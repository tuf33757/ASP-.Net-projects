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
    public partial class XIAddCourse : System.Web.UI.Page
    {
        DBConnect DB = new DBConnect();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {

                DBConnect DB = new DBConnect();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetInstructorID";

                DataSet ds = DB.GetDataSetUsingCmdObj(command);
                ddInstructor.DataSource = ds;
                ddInstructor.DataTextField = "InstructorLastName";
                ddInstructor.DataValueField = "InstructorId";
                ddInstructor.DataBind();
               
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "getDepartment";
                ds = DB.GetDataSetUsingCmdObj(command);
               ddDepartment.DataSource = ds;
               ddDepartment.DataTextField = "DepartmentName";
               ddDepartment.DataValueField = "DepartmentId";
               ddDepartment.DataBind();
               DB.CloseConnection();



            }


        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (checkValues())
            {
                Course course = new Course(txtTitle.Text, int.Parse(ddDepartment.SelectedValue), ddSemester.SelectedValue, txtSectionNum.Text, int.Parse(ddInstructor.SelectedValue)
                , ddTimeCode.SelectedValue, ddDayCode.SelectedValue, float.Parse(ddCreditHours.SelectedValue), int.Parse(txtSeats.Text), int.Parse(txtMaxSeats.Text));
                course.saveCourse();
            }

            else
                lblError.Text = "there was an error in your sbmission.  It was not processed.";
        }

        protected bool checkValues() {
            if (txtTitle.Text != "" && int.Parse(ddDepartment.SelectedValue) != 0 && ddSemester.SelectedIndex != 0 && txtSectionNum.Text != "" && int.Parse(ddInstructor.SelectedValue) != 0 &&
                ddTimeCode.SelectedIndex != 0 && ddDayCode.SelectedIndex != 0 && int.Parse(txtSeats.Text) != 0 && int.Parse(txtMaxSeats.Text) != 0)
                return true;
            else
                return false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx");
        }

    }
}