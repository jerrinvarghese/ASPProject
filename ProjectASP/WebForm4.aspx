<%@ Page Title="" Language="C#" MasterPageFile="~/Project.Master" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="ProjectASP.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ProjectMaster" runat="server">
    <asp:MultiView ID="MultiView1" runat="server">

        <asp:View ID="Qn1" runat="server">
            <table class="Qn">
                <tr>
                    <td>
                       Qn1 <asp:Label ID="lblQn1" runat="server">  </asp:Label>                    
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:RadioButtonList ID="rdbtnQn1" runat="server">
                            <asp:ListItem Value="A"></asp:ListItem>
                            <asp:ListItem Value="B"></asp:ListItem>
                            <asp:ListItem Value="C"></asp:ListItem>
                            <asp:ListItem Value="D"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
            </table>
        </asp:View>
        <asp:View ID="Qn2" runat="server">
            <table class="Qn">
                <tr>
                    <td>
                       Qn2 <asp:Label ID="lblQn2" runat="server">  </asp:Label>                    
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:RadioButtonList ID="rdbtnQn2" runat="server">
                            <asp:ListItem Value="A"></asp:ListItem>
                            <asp:ListItem Value="B"></asp:ListItem>
                            <asp:ListItem Value="C"></asp:ListItem>
                            <asp:ListItem Value="D"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
            </table>
        </asp:View>
        <asp:View ID="Qn3" runat="server">
            <table class="Qn">
                <tr>
                    <td>
                       Qn3 <asp:Label ID="lblQn3" runat="server">  </asp:Label>                    
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:RadioButtonList ID="rdbtnQn3" runat="server">
                            <asp:ListItem Value="A"></asp:ListItem>
                            <asp:ListItem Value="B"></asp:ListItem>
                            <asp:ListItem Value="C"></asp:ListItem>
                            <asp:ListItem Value="D"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
            </table>
        </asp:View>
        <asp:View ID="Qn4" runat="server">
            <table class="Qn">
                <tr>
                    <td>
                       Qn4 <asp:Label ID="lblQn4" runat="server">  </asp:Label>                    
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:RadioButtonList ID="rdbtnQn4" runat="server">
                            <asp:ListItem Value="A"></asp:ListItem>
                            <asp:ListItem Value="B"></asp:ListItem>
                            <asp:ListItem Value="C"></asp:ListItem>
                            <asp:ListItem Value="D"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
            </table>
        </asp:View>
        <asp:View ID="Qn5" runat="server">
            <table class="Qn">
                <tr>
                    <td>
                       Qn5 <asp:Label ID="lblQn5" runat="server">  </asp:Label>                    
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:RadioButtonList ID="rdbtnQn5" runat="server">
                            <asp:ListItem Value="A"></asp:ListItem>
                            <asp:ListItem Value="B"></asp:ListItem>
                            <asp:ListItem Value="C"></asp:ListItem>
                            <asp:ListItem Value="D"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
            </table>
        </asp:View>
        <asp:View ID="Qn6" runat="server">
            <table class="Qn">
                <tr>
                    <td>
                       Qn6 <asp:Label ID="lblQn6" runat="server">  </asp:Label>                    
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:RadioButtonList ID="rdbtnQn6" runat="server">
                            <asp:ListItem Value="A"></asp:ListItem>
                            <asp:ListItem Value="B"></asp:ListItem>
                            <asp:ListItem Value="C"></asp:ListItem>
                            <asp:ListItem Value="D"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
            </table>
        </asp:View>

        <asp:View ID="Qn7" runat="server">
            <table class="Qn">
                <tr>
                    <td>
                       Qn7 <asp:Label ID="lblQn7" runat="server">  </asp:Label>                    
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:RadioButtonList ID="rdbtnQn7" runat="server">
                            <asp:ListItem Value="A"></asp:ListItem>
                            <asp:ListItem Value="B"></asp:ListItem>
                            <asp:ListItem Value="C"></asp:ListItem>
                            <asp:ListItem Value="D"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
            </table>
        </asp:View>

    </asp:MultiView>
</asp:Content>
