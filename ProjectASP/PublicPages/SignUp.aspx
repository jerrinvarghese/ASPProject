<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="ProjectASP.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/SignIn.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body class="signUpBackground">
    <form id="form1" runat="server">
    <div class="container" style="margin-top:150px;">
     <div class="row">
         <div class="col-md-3">

         </div>
         <div class="col-md-5" style="width:665px; height:350px;background-color:gray;">
              <br />
              <br />
              <br />
             <asp:Label ID="Label1" runat="server" Text="User Name" Font-Bold="True" Font-Italic="False" Font-Names="Times New Roman" Font-Size="Large"></asp:Label>
              <asp:TextBox ID="txtUserName" class="form-control" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName" ErrorMessage="User Name Required"></asp:RequiredFieldValidator>
            
              <br />
              <br />
            
             <asp:Label ID="Label2" runat="server" Text="Password" Font-Bold="True" Font-Names="Times New Roman" Font-Size="Large"></asp:Label>
             <asp:TextBox ID="txtPassword" class="form-control" runat="server" TextMode="Password"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password Required"></asp:RequiredFieldValidator>
            
              <br />
              <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
             <asp:Button ID="btnRegister" class="btn btn-primary" runat="server" OnClick="btnRegister_Click" Text="Register" />
             &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancel" class="btn btn-primary" runat="server" Text="Cancel" />
         </div>
         <div class="col-md-4">

         </div>
     </div>
            
            
               
            
        
    
    </div>
    </form>
    <script src="../scripts/jquery-1.9.1.min.js"></script>
</body>
</html>


   

