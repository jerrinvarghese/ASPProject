<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="ProjectASP.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/SignIn.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        .textstyle{
            border-style:solid;
            border-color:black;
            border-width:3px;
        }

        .labelHeading{
            margin-left:780px;
            margin-top:20px;
            font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
            font-size:large;
        }
    </style>
</head>
<body class="bodyClass">
    <form id="form1" runat="server">
    <div>
        <%--<asp:Label ID="labelHeading" runat="server" Text="Test Your Knowledge" Font-Bold="True" Font-Italic="True" Font-Names="MingLiU-ExtB" Font-Size="XX-Large"></asp:Label>--%>
           <h1 class="labelHeading">Test</h1> 
        <h1 class="labelHeading">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Your</h1>
        <h1 class="labelHeading">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Knowledge Here !!</h1>
        <div class="container" style="margin-top:200px;">
            <div class="row">
                <div class="col-md-8">
        
        </div>
                <div class="col-md-4">
                     </div>
            </div>
            <div class="row">
    <div class="col-md-8">
        
        </div>
                <div class="col-md-4">
                    
                    <asp:HyperLink ID="HyperLink1" style="margin-left:150px;" runat="server" NavigateUrl="~/PublicPages/SignUp.aspx">Don't have an account? Sign Up</asp:HyperLink>
                    <br />
                    
                <asp:TextBox ID="txtUserName" class="form-control textstyle" placeholder="Enter UserName" runat="server" BackColor="Black" BorderColor="#666699"></asp:TextBox>
                       
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName" ErrorMessage="User Name Required"></asp:RequiredFieldValidator>
            
               <asp:TextBox ID="txtPswd" class="form-control" placeholder="Enter Password" runat="server" BackColor="Black" BorderColor="#666699" BorderWidth="3px" TextMode="Password"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPswd" ErrorMessage="Password Required"></asp:RequiredFieldValidator>
            
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;
           
                <asp:Button ID="btnLogin" class="btn btn-primary" runat="server" OnClick="btnLogin_Click" Text="Login" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                <asp:Button ID="btnCancel" class="btn btn-primary" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
                    &nbsp;
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    
                    </div>
            </div>
        </div>
    
     
    </div>
    </form>
    <script src="scripts/jquery-1.9.1.min.js"></script>
</body>
</html>    


    
    

