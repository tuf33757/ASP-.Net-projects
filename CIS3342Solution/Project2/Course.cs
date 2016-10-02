using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace Project2
{
   public class Course
    {
        
        public string CourseName;
        public int instructor;
        public int departmentID;
        public string semester;
        public string section;
        public string timeCode;
        public string dayCode;
        public float creditHours;
        public int numSeats;
        public int maxSeats;

        public Course( string coursename, int depID, string semester, string section, int instruc, string tc, string dc, float ch, int seats, int ms)
        {
            
            this.CourseName = coursename;
            this.departmentID = depID;
            this.semester = semester;
            this.section = section;
            this.instructor = instruc;
            this.timeCode = tc;
            this.dayCode = dc;
            this.creditHours = ch;
            this.maxSeats = ms;
            this.numSeats = seats;
        }
        //public string CRN
        //{
        //    get { return CourseId; }
        //    set { value = CourseId; }
        //}

        public int DepartmentID
        {
            get { return departmentID; }
            set { value = departmentID; }
        }

        public string Title
        {
            get { return CourseName; }
            set { value = CourseName; }
        }

        public string Semester
        {
            get { return semester; }
            set { value = semester; }
        }

        public string Section
        {
            get { return section; }
            set { value = section; }
        }

        public int Instructor
        {
            get { return instructor; }
            set { value = instructor; }
        }

        public string TimeCode
        {
            get { return timeCode; }
            set { value = timeCode; }
        }

        public string DayCode
        {
            get { return dayCode; }
            set { value = dayCode; }
        }

        public float CreditHours
        {
            get { return creditHours; }
            set { value = creditHours; }
        }

        public int NumberSeats
        {
            get { return numSeats; }
            set { value = numSeats; }
        }

        public int MaxSeats
        {
            get { return maxSeats; }
            set { value = maxSeats; }
        }

        public void saveCourse()
        {
            DBConnect DB = new DBConnect();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "CreateNewCourse";


            
            SqlParameter crsName = new SqlParameter("@theCourseName", CourseName);
            crsName.Direction = ParameterDirection.Input;
            crsName.SqlDbType = SqlDbType.VarChar;
            crsName.Size = -1;
            command.Parameters.Add(crsName);
            SqlParameter instrId = new SqlParameter("@theInstructorId", instructor);
            instrId.Direction = ParameterDirection.Input;
            instrId.SqlDbType = SqlDbType.Int;
            command.Parameters.Add(instrId);
            SqlParameter departId = new SqlParameter("@theDepartmentID", departmentID);
            departId.Direction = ParameterDirection.Input;
            departId.SqlDbType = SqlDbType.Int;
            command.Parameters.Add(departId);
            SqlParameter smstr = new SqlParameter("@theSemester", semester);
            smstr.Direction = ParameterDirection.Input;
            smstr.SqlDbType = SqlDbType.VarChar;
            smstr.Size = -1;
            command.Parameters.Add(smstr);
            SqlParameter sctn = new SqlParameter("@theSection", section);
            sctn.Direction = ParameterDirection.Input;
            sctn.SqlDbType = SqlDbType.VarChar;
            sctn.Size = -1;
            command.Parameters.Add(sctn);
            SqlParameter dCode = new SqlParameter("@theDayCode", dayCode);
            dCode.Direction = ParameterDirection.Input;
            dCode.SqlDbType = SqlDbType.VarChar;
            command.Parameters.Add(dCode);
            SqlParameter tCode = new SqlParameter("@theTimeCode", timeCode);
            tCode.Direction = ParameterDirection.Input;
            tCode.SqlDbType = SqlDbType.VarChar;
            command.Parameters.Add(tCode);
            tCode.Size = -1;
            SqlParameter crdHr = new SqlParameter("@theCreditHours", creditHours);
            crdHr.Direction = ParameterDirection.Input;
            crdHr.SqlDbType = SqlDbType.Float;
            command.Parameters.Add(crdHr);
            SqlParameter numSeat = new SqlParameter("@theNumberofSeatsAvailable", numSeats);
            numSeat.Direction = ParameterDirection.Input;
            numSeat.SqlDbType = SqlDbType.Int;
            command.Parameters.Add(numSeat);
            SqlParameter maxSeat = new SqlParameter("@theMaxSeats", maxSeats);
            maxSeat.Direction = ParameterDirection.Input;
            maxSeat.SqlDbType = SqlDbType.Int;
            command.Parameters.Add(maxSeat);
            DataSet DS = DB.GetDataSetUsingCmdObj(command);
            
                      
            
            DB.CloseConnection();
        }

        

    }
}