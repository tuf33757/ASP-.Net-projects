<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HomePage.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <p>
            <asp:Button ID="btnDBDemo" runat="server" OnClick="btnDBDemo_Click" Text="View DbDemo" />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View Calculator" />
            <asp:Button ID="btnCar" runat="server" OnClick="btnCar_Click" Text="View Car Builder" />
            <asp:Button ID="btnReg" runat="server" OnClick="btnReg_Click" Text="View Registration" />
        </p>
    </form>
</body>
</html>
