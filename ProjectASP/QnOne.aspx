<%@ Page Title="" Language="C#" MasterPageFile="~/Project.Master" AutoEventWireup="true" CodeBehind="QnOne.aspx.cs" Inherits="ProjectASP.QnOne" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ProjectMaster" runat="server">

    <p>
    Qn 1. How many states are there in India?</p>
<p>
    <asp:RadioButtonList ID="rdbtnQn1" runat="server">
        <asp:ListItem Value="A">29</asp:ListItem>
        <asp:ListItem Value="B">28</asp:ListItem>
        <asp:ListItem Value="C">27</asp:ListItem>
        <asp:ListItem Value="D">30</asp:ListItem>
    </asp:RadioButtonList>
</p>
    <p>
        <asp:Button ID="btnQn1" runat="server" OnClick="btnQn1_Click" Text="Next" />
</p>

</asp:Content>
