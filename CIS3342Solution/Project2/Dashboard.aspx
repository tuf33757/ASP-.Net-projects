<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="Project2.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Button ID="lblRegister" runat="server" OnClick="lblRegister_Click" Text="Register" />
        <asp:Button ID="lblAddStudent" runat="server" OnClick="lblAddStudent_Click" Text="Add Student" />
        <asp:Button ID="lblAddCourse" runat="server" OnClick="lblAddCourse_Click" Text="Add Course" />
        <asp:Button ID="btnBilling" runat="server" OnClick="btnBilling_Click" Text="Billing" />
        <asp:Button ID="btnEditCourse" runat="server"  Text="Edit Course" OnClick="btnEditCourse_Click" />
    </form>
</body>
</html>
