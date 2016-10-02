<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Billing.aspx.cs" Inherits="Project2.Billing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Select Student:</h1>
            <asp:DropDownList ID="ddStudents" runat="server" OnSelectedIndexChanged="ddStudents_SelectedIndexChanged" AutoPostBack="true">
            </asp:DropDownList>
            <h1>Enrolled Courses:</h1>
            <asp:GridView ID="gvCourses" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="CourseId" HeaderText="Course Id" />
                    <asp:BoundField DataField="CourseName" HeaderText="Name" />
                    <asp:BoundField DataField="InstructorId" HeaderText="Instructor Id" />
                    <asp:BoundField DataField="DepartmentId" HeaderText="Department Id" />
                    <asp:BoundField DataField="Semester" HeaderText="Semester" />
                    <asp:BoundField DataField="DayCode" HeaderText="Days" />
                    <asp:BoundField DataField="TimeCode" HeaderText="Time" />
                    <asp:BoundField DataField="CreditHours" HeaderText="Credits" />
                    <asp:BoundField DataField="NumberofSeatsAvailable" HeaderText="Seats Left" />
                </Columns>

            </asp:GridView>
            <asp:Label id="Label1" runat="server" Text="Tuition Owed: "></asp:Label><asp:Label id="lblTuition" runat="server" Text=""></asp:Label>
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
            
        </div>
    </form>
</body>
</html>
