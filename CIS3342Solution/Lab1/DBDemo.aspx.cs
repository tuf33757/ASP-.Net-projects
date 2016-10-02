using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace Lab1
{
    public partial class DBDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT * FROM StudentTable";
            DataSet myDS = objDB.GetDataSet(strSQL);
            gvStudents.DataSource = myDS;
            gvStudents.DataBind();

        }
    }
}