using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Utilities;

namespace Project2
{
    class Student
    {
        public int id;
        public string firstName;
        public string lastName;
        public double gpa;
        public string major;
        public float tuition;

        public Student( string fname,string lname, double gpa, string major, float tuition)
        {
            
            this.firstName = fname;
            this.lastName = lname;
            this.tuition = tuition;
            this.gpa = gpa;
            this.major = major;
            this.tuition = tuition;
        }
      

        public void saveStudent()
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "CreateNewStudent";
            
            command.Parameters.AddWithValue("@theFirstName", firstName );
            command.Parameters.AddWithValue("@theLastName", lastName);
            command.Parameters.AddWithValue("@theGPA", gpa);
            command.Parameters.AddWithValue("@theMajor", major);
            command.Parameters.AddWithValue("@theTuitionOwed", tuition);
           
            DBConnect DB = new DBConnect();
            DB.DoUpdateUsingCmdObj(command);
            DB.CloseConnection();

        }
    }

}
