<%@ Page Title="" Language="C#" MasterPageFile="~/Project.Master" AutoEventWireup="true" CodeBehind="QuestionPage.aspx.cs" Inherits="ProjectASP.QuestionPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ProjectMaster" runat="server">
    <asp:MultiView ID="MultiView1" runat="server">
        <asp:View ID="Qn1" runat="server">
            <p>Qn 1. How many states are there in India?</p>
            <p>
    
            <asp:RadioButtonList ID="rdbtnQn1" runat="server">

            </asp:RadioButtonList>
                </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Button ID="btnPreviousQn1" runat="server" Text="Previous" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnNextQn1" runat="server" OnClick="btnNextQn1_Click" Text="Next" />
            </p>
        </asp:View>
        <asp:View ID="Qn2" runat="server">
            <p>Qn 2. Entomology is the science that studies?</p>
            <p>
    
            <asp:RadioButtonList ID="rdbtnQn2" runat="server">

            </asp:RadioButtonList>
                </p>
            <p>
                <asp:Button ID="btnPreviousQn2" runat="server" Text="Previous" />
                &nbsp;
                <asp:Button ID="btnNextQn2" runat="server" OnClick="btnNextQn2_Click" Text="Next" />
                </p>
            <p>
                
            </p>
        </asp:View>
        <asp:View ID="Qn3" runat="server">
            <p>Qn 3. Eritrea, which became the 182nd member of the UN in 1993, is in the continent of?</p>
            <p>
    
            <asp:RadioButtonList ID="rdbtnQn3" runat="server">

            </asp:RadioButtonList>
                </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Button ID="btnPreviousQn3" runat="server" Text="Previous" />
                &nbsp;
                <asp:Button ID="btnNextQn3" runat="server" Text="Next" OnClick="btnNextQn3_Click" />
            </p>
        </asp:View>
        <asp:View ID="Qn4" runat="server">
            <p>Qn 4. Garampani sanctuary is located at?</p>
            <p>
    
            <asp:RadioButtonList ID="rdbtnQn4" runat="server">

            </asp:RadioButtonList>
                </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Button ID="btnPreviousQn4" runat="server" Text="Previous" />
                &nbsp;
                <asp:Button ID="btnNextQn4" runat="server" Text="Next" OnClick="btnNextQn4_Click" />
            </p>
        </asp:View>
        <asp:View ID="Qn5" runat="server">
            <p>Qn 5. For which of the following disciplines is Nobel Prize awarded?</p>
            <p>
    
            <asp:RadioButtonList ID="rdbtnQn5" runat="server">

            </asp:RadioButtonList>
                </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Button ID="btnPreviousQn5" runat="server" Text="Previous" />
                &nbsp;
                <asp:Button ID="btnNextQn5" runat="server" Text="Next" OnClick="btnNextQn5_Click" />
            </p>
        </asp:View>
        <asp:View ID="Qn6" runat="server">
            <p>Qn 6. 5+6?</p>
            <p>
    
            <asp:RadioButtonList ID="rdbtnQn6" runat="server">

            </asp:RadioButtonList>
                </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Button ID="btnPreviousQn6" runat="server" Text="Previous" />
                &nbsp;
                <asp:Button ID="btnNextQn6" runat="server" Text="Next" OnClick="btnNextQn6_Click" />
            </p>
        </asp:View>
        <asp:View ID="Qn7" runat="server">
            <p>Qn 7. 120*5?</p>
            <p>
    
            <asp:RadioButtonList ID="rdbtnQn7" runat="server">

            </asp:RadioButtonList>
                </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Button ID="btnPreviousQn7" runat="server" Text="Previous" />
                &nbsp;
               <asp:Button ID="btnNextQn7" runat="server" Text="Next" OnClick="btnNextQn7_Click" />
            </p>
        </asp:View>
        <asp:View ID="Qn8" runat="server">
            <p>Qn 8. 120/2?</p>
            <p>
    
            <asp:RadioButtonList ID="rdbtnQn8" runat="server">

            </asp:RadioButtonList>
                </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Button ID="btnPreviousQn8" runat="server" Text="Previous" />
                &nbsp;
               <asp:Button ID="btnNextQn8" runat="server" Text="Next" OnClick="btnNextQn8_Click" />
            </p>
        </asp:View>
        <asp:View ID="Qn9" runat="server">
            <p>Qn 9. 60+2?</p>
            <p>
    
            <asp:RadioButtonList ID="rdbtnQn9" runat="server">

            </asp:RadioButtonList>
                </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Button ID="btnPreviousQn9" runat="server" Text="Previous" />
                &nbsp;
               <asp:Button ID="btnNextQn9" runat="server" Text="Button" OnClick="btnNextQn9_Click" />
            </p>
        </asp:View>
        <asp:View ID="Qn10" runat="server">
            <p>Qn 10. 69+1?</p>
            <p>
    
            <asp:RadioButtonList ID="rdbtnQn10" runat="server">

            </asp:RadioButtonList>
                </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Button ID="btnPreviousQn10" runat="server" Text="Previous" />
                &nbsp;
               <asp:Button ID="btnNextQn10" runat="server" Text="Next" OnClick="btnNextQn10_Click" />
            </p>
        </asp:View>
    </asp:MultiView>
</asp:Content>
