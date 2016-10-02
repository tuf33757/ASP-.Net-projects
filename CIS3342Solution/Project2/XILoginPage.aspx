<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XILoginPage.aspx.cs" Inherits="Project2.XILoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
    body {
    background-image:url("XILogin.jpg") ;
    background-size: 100%;
    background-repeat: no-repeat;

    background-color: #cccccc;
}</style>
    <script src="js/jquery-2.1.4.js"></script>
    <script src="js/jquery-2.1.4.min.js"></script>
    <script src="js/bootstrap.js"></script>
    <script src="js/bootstrap.min.js"></script>
    
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/login.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="fullscreen_bg" class="fullscreen_bg"/>

<div class="container">

	<form class="form-signin">
		<h1 class="form-signin-heading text-muted">Xavier Institute for Gifted Youngsters</h1>
		<input type="text" class="form-control" placeholder="Username" required="" autofocus="">
		<input type="password" class="form-control" placeholder="Password" required="">
		<button class="btn btn-lg btn-primary btn-block" type="submit" formaction="Dashboard.aspx">
			Sign In
		</button>
	</form>

</div>
            
    </form>
</body>
</html>
