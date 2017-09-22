<%@ Page Title="" Language="C#" MasterPageFile="~/Project.Master" AutoEventWireup="true" CodeBehind="QnThree.aspx.cs" Inherits="ProjectASP.QnThree" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ProjectMaster" runat="server">
    <p>
        Qn 3. <span style="color: rgb(0, 0, 0); font-family: arial; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Eritrea, which became the 182nd member of the UN in 1993, is in the continent of</span></p>
    <p>
        <asp:RadioButtonList ID="rdbtnQn3" runat="server">
            <asp:ListItem Value="A">Asia</asp:ListItem>
            <asp:ListItem Value="B">Africa</asp:ListItem>
            <asp:ListItem Value="C">Europe</asp:ListItem>
            <asp:ListItem Value="D">Australia</asp:ListItem>
        </asp:RadioButtonList>
    </p>
    <p>
        <asp:Button ID="btnQn3" runat="server" OnClick="btnQn3_Click" style="width: 41px" Text="Next" />
    </p>
</asp:Content>
