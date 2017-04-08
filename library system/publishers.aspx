<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="publishers.aspx.cs" Inherits="library_system.publishers" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <form id="form1" runat="server">
        <table style="width: 100%; height: 426px">
            <tr>
                <td style="width: 280px">&nbsp;</td>
                <td style="width: 536px">
                    <asp:Label ID="Label1" runat="server" Text="Publishers"></asp:Label>
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 280px">&nbsp;</td>
                <td style="width: 536px">
                    <asp:Label ID="Label6" runat="server" Text="Pub ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox5" runat="server" ReadOnly="True" Width="201px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Publ. Title"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter publisher Name" Width="201px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 280px; height: 40px;"></td>
                <td style="width: 536px; height: 40px;">
                    <asp:Label ID="Label3" runat="server" Text="Address"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox2" runat="server" placeholder="Enter Address" Width="201px"></asp:TextBox>
                </td>
                <td style="height: 40px"></td>
            </tr>
            <tr>
                <td style="width: 280px">&nbsp;</td>
                <td style="width: 536px">
                    <asp:Label ID="Label4" runat="server" Text="Mobile"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox3" runat="server" placeholder="Enter Mobile" Width="201px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 280px">&nbsp;</td>
                <td style="width: 536px">
                    <asp:Label ID="Label5" runat="server" Text="Web Site"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox4" runat="server" placeholder="Enter Web Site" Width="201px" TextMode="Email"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 280px">&nbsp;</td>
                <td style="width: 536px">
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
                    <asp:Label ID="Label7" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 280px">&nbsp;</td>
                <td style="width: 536px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</asp:Content>

