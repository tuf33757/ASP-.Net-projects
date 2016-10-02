using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using Utilities;

namespace Project3
{
    public partial class AddNewCardMember : System.Web.UI.Page
    {

        creditCardSVC.CreditCardService pxy = new creditCardSVC.CreditCardService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            creditCardSVC.CreditCardTransaction trans = new creditCardSVC.CreditCardTransaction();
            object[] customerInfo = new object[12];
            Random rand = new Random();
            if (validateFields())
            {

                trans.accBal = 0;
                trans.maxBal = 5000;
                trans.verifNumber = rand.Next(100, 999);
               
                trans.expMonth = int.Parse(DateTime.Now.Month.ToString());
                trans.expYear = int.Parse((DateTime.Now.AddYears(4).Year).ToString());
                trans.firstName = txtFirstName.Text;
                trans.lastName = txtLastName.Text;
                trans.Address1 = txtAddress1.Text;
                trans.Address2 = txtAddress2.Text;
                trans.City = txtCity.Text;
                trans.State = ddStates.SelectedValue;
                trans.Zip = int.Parse(txtZip.Text);
                pxy.creatNewAccount(trans);
                
                clearFields();
            }
            else
                lblError.Text = "Please check required fileds.";
        }

        protected bool validateFields() 
        {
            if ((txtFirstName.Text != "" && System.Text.RegularExpressions.Regex.IsMatch(txtFirstName.Text, "^[a-zA-Z]")) && (txtLastName.Text != "" && System.Text.RegularExpressions.Regex.IsMatch(txtLastName.Text, "^[a-zA-Z]")) && txtAddress1.Text != ""
                && (txtCity.Text != "" && System.Text.RegularExpressions.Regex.IsMatch(txtCity.Text, "^[a-zA-Z]")) && (txtZip.Text != "" && checkZip(txtZip.Text))&& ddStates.SelectedIndex != 0)
            {
                return true;
            }
            else
                return false;
        }
        protected bool checkZip(string zip)
        {
            if (zip.Length > 5)
                return false;
            foreach (char n in zip)
            {
                if (n < '0' || n > '9')
                    return false;

            }
            return true;
        }

        protected void clearFields()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtCity.Text = "";
            txtZip.Text = "";
            ddStates.ClearSelection();
        }
       
    }
    
}