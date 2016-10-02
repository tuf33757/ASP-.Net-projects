using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomePage
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDBDemo_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://cis-iis2.temple.edu/FALL2015/CIS3342_tuf33757/Lab1/DBDemo.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://cis-iis2.temple.edu/FALL2015/CIS3342_tuf33757/Lab1/Calculator.aspx");
        }
        protected void btnCar_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://cis-iis2.temple.edu/FALL2015/CIS3342_tuf33757/Project1/frmSearch.aspx");
        }
        protected void btnReg_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://cis-iis2.temple.edu/FALL2015/CIS3342_tuf33757/Project2/XILoginPage.aspx");
        }
    }
}