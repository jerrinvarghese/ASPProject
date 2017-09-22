<%@ Page Title="" Language="C#" MasterPageFile="~/Project.Master" AutoEventWireup="true" CodeBehind="MultiViewQuestions.aspx.cs" Inherits="ProjectASP.MultiViewQuestions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ProjectMaster" runat="server">
    <asp:MultiView ID="MultiView1" runat="server">

        <asp:View ID="View1" runat="server">
                  <h3>This is view 1</h3>
                  <br />
                   </asp:View> 
					
           </asp:MultiView>
</asp:Content>
