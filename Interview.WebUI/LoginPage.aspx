<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs"
     Inherits="Interview.WebUI.LoginPage" MasterPageFile="~/Site1.Master" Theme="MySkin"%>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">        
   <div style="margin-top:100px;margin-left:630px;">
        <table class="auto-style1">
            <tr>
                <td colspan="3" style="text-align: center; font-weight: bold; font-variant: small-caps; color: #000000; font-size: large;">Login Form<br />
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="font-weight: bold; color: #000000; font-variant: small-caps; font-size: medium;">Username</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtUname" runat="server" CssClass="form-group"></asp:TextBox>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style4" style="font-weight: bold; font-variant: small-caps; color: #000000; height: 28px; font-size: medium;">Password</td>
                <td class="auto-style6" style="height: 28px">
                    <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td style="height: 28px">
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="3">
                   <asp:Button ID="btnSignin" runat="server" Text="Login" OnClick="btnSignin_Click" CssClass="btn btn-primary" Font-Bold="True" Font-Size="Medium" Width="91px" />
                    <br />
                    <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>    
    </div>
</asp:Content>
