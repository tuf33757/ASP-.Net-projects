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
    public partial class EditCourse : System.Web.UI.Page
    {
       
        DBConnect DB = new DBConnect();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlCommand SQL = new SqlCommand();
                SQL.CommandType = CommandType.StoredProcedure;
                SQL.CommandText = "getSemester";
                DataSet DS = DB.GetDataSetUsingCmdObj(SQL);
                ddSelectSemester.DataSource = DS;
                ddSelectSemester.DataTextField = "Semester";
                ddSelectSemester.DataValueField = "Semester";
                ddSelectSemester.DataBind();
                ddSelectSemester.Items.Insert(0, new ListItem("Please select", "0"));

                 SQL = new SqlCommand();
                SQL.CommandType = CommandType.StoredProcedure;
                SQL.CommandText = "getSemester";
                DS = DB.GetDataSetUsingCmdObj(SQL);
                ddSemester2.DataSource = DS;
                ddSemester2.DataTextField = "Semester";
                ddSemester2.DataValueField = "Semester";
                ddSemester2.DataBind();
                ddSemester2.Items.Insert(0, new ListItem("Please select", "0"));

                SQL = new SqlCommand();
                SQL.CommandType = CommandType.StoredProcedure;
                SQL.CommandText = "GetInstructorID";

                DataSet ds = DB.GetDataSetUsingCmdObj(SQL);
                ddInstructor.DataSource = ds;
                ddInstructor.DataTextField = "InstructorLastName";
                ddInstructor.DataValueField = "InstructorId";
                ddInstructor.DataBind();

                SQL.CommandText = "getDepartment";
                DS = DB.GetDataSetUsingCmdObj(SQL);
                ddDepartment.DataSource = DS;
                ddDepartment.DataTextField = "DepartmentName";
                ddDepartment.DataValueField = "DepartmentId";
                ddDepartment.DataBind();
                ddDepartment.Items.Insert(0, new ListItem("Please select", "0"));
                SQL.CommandText = "getDepartment";
                DS = DB.GetDataSetUsingCmdObj(SQL);
                ddDepartment2.DataSource = DS;
                ddDepartment2.DataTextField = "DepartmentName";
                ddDepartment2.DataValueField = "DepartmentId";
                ddDepartment2.DataBind();
                ddDepartment2.Items.Insert(0, new ListItem("Please select", "0"));
                DB.CloseConnection();


            }
        }

        protected void ddSelectSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddDepartment.SelectedIndex != 0)
            {

                getCourses();
            }
        }

        protected void ddDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (ddSelectSemester.SelectedIndex != 0)
            {
                getCourses();

            }
        }
         public void gvCourses_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Remove")
            {
                int theCourse = (int.Parse(gvCourses.Rows[index].Cells[0].Text));
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "deleteCourse";
                
                command.Parameters.AddWithValue("@theCourseId", theCourse);
                DataSet ds = DB.GetDataSetUsingCmdObj(command);
                gvCourses.DataSource = ds;
                gvCourses.DataBind();
                DB.CloseConnection();
            }
         }

         

        

         protected void getCourses() {

             SqlCommand command = new SqlCommand();
             command.CommandType = CommandType.StoredProcedure;
             command.CommandText = "getCourses";
             command.Parameters.AddWithValue("@theSemester", ddSelectSemester.SelectedValue);
             command.Parameters.AddWithValue("@theDepartmentID", ddDepartment.SelectedValue);
             DataSet ds = DB.GetDataSetUsingCmdObj(command);
             gvCourses.DataSource = ds;
             gvCourses.DataBind();
             DB.CloseConnection();
         }

         protected void ddSemester2_SelectedIndexChanged(object sender, EventArgs e)
         {
             if (ddDepartment2.SelectedIndex != 0)
             {
                 getCourseId();
             }
         }

         protected void ddDepartment2_SelectedIndexChanged(object sender, EventArgs e)
         {
             if (ddSemester2.SelectedIndex != 0) {
                 getCourseId();
             }
         }

         protected void getCourseId() {

             SqlCommand command = new SqlCommand();
             command.CommandType = CommandType.StoredProcedure;
             command.CommandText = "getCourseIDBasedonSemester";
             command.Parameters.AddWithValue("@theSemester", ddSemester2.SelectedValue);
             command.Parameters.AddWithValue("@theDepartment", ddDepartment2.SelectedValue);
             DataSet ds = DB.GetDataSetUsingCmdObj(command);
            ddCourseId.DataSource = ds;
            ddCourseId.DataTextField = "CourseId";
            ddCourseId.DataValueField = "CourseId";
             ddCourseId.DataBind();
             DB.CloseConnection();
         }

         protected void editCourse() {
             if (checkValues())
             {
                 SqlCommand command = new SqlCommand();
                 command.CommandType = CommandType.StoredProcedure;
                 command.CommandText = "EditCourse";
                 command.Parameters.AddWithValue("@theCourseId", ddCourseId.SelectedValue);
                 command.Parameters.AddWithValue("@theCourseName", txtTitle.Text);
                 command.Parameters.AddWithValue("@theInstructorId", ddInstructor.SelectedValue);
                 command.Parameters.AddWithValue("@theDepartmentID", ddDepartment2.SelectedValue);
                 command.Parameters.AddWithValue("@theSemester", ddSemester2.SelectedValue);
                 command.Parameters.AddWithValue("@theSection", txtSectionNum.Text);
                 command.Parameters.AddWithValue("@theDayCode", ddDayCode.SelectedValue);
                 command.Parameters.AddWithValue("@theTimeCode", ddTimeCode.SelectedValue);
                 command.Parameters.AddWithValue("@theCreditHours", float.Parse(ddCreditHours.SelectedValue));
                 command.Parameters.AddWithValue("@theNumberofSeatsAvailable", int.Parse(txtSeats.Text));
                 command.Parameters.AddWithValue("@theMaxSeats", int.Parse(txtMaxSeats.Text));

                 DataSet ds = DB.GetDataSetUsingCmdObj(command);

                 DB.CloseConnection();
             }
             else
                 lblError.Text = "You must correct your input before processing.";
         }

         protected void btnEditCourse_Click(object sender, EventArgs e)
         {
             editCourse();
         }

         protected void btnCancel_Click(object sender, EventArgs e)
         {
             Response.Redirect("Dashboard.aspx");
         }
         protected bool checkValues()
         {
             if (txtTitle.Text != "" && int.Parse(ddDepartment.SelectedValue) != 0 && ddSemester2.SelectedIndex != 0 && txtSectionNum.Text != "" && int.Parse(ddInstructor.SelectedValue) != 0 &&
                 ddTimeCode.SelectedIndex != 0 && ddDayCode.SelectedIndex != 0 && int.Parse(txtSeats.Text) != 0 && int.Parse(txtMaxSeats.Text) != 0)
                 return true;
             else
                 return false;
         }
    }
}