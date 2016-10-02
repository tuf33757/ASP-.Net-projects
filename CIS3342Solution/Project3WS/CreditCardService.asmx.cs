using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using Utilities;
using System.Numerics;
using System.Xml;
using System.Xml.Serialization;


namespace Project3WS
{
    /// <summary>
    /// Summary description for CreditCardService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CreditCardService : System.Web.Services.WebService
    {

        [WebMethod]
        public Boolean creatNewAccount(CreditCardTransaction trans)

        {
            DBConnect DB = new DBConnect();
            string SQL = "INSERT into CreditCardAccounts (VerCode, AccountBalance, AccountMax, expMonth, expYear) VALUES (" + trans.verifNumber + " , "
                + trans.accBal + " , " + trans.maxBal + " , " + trans.expMonth + " , " + trans.expYear + ") INSERT INTO CreditCardAccountCustomerInfo" +
                "(CreditCardNumber, CustomerFirst, CustomerLast, Address1, Address2, City, State, Zip) VALUES (SCOPE_IDENTITY(), '" + trans.firstName + "', '" +
                trans.lastName + "' , '" + trans.Address1 + "', '" + trans.Address2 + "', '" + trans.City + "', '" + trans.State + "', " + trans.Zip + ");";
                int returnCode = DB.DoUpdate(SQL);

            
            DB.CloseConnection();

            if (returnCode == 1)
                return true;
            else
                return false;
        }

        [WebMethod]
        [XmlInclude(typeof(BigInteger))]
        public Boolean creditCardTransaction(object[] customerInfo)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "creditCardTransaction";
            command.Parameters.AddWithValue("@theTransactionAmount", (float)customerInfo[0]);
            command.Parameters.AddWithValue("@theCreditCardNumber", (Int64)customerInfo[1]);
            string date = DateTime.Now.ToString();
            DBConnect DB = new DBConnect();
            int returnCode = DB.DoUpdateUsingCmdObj(command);
            DB.CloseConnection();
            DB = new DBConnect();
            string SQL = "Insert into CreditCardTransactions (TransactionAmount, TransactionTime, CreditCardNumber) Values ("
                + (float)customerInfo[0] + ", '" + date + "' , " + (Int64)customerInfo[1] + ");";
            DB.DoUpdate(SQL);

            if (returnCode == 1)
                return true;
            else
                return false;
        }

        [WebMethod]
        public Boolean updateBillingAddress(CreditCardTransaction trans) 
        {
            DBConnect DB = new DBConnect();
            string SQL = "UPDATE CreditCardAccountCustomerInfo SET " +
                "CustomerFirst = '" + trans.firstName + "', CustomerLast = '" + trans.lastName + "', Address1 = '" + trans.Address1 + "', Address2 = '"
                + trans.Address2 + "', City = '"+ trans.City + "', State = '" +trans.State+ "', Zip = " +trans.Zip+" Where CreditCardNumber = " + trans.CardNumber+";";
            int returnCode = DB.DoUpdate(SQL);


            DB.CloseConnection();

            if (returnCode == 1)
                return true;
            else
                return false;


        }

        [WebMethod]
        public Boolean cancelAccount(CreditCardTransaction trans)

        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "creditCardTransaction";
            
            command.Parameters.AddWithValue("@theCardNumber", trans.CardNumber);
            
            DBConnect DB = new DBConnect();
            int returnCode = DB.DoUpdateUsingCmdObj(command);
            DB.CloseConnection();
            if (returnCode == 1)
                return true;
            else
                return false;
        }

        
    }
}
