using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Numerics;
using Utilities;


namespace Project3
{
    public partial class TransactionPage : System.Web.UI.Page
    {
        creditCardSVC.CreditCardService pxy = new creditCardSVC.CreditCardService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddNewCardMember.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            object[] customerInfo = new object[2];
            Random rand = new Random();
            if (validateCreditCardFields())
            {
                customerInfo[0] = float.Parse(txtAmount.Text);
                customerInfo[1] = Int64.Parse(txtCardNumber.Text);

                if (pxy.creditCardTransaction(customerInfo))
                    lblResponse.Text = "Your transaction has been processed.";
                else
                    lblResponse.Text = "We have encountered a problem.";

            }
            else
                lblResponse.Text = "Please check required fileds.";
        }

        protected bool validateFields()
        {
            if ((txtFirstName.Text != "" && System.Text.RegularExpressions.Regex.IsMatch(txtFirstName.Text, "^[a-zA-Z]")) && (txtLastName.Text != "" && System.Text.RegularExpressions.Regex.IsMatch(txtLastName.Text, "^[a-zA-Z]")) && txtAddress1.Text != ""
                && (txtCity.Text != "" && System.Text.RegularExpressions.Regex.IsMatch(txtCity.Text, "^[a-zA-Z]")) && (txtZip.Text != "" && checkZip(txtZip.Text)) && ddStates.SelectedIndex != 0)
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
        protected bool validateCreditCardFields()
        {
            if (txtCardNumber.Text != "" && txtVerfCode.Text != "")
            {
                return true;
            }
            else
                return false;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            creditCardSVC.CreditCardTransaction trans = new creditCardSVC.CreditCardTransaction();

            if (validateFields())
            {

                trans.CardNumber = Int64.Parse(txtCardNumber.Text);
                trans.firstName = txtFirstName.Text;
                trans.lastName = txtLastName.Text;
                trans.Address1 = txtAddress1.Text;
                trans.Address2 = txtAddress2.Text;
                trans.City = txtCity.Text;
                trans.State = ddStates.SelectedValue;
                trans.Zip = int.Parse(txtZip.Text);
                pxy.updateBillingAddress(trans);

                clearFields();
            }
            else
                lblResponse.Text = "Please check required fileds.";
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            creditCardSVC.CreditCardTransaction trans = new creditCardSVC.CreditCardTransaction();
            if (validateFields())
            {

                trans.CardNumber = Int64.Parse(txtCardNumber.Text);
                pxy.cancelAccount(trans);
            }
            else
                lblResponse.Text = "Please check required fileds.";
        }
    }
}


        
    

