<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="books.aspx.cs" Inherits="library_system.WebForm1" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <form id="form1" runat="server">
        <table style="width: 100%; height: 536px">
            <tr>
                <td style="width: 199px; height: 183px"></td>
                <td style="width: 516px; height: 183px">
                    <asp:Label ID="Label1" runat="server" Text="Departments"></asp:Label>
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td style="height: 183px"></td>
            </tr>
            <tr>
                <td style="width: 199px; height: 151px"></td>
                <td style="width: 516px; height: 151px">
                    <asp:Label ID="Label2" runat="server" Text="Books"></asp:Label>
                    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td style="height: 151px"></td>
            </tr>
            <tr>
                <td style="width: 199px; height: 55px;"></td>
                <td style="width: 516px; height: 55px;">
                    <br />
                    <asp:Label ID="Label10" runat="server" Text="Book ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox5" runat="server" ReadOnly="True" Width="201px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Book Title"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter Book Name" Width="201px"></asp:TextBox>
                </td>
                <td style="height: 55px"></td>
            </tr>
            <tr>
                <td style="width: 199px; height: 29px;"></td>
                <td style="width: 516px; height: 29px;">
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Number Of Pages"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox2" runat="server" placeholder="Enter Number Of Pages" Width="201px"></asp:TextBox>
                </td>
                <td style="height: 29px"></td>
            </tr>
            <tr>
                <td style="width: 199px; height: 24px"></td>
                <td style="width: 516px; height: 24px">
                    <asp:Label ID="Label6" runat="server" Text="Date"></asp:Label>
                    <asp:TextBox ID="TextBox4" runat="server" placeholder="Enter Date" Width="201px"></asp:TextBox>
                    <asp:ImageButton  ID="ImageButton1" runat="server" ImageUrl="iconCalendar.gif" OnClick="ImageButton1_Click" />
                </td>
                <td style="height: 24px">
                    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                        <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                        <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                        <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                        <TodayDayStyle BackColor="#CCCCCC" />
                    </asp:Calendar>
                </td>
            </tr>
            <tr>
                <td style="width: 199px">&nbsp;</td>
                <td style="width: 516px">
                    <asp:Label ID="Label7" runat="server" Text="Department "></asp:Label>
                    <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
                    </asp:DropDownList>
                    <br />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 199px">&nbsp;</td>
                <td style="width: 516px">
                    <asp:Label ID="Label8" runat="server" Text="Publisher "></asp:Label>
                    <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged">
                    </asp:DropDownList>
                    <br />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="height: 28px; width: 199px"></td>
                <td style="height: 28px; width: 516px">
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Save" Width="75px" OnClick="Button1_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Update" Width="75px" OnClick="Button2_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" Text="Delete" Width="75px" OnClick="Button3_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Clear" Width="75px" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Delete All" />
                    <br />
                    <br />
                    <asp:Label ID="Label9" runat="server"></asp:Label>
                    <br />
                </td>
                <td style="height: 28px"></td>
            </tr>
        </table>
    </form>
</asp:Content>

