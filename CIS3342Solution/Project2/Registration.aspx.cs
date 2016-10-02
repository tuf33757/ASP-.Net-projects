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
    public partial class Registration : System.Web.UI.Page
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

                SQL.CommandText = "getDepartment";
                DS = DB.GetDataSetUsingCmdObj(SQL);
                ddDepartment.DataSource = DS;
                ddDepartment.DataTextField = "DepartmentName";
                ddDepartment.DataValueField = "DepartmentId";
                ddDepartment.DataBind();
                ddDepartment.Items.Insert(0, new ListItem("Please select", "0"));

                SQL.CommandText = "getStudent";
                DS = DB.GetDataSetUsingCmdObj(SQL);
                ddStudents.DataSource = DS;
                ddStudents.DataTextField =  "StudentLastName";
                ddStudents.DataValueField = "StudentId";
                ddStudents.DataBind();
                ddStudents.Items.Insert(0, new ListItem("Select Student", "0"));

            }

        }

        protected void ddSelectSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddDepartment.SelectedIndex != 0)
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "getCourses";
                command.Parameters.AddWithValue("@theSemester", ddSelectSemester.SelectedValue);
                command.Parameters.AddWithValue("@theDepartmentID", ddDepartment.SelectedValue);
                DataSet ds = DB.GetDataSetUsingCmdObj(command);
                gvCourses.DataSource = ds;
                gvCourses.DataBind();

            }
        }

        protected void ddDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddSelectSemester.SelectedIndex != 0)
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "getCourses";
                command.Parameters.AddWithValue("@theSemester", ddSelectSemester.SelectedValue);
                command.Parameters.AddWithValue("@theDepartmentID", ddDepartment.SelectedValue);
                DataSet ds = DB.GetDataSetUsingCmdObj(command);
                gvCourses.DataSource = ds;
                gvCourses.DataBind();

            }
        }
        public void gvCourses_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Add")
            {
                Button Add = (Button)gvCourses.Rows[index].FindControl("btnAdd");
                Add.Enabled = false;
                Button remove = (Button)gvCourses.Rows[index].FindControl("btnRemove");
                remove.Enabled = true;

                GridViewRow gvRow = gvCourses.Rows[index];
                string courseId = gvCourses.Rows[index].Cells[0].Text;
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "createEnrollment";
                command.Parameters.AddWithValue("@theCourseId", courseId);
                command.Parameters.AddWithValue("@theStudentId", ddStudents.SelectedValue);
                DBConnect DB = new DBConnect();
                DB.DoUpdateUsingCmdObj(command);
                DB.CloseConnection();
                updateTuitionAdd();
                int courseSeat = int.Parse(courseId);
                removeSeat(courseSeat);


            }
            if (e.CommandName == "Remove") 
            {
                 
                Button Add = (Button)gvCourses.Rows[index].FindControl("btnAdd");
                Add.Enabled = true;
                Button remove = (Button)gvCourses.Rows[index].FindControl("btnRemove");
                remove.Enabled = false;

                GridViewRow gvRow = gvCourses.Rows[index];
                string courseId = gvCourses.Rows[index].Cells[0].Text;
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "removeEnrollment";
                command.Parameters.AddWithValue("@theCourseId", courseId);
                command.Parameters.AddWithValue("@theStudentId", ddStudents.SelectedValue);
                DBConnect DB = new DBConnect();
                DB.DoUpdateUsingCmdObj(command);
                DB.CloseConnection();
                removeTuition();
                int courseSeat = int.Parse(courseId);
                addSeat(courseSeat);
               
                
            }
        }

        protected void updateTuitionAdd() {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "updateStudentTable";

            command.Parameters.AddWithValue("@theStudentID", ddStudents.SelectedValue);
            DB = new DBConnect();
            DB.DoUpdateUsingCmdObj(command);
            DB.CloseConnection();
        
        }
        protected void removeTuition()
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "removeTuition";

            command.Parameters.AddWithValue("@theStudentID", ddStudents.SelectedValue);
            DB = new DBConnect();
            DB.DoUpdateUsingCmdObj(command);
            DB.CloseConnection(); 
        }

        protected void removeSeat(int courseId) {

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "updateSeatsAvailableMinus";

            command.Parameters.AddWithValue("@theCourseId", courseId);
            DB = new DBConnect();
            DB.DoUpdateUsingCmdObj(command);
            DB.CloseConnection();
            
        }
        protected void addSeat(int courseId)
        {

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "updateSeatsAvailablePlus";

            command.Parameters.AddWithValue("@theCourseId", courseId);
            DB = new DBConnect();
            DB.DoUpdateUsingCmdObj(command);
            DB.CloseConnection();

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx");
        }
    }
}