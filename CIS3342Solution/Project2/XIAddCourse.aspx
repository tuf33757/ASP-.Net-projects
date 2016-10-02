<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XIAddCourse.aspx.cs" Inherits="Project2.XIAddCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Add Course</title>
</head>
<body></>
    <form id="form1" runat="server">
    <h1 style="text-align:center; font-weight:bold"> Add a New Training </h1>
        <div>
        
           Title <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
            <br />
            <br />
          Department   <asp:DropDownList ID ="ddDepartment" runat="server">
              
                       </asp:DropDownList>
             <br />
            <br />
          Credit Hours  <asp:DropDownList ID ="ddCreditHours" runat="server">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
            </asp:DropDownList>
             <br />
            <br />
          Semester  <asp:DropDownList ID ="ddSemester" runat="server">
                <asp:ListItem>Spring</asp:ListItem>
                <asp:ListItem>Fall</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Day Code  <asp:DropDownList ID ="ddDayCode" runat="server">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>M</asp:ListItem>
                <asp:ListItem>T</asp:ListItem>
                <asp:ListItem>W</asp:ListItem>
                <asp:ListItem>R</asp:ListItem>
                <asp:ListItem>F</asp:ListItem>
                <asp:ListItem>TR</asp:ListItem>
                <asp:ListItem>MWF</asp:ListItem>
                <asp:ListItem>MW</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
             Time Period  <asp:DropDownList ID ="ddTimeCode" runat="server">
                 <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>8-850am</asp:ListItem>
                 <asp:ListItem>8:30-9:30am</asp:ListItem>
                <asp:ListItem>9-10:20am</asp:ListItem>
                <asp:ListItem>10:30-11:50am</asp:ListItem>
                  <asp:ListItem>12-1:20pm</asp:ListItem>
                 <asp:ListItem>1:30-2:50pm</asp:ListItem>
                 <asp:ListItem>3-4:20pm</asp:ListItem>
                 <asp:ListItem>5-5:50pm</asp:ListItem>
                 <asp:ListItem>5:30-8pm</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
           Section Number: <asp:TextBox ID="txtSectionNum" runat="server"></asp:TextBox>
            <br />
            <br />
             Seats Available :   <asp:TextBox ID="txtSeats" runat="server"></asp:TextBox>
             <br />
            <br />
            Maximum Seats:   <asp:TextBox ID="txtMaxSeats" runat="server"></asp:TextBox>
             <br />
            <br />
         Instructor:   <asp:DropDownList ID="ddInstructor" runat="server"></asp:DropDownList>   
            <asp:Button ID="Button1" runat="server" Text="Home" OnClick="Button1_Click"  /> <asp:Button ID="btnSubmit" runat="server" Text="Sumbit" OnClick="btnSubmit_Click"  />
        
            
               
            <asp:Label ID="lblError" runat="server"></asp:Label>
        
            
               
        </div>
        
        
    </form>
</body>
</html>

