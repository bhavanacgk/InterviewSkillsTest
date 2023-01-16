<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLoginPage.aspx.cs" 
    Inherits="Interview.WebUI.AdminLoginPage" MasterPageFile="~/Site1.Master"  Theme="MySkin"%>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">        
    <div style="margin-top:100px;margin-left:630px;">
        <table class="auto-style1">
            <tr>
                <td colspan="3" style="text-align: center; font-size: large; font-weight: bold; font-variant: small-caps; color: #000000;">Login Form<br />
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="font-weight: bold; color: #000000; font-variant: small-caps; height: 50px; font-size: medium;">Username</td>
                <td class="auto-style5" style="height: 50px">
                    <asp:TextBox ID="txtUname" runat="server" CssClass="form-group"></asp:TextBox>
                </td>
                <td class="auto-style2" style="height: 50px">
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style4" style="font-weight: bold; font-variant: small-caps; color: #000000; font-size: medium;">Password</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" CssClass="form-group"></asp:TextBox>
                </td>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="3">
                    <asp:Button ID="btnSignin" runat="server" Text="Login" OnClick="btnSignin_Click" CssClass="btn btn-primary" Font-Bold="True" Font-Size="Medium" Width="84px" />
                    <br />
                    <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>    
    </div>
</asp:Content>