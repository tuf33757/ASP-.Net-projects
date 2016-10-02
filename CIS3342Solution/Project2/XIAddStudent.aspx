<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XIAddStudent.aspx.cs" Inherits="Project2.XIAddStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Add Student</title>
    <script src="js/jquery-2.1.4.js"></script>
</head>
<body></>
    <form id="form1" runat="server">
    <h1 s> Add a New Students </h1>
        <div>
         
         First Name:   <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br />
            <br />
           Last Name: <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
            <br />
          GPA  <asp:TextBox ID="txtGPA" runat="server"></asp:TextBox>
            <br />
            <br />
          Major Power <asp:DropDownList ID ="ddMajor" runat="server">
                <asp:ListItem>Strength</asp:ListItem>
                <asp:ListItem>Flight</asp:ListItem>
                <asp:ListItem>Telepath</asp:ListItem>
                <asp:ListItem>Teleportation</asp:ListItem>
                <asp:ListItem>Speed</asp:ListItem>
                <asp:ListItem>Elements</asp:ListItem>
              <asp:ListItem>Mystic Arts</asp:ListItem>
            </asp:DropDownList>
             <br />
            <br />
         
        <p>
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" /> <asp:Button ID="btnSubmit" runat="server" Text="Sumbit" OnClick="btnSubmit_Click"  />
            <asp:Button ID="Button1" runat="server" Text="Home" OnClick="Button1_Click" />
        </p>
            
    </form>
</body>
</html>
