<%@ Page Title="" Language="C#" MasterPageFile="~/Project.Master" AutoEventWireup="true" CodeBehind="QnFive.aspx.cs" Inherits="ProjectASP.QnFive" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ProjectMaster" runat="server">
    <p>
        Qn 5. <span style="color: rgb(0, 0, 0); font-family: arial; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">For which of the following disciplines is Nobel Prize awarded</span></p>
    <p>
        <asp:RadioButtonList ID="rdbtnQn5" runat="server">
            <asp:ListItem Value="A">Physics and Chemistry</asp:ListItem>
            <asp:ListItem Value="B">Physiology or Medicine</asp:ListItem>
            <asp:ListItem Value="C">Literature, Peace and Economics</asp:ListItem>
            <asp:ListItem Value="D">All of the above</asp:ListItem>
        </asp:RadioButtonList>
    </p>
    <p>
        <asp:Button ID="btnQn4" runat="server" OnClick="btnQn4_Click" Text="Next" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
