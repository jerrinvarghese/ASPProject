<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="ProjectASP.SignUp" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form runat="server">
    <div class="container">
            <div class="form-horizontal">
                <div class="form-group">
                    <p><asp:Label ID="lblSignUpException" runat="server"></asp:Label></p>
        
                    <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
                    <asp:TextBox ID="txtUserName" class="form-control" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName" ErrorMessage="User Name Required"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                    <asp:TextBox ID="txtPassword" class="form-control" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password Required"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <asp:Button ID="btnRegister" class="btn btn-primary" runat="server" OnClick="btnRegister_Click" Text="Register" />
                    <asp:Button ID="btnCancel" class="btn btn-primary" runat="server" Text="Cancel" />
                </div>
            </div>
        </div>
        </form>
    <script src="../scripts/jquery-1.9.1.min.js"></script>
</body>
</html>




