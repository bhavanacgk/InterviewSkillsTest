<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationPage.aspx.cs"
     Inherits="Interview.WebUI.RegistrationPage" MasterPageFile="~/Site1.Master" Theme="MySkin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top:50px;margin-left:630px;">
        <table class="auto-style1">
            <tr>
                <td colspan="3" style="text-align: center; font-size: large; font-weight: bold; font-variant: small-caps; color: #000000;">Registration Form<br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="font-size: medium; font-weight: bold; color: #000000; font-variant: small-caps">Username</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtName" runat="server" CssClass="form-group"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" Display="Dynamic" ErrorMessage="Please enter Username" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="font-size: medium; font-weight: bold; font-variant: small-caps; color: #000000">E-Mail </td>
                <td>
                    <asp:TextBox ID="txtMail" runat="server" TextMode="Email" CssClass="form-group"></asp:TextBox>
                </td> 
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="font-size: medium; font-weight: bold; font-variant: small-caps; color: #000000">Password</td>
                <td>
                    <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" CssClass="form-group"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPwd" Display="Dynamic" ErrorMessage="Please enter your password" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="font-size: medium; font-weight: bold; font-variant: small-caps; color: #000000">Mobile No.</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtMobile" runat="server" TextMode="Number" CssClass="form-group"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtMobile" Display="Dynamic" ErrorMessage="Please enter your contact number" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="font-variant: small-caps; color: #000000; font-size: medium; font-weight: bold; height: 27px;">Gender</td>
                <td class="auto-style2" style="height: 27px">
                    <asp:RadioButton ID="radMale" runat="server" GroupName="rad" Text="Male" Checked="True" CssClass="form-group" Font-Bold="True" Font-Size="Medium" ForeColor="Black" />
                    <asp:RadioButton ID="radFemale" runat="server" GroupName="rad" Text="Female" CssClass="form-group" Font-Bold="True" Font-Size="Medium" ForeColor="Black" />
                </td>
                <td class="auto-style2" style="height: 27px"></td>
            </tr>
            <tr>
                <td style="font-size: medium; font-weight: bold; font-variant: small-caps; color: #000000">Date Of Birth</td>
                <td>
                    <asp:TextBox ID="txtDob" runat="server" TextMode="Date" CssClass="form-group"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="font-size: medium; font-weight: bold; font-variant: small-caps; color: #000000">Address</td>
                <td>
                    <asp:TextBox ID="txtAdr" runat="server" TextMode="MultiLine" CssClass="form-group"></asp:TextBox>
                    <br />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" CssClass="btn btn-primary" Font-Bold="True" Font-Size="Medium" Height="33px" Width="104px" />
                    <br />
                    <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
                    <br />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
