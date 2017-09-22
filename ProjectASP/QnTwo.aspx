<%@ Page Title="" Language="C#" MasterPageFile="~/Project.Master" AutoEventWireup="true" CodeBehind="QnTwo.aspx.cs" Inherits="ProjectASP.QnTwo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ProjectMaster" runat="server">
    <p>
        Qn 2. <span style="color: rgb(0, 0, 0); font-family: arial; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Entomology is the science that studies</span></p>
    <p>
        <asp:RadioButtonList ID="rdbtnQn2" runat="server">
            <asp:ListItem Value="A">Behavior of human beings</asp:ListItem>
            <asp:ListItem Value="B">Insects</asp:ListItem>
            <asp:ListItem Value="C">The origin and history of technical and scientific terms</asp:ListItem>
            <asp:ListItem Value="D">The formation of rocks</asp:ListItem>
        </asp:RadioButtonList>
    </p>
    <p>
        <asp:Button ID="btnQn2" runat="server" OnClick="btnQn2_Click" Text="Next" />
    </p>
</asp:Content>
