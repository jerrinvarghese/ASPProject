<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="ProjectASP.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/SignIn.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        /*.textstyle{
            border-style:solid;
            border-color:black;
            border-width:3px;
        }*/

        /*.labelHeading{
            margin-left:780px;
            margin-top:20px;
            font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
            font-size:large;
        }*/
    </style>
</head>
<body class="bodyClass">
    <form id="form1" runat="server">
        <div class="container" style="margin-top:200px;">
         <div>
        <h1>Test</h1> 
        <h1> Your</h1>
        <h1>Knowledge Here !!</h1>
       
            <div class="row">
    <div class="col-md-6">
        <asp:Label ID="lblLoginException" runat="server"></asp:Label>
        </div>
                <div class="col-md-4">
                    
                    <asp:HyperLink ID="HyperLink1" style="margin-left:150px;" runat="server" NavigateUrl="~/PublicPages/SignUp.aspx">Don't have an account? Sign Up</asp:HyperLink>
                    <br />
            
            <asp:TextBox ID="txtUserName" class="form-control textstyle" placeholder="Enter UserName" runat="server" BackColor="Black" BorderColor="#666699" Width="201px" BorderWidth="3px"></asp:TextBox>
                       
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName" ErrorMessage="User Name Required"></asp:RequiredFieldValidator>
        
               <asp:TextBox ID="txtPswd" class="form-control" placeholder="Enter Password" runat="server" BackColor="Black" BorderColor="#666699" BorderWidth="3px" TextMode="Password" Width="202px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPswd" ErrorMessage="Password Required"></asp:RequiredFieldValidator>
            
            
                    <br />
            
            
            <asp:Button ID="btnLogin" class="btn btn-primary" runat="server" OnClick="btnLogin_Click" Text="Login" />
            <asp:Button ID="btnCancel" class="btn btn-primary" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
                    
                    <br />
                    
            </div>
                </div>
        </div>
    
     
    </div>
    </form>
    <script src="scripts/jquery-1.9.1.min.js"></script>
</body>
</html>    


    
    

