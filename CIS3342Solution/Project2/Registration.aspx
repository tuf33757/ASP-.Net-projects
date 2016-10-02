<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Project2.Registration" %>

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
        <h1>Select Student:</h1>
        <asp:DropDownList ID="ddStudents" runat="server">

        </asp:DropDownList>
          
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
        <asp:GridView ID="gvCourses" runat="server" AutoGenerateColumns="False" OnRowCommand="gvCourses_RowCommand"  >
            <Columns>
                <asp:BoundField DataField ="CourseId" HeaderText ="Course Id" />
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
                        <asp:Button id="btnAdd" runat="server" Text ="Add" CommandName="Add" CommandArgument="<%# Container.DataItemIndex %>" />
                        <asp:Button id="btnRemove" runat="server" Text ="Remove" CommandName="Remove" CommandArgument="<%# Container.DataItemIndex %>" Enabled="False" />
                    </ItemTemplate>
                </asp:TemplateField>
                
            </Columns>
            
        </asp:GridView>

        
    </div>
        <asp:Button ID="btnCancel" runat="server" Text="Home" OnClick="btnCancel_Click"  />
    </div>


    </form>
</body>
</html>