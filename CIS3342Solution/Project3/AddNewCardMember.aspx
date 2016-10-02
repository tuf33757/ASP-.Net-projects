<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddNewCardMember.aspx.cs" Inherits="Project3.AddNewCardMember" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="js/jquery-2.1.4.js"></script>
    <script src="js/jquery-2.1.4.min.js"></script>
    <script src="js/jquery.hotkeys.js"></script>
    <link href="css/bootstrap-theme.css" rel="stylesheet" />
    <link href="css/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
            background-color: #f4f4f4;
        }

        #wrapper {
            border: 1px #e4e4e4 solid;
            padding: 20px 20px;
            border-radius: 4px;
            box-shadow: 0 0 6px #ccc;
            background-color: #fff;
            
        }

        .container {
            height: 100%;
        }
    </style>
</head>
<body>


    <form class="form-horizontal" runat="server">
        <div id="wrapper" class="container">
            <fieldset>


                <legend>Add New Customer:</legend>
                <div class="form-group">
                    <label class="col-md-4 control-label" for="txtFirstName">First Name:</label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtFirstName" runat="server" class="form-control input-md"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-md-4 control-label" for="txtLastName">Last Name:</label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtLastName" runat="server" class="form-control input-md"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-md-4 control-label" for="txtLastName">Address 1:</label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtAddress1" runat="server" class="form-control input-md"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-md-4 control-label" for="txtLastName">Address 2:</label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtAddress2" runat="server" class="form-control input-md"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-md-4 control-label" for="txtLastName">City:</label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtCity" runat="server" class="form-control input-md"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-md-4 control-label" for="txtLastName">State:</label>
                    <div class="col-md-4">
                        <asp:DropDownList ID="ddStates" runat="server" class="form-control">
                            <asp:ListItem Value ="Select">Select State</asp:ListItem>
                            <asp:ListItem Value="AK">Alaska</asp:ListItem>
                            <asp:ListItem Value="AL">Alabama</asp:ListItem>
                            <asp:ListItem Value="AR">Arkansas</asp:ListItem>
                            <asp:ListItem Value="AZ">Arizona</asp:ListItem>
                            <asp:ListItem Value="CA">California</asp:ListItem>
                            <asp:ListItem Value="CO">Colorado</asp:ListItem>
                            <asp:ListItem Value="CT">Connecticut</asp:ListItem>
                            <asp:ListItem Value="DC">District of Columbia</asp:ListItem>
                            <asp:ListItem Value="DE">Delaware</asp:ListItem>
                            <asp:ListItem Value="FL">Florida</asp:ListItem>
                            <asp:ListItem Value="GA">Georgia</asp:ListItem>
                            <asp:ListItem Value="HI">Hawaii</asp:ListItem>
                            <asp:ListItem Value="IA">Iowa</asp:ListItem>
                            <asp:ListItem Value="ID">Idaho</asp:ListItem>
                            <asp:ListItem Value="IL">Illinois</asp:ListItem>
                            <asp:ListItem Value="IN">Indiana</asp:ListItem>
                            <asp:ListItem Value="KS">Kansas</asp:ListItem>
                            <asp:ListItem Value="KY">Kentucky</asp:ListItem>
                            <asp:ListItem Value="LA">Louisiana</asp:ListItem>
                            <asp:ListItem Value="MA">Massachusetts</asp:ListItem>
                            <asp:ListItem Value="MD">Maryland</asp:ListItem>
                            <asp:ListItem Value="ME">Maine</asp:ListItem>
                            <asp:ListItem Value="MI">Michigan</asp:ListItem>
                            <asp:ListItem Value="MN">Minnesota</asp:ListItem>
                            <asp:ListItem Value="MO">Missouri</asp:ListItem>
                            <asp:ListItem Value="MS">Mississippi</asp:ListItem>
                            <asp:ListItem Value="MT">Montana</asp:ListItem>
                            <asp:ListItem Value="NC">North Carolina</asp:ListItem>
                            <asp:ListItem Value="ND">North Dakota</asp:ListItem>
                            <asp:ListItem Value="NE">Nebraska</asp:ListItem>
                            <asp:ListItem Value="NV">Nevada</asp:ListItem>
                            <asp:ListItem Value="NH">New Hampshire</asp:ListItem>
                            <asp:ListItem Value="NJ">New Jersey</asp:ListItem>
                            <asp:ListItem Value="NM">New Mexico</asp:ListItem>
                            <asp:ListItem Value="NY">New York</asp:ListItem>
                            <asp:ListItem Value="OH">Ohio</asp:ListItem>
                            <asp:ListItem Value="OK">Oklahoma</asp:ListItem>
                            <asp:ListItem Value="OR">Oregon</asp:ListItem>
                            <asp:ListItem Value="PA">Pennsylvania</asp:ListItem>
                            <asp:ListItem Value="RI">Rhode Island</asp:ListItem>
                            <asp:ListItem Value="SC">South Carolina</asp:ListItem>
                            <asp:ListItem Value="SD">South Dakota</asp:ListItem>
                            <asp:ListItem Value="TN">Tennessee</asp:ListItem>
                            <asp:ListItem Value="TX">Texas</asp:ListItem>
                            <asp:ListItem Value="UT">Utah</asp:ListItem>
                            <asp:ListItem Value="VA">Virginia</asp:ListItem>
                            <asp:ListItem Value="VT">Vermont</asp:ListItem>
                            <asp:ListItem Value="WA">Washington</asp:ListItem>
                            <asp:ListItem Value="WI">Wisconsin</asp:ListItem>
                            <asp:ListItem Value="WV">West Virginia</asp:ListItem>
                            <asp:ListItem Value="WY">Wyoming</asp:ListItem>

                        </asp:DropDownList>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-md-4 control-label" for="txtLastName">Zip:</label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtZip" runat="server" class="form-control input-md"></asp:TextBox>
                    </div>
                </div>
                <br />
                <br />

                <div class="form-group">
                    <label class="col-md-4 control-label" for="txtLastName">Submit For Authorization:</label>
                    <div class="col-md-4">
                        
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                        
                    </div>
                </div>
            </fieldset>
        </div>
    </form>


</body>
</html>
