<%@ Page Title="" Language="C#" MasterPageFile="~/Project.Master" AutoEventWireup="true" CodeBehind="QnFour.aspx.cs" Inherits="ProjectASP.QnFour" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ProjectMaster" runat="server">
    <p>
        Qn 4. <span style="color: rgb(0, 0, 0); font-family: arial; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Garampani sanctuary is located at</span></p>
    <p>
        <asp:RadioButtonList ID="rdbtnQn4" runat="server">
            <asp:ListItem Value="A">Junagarh, Gujarat</asp:ListItem>
            <asp:ListItem Value="B">Diphu, Assam</asp:ListItem>
            <asp:ListItem Value="C">Kohima, Nagaland</asp:ListItem>
            <asp:ListItem Value="D">Gangtok, Sikkim</asp:ListItem>
        </asp:RadioButtonList>
    </p>
    <p>
        <asp:Button ID="btnQn4" runat="server" OnClick="btnQn4_Click" Text="Next" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
