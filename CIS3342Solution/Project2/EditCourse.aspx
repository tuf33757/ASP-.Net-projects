<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditCourse.aspx.cs" Inherits="Project2.EditCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="row">

    <div class="col-lg-2">
        
    <div class="col-lg-2">
       
          
        <br />
        <br />
        <br />
        <h1>Select Semester and Department:</h1>
        <asp:Label ID="lblSemester" runat="server" Text="Semester "></asp:Label>
        <asp:DropDownList ID="ddSelectSemester" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddSelectSemester_SelectedIndexChanged">
        </asp:DropDownList>
        
    </div>
    <div class="col-lg-2">
        <asp:Label ID="lblDepartment" runat="server" Text="Department:"></asp:Label>
        <asp:DropDownList ID="ddDepartment" runat="server" OnSelectedIndexChanged="ddDepartment_SelectedIndexChanged" AutoPostBack="true" >
        </asp:DropDownList>
    </div>
    <div class="col-lg-6">
        <h1>Current Courses:</h1>
        <asp:GridView ID="gvCourses" runat="server" AutoGenerateColumns="False"  >
            <Columns>
                <asp:BoundField DataField ="CourseId" HeaderText ="Course Id" ReadOnly ="true"/>
                <asp:BoundField DataField ="CourseName" HeaderText ="Name"  />
                <asp:BoundField DataField ="InstructorId" HeaderText ="Instructor Id"   />
                <asp:BoundField DataField ="DepartmentId" HeaderText ="Department Id"  />
                <asp:BoundField DataField ="Semester" HeaderText ="Semester"   />
                <asp:BoundField DataField ="DayCode" HeaderText ="Days"   />
                <asp:BoundField DataField ="TimeCode" HeaderText ="Time" />
                <asp:BoundField DataField ="CreditHours" HeaderText ="Credits" />
                <asp:BoundField DataField ="NumberofSeatsAvailable" HeaderText ="Seats Left" />
                <asp:TemplateField HeaderText="register">
                    <ItemTemplate>
                        <asp:Button id="btnRemove" runat="server" Text ="Remove" CommandName="Remove" CommandArgument="<%# Container.DataItemIndex %>" Enabled="True" />
                    </ItemTemplate>
                </asp:TemplateField>
                
            </Columns>
            
        </asp:GridView>

        <h1>Edit Course:</h1>

    </div>

    </div>


        </div>
        <p>
            <h1>Select Semester and Department:</h1>
            <asp:DropDownList ID="ddSemester2" runat="server" OnSelectedIndexChanged="ddSemester2_SelectedIndexChanged" AutoPostBack="true">
            </asp:DropDownList>
            <asp:DropDownList ID="ddDepartment2" runat="server" OnSelectedIndexChanged="ddDepartment2_SelectedIndexChanged" AutoPostBack="true">
            </asp:DropDownList>
            <asp:DropDownList ID="ddCourseId" runat="server"></asp:DropDownList>
             <br />
            <br />
            Title <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
            <br />
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
        </p>

        <asp:Button ID="btnEditCourse" runat="server" OnClick="btnEditCourse_Click" Text="Edit" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>