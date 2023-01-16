<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TakeTest.aspx.cs" Inherits="Interview.WebUI.TakeTest" MasterPageFile="~/Exam.Master" Theme="MySkin" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">

        <table style="width: 100%">
            <tr>
                <td style="height: 331px; width: 1269px">
                    <div style="border:groove" border-color: inherit; border-width: medium; height: 342px;>
                    &nbsp;<asp:Label ID="lblSno" runat="server" Text="Label" Font-Bold="True" Font-Size="Medium" ForeColor="Black"></asp:Label>
                        &nbsp;
                    <asp:Label ID="lblQuestion" runat="server" Text="Label" Font-Bold="True" Font-Size="Medium" ForeColor="Black"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <br />
                    &nbsp;<asp:RadioButton ID="rbtnChoice1" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="Black" AutoPostBack="True" GroupName="radChoice" OnCheckedChanged="rbtnChoice1_CheckedChanged"/>
                    <br />
                    <br />
                    &nbsp;<asp:RadioButton ID="rbtnChoice2" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="Black" AutoPostBack="True" GroupName="radChoice" OnCheckedChanged="rbtnChoice2_CheckedChanged" />
                    <br />
                    <br />
                    &nbsp;<asp:RadioButton ID="rbtnChoice3" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="Black" AutoPostBack="True" GroupName="radChoice" OnCheckedChanged="rbtnChoice3_CheckedChanged" />
                    <br />
                    <br />
                    &nbsp;<asp:RadioButton ID="rbtnChoice4" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="Black" AutoPostBack="True" GroupName="radChoice" OnCheckedChanged="rbtnChoice4_CheckedChanged" />
                    <br />
                    <br />
                    <br />
                    <br />
                    &nbsp;<asp:Button ID="btnSaveAndNext" runat="server" CssClass="btn btn-primary" Text="Save and Next" OnClick="btnSaveAndNext_Click" Font-Bold="True" Font-Size="Medium" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnPrev" runat="server" CssClass="btn btn-primary" Text="Previous" OnClick="btnPrev_Click1" Font-Bold="True" Font-Size="Medium" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-primary" Text="Submit" OnClick="btnSubmit_Click" Font-Bold="True" Font-Size="Medium" />
                        <br />
                        <br />
                        </div>
                </td>
                
                <td style="height: 331px">
                    
                    <div>
                   
                        <br />
                        <br />
                        <br />
                        <br />
&nbsp;&nbsp;<asp:Button ID="btnQues1" runat="server" CssClass="btn btn-primary" Text="1" Width="35px" OnClick="btnQues1_Click" Font-Bold="True" Font-Size="Medium" />
&nbsp;&nbsp;
                    <asp:Button ID="btnQues2" runat="server" CssClass="btn btn-primary" Text="2" Width="35px" OnClick="btnQues2_Click" Font-Bold="True" Font-Size="Medium" />
&nbsp;&nbsp;
                    <asp:Button ID="btnQues3" runat="server" CssClass="btn btn-primary" Text="3" Width="35px" OnClick="btnQues3_Click" Font-Bold="True" Font-Size="Medium" />
&nbsp;&nbsp;
                    <asp:Button ID="btnQues4" runat="server" CssClass="btn btn-primary" Text="4" Width="35px" OnClick="btnQues4_Click" Font-Bold="True" Font-Size="Medium" />
&nbsp;&nbsp; <asp:Button ID="btnQues5" runat="server" CssClass="btn btn-primary" Text="5" Width="35px" OnClick="btnQues5_Click1" Font-Bold="True" Font-Size="Medium" />
                        &nbsp;
                        <br />
                        <br />
                        &nbsp; <asp:Button ID="btnQues6" runat="server" CssClass="btn btn-primary" Text="6" Width="35px" OnClick="btnQues6_Click" Font-Bold="True" Font-Size="Medium" />
&nbsp;&nbsp;
                    <asp:Button ID="btnQues7" runat="server" CssClass="btn btn-primary" Text="7" Width="35px" OnClick="btnQues7_Click" Font-Bold="True" Font-Size="Medium" />
&nbsp;&nbsp;
                    <asp:Button ID="btnQues8" runat="server" CssClass="btn btn-primary" Text="8" Width="35px" OnClick="btnQues8_Click" Font-Bold="True" Font-Size="Medium" />
&nbsp;&nbsp;
                    <asp:Button ID="btnQues9" runat="server" CssClass="btn btn-primary" Text="9" Width="35px" OnClick="btnQues9_Click" Font-Bold="True" Font-Size="Medium" />
&nbsp; &nbsp;<asp:Button ID="btnQues10" runat="server" CssClass="btn btn-primary" Text="10" Width="35px" OnClick="btnQues10_Click" Font-Bold="True" Font-Size="Medium" />
                      
                        <br />
                        <br />
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label ID="Label1" runat="server" Text="TimeLeft:" Font-Bold="True" Font-Size="Medium" ForeColor="Black"></asp:Label>
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="Black"></asp:Label>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Timer1"  />
            </Triggers>
        </asp:UpdatePanel>
        <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick"></asp:Timer>


                        <br />
                      
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                         </div>
                        </td>
                     
            </tr>
            <tr>
                <td style="height: 352px; width: 1269px">&nbsp;</td>
                <td style="height: 352px"></td>
            </tr>
        </table>
        <asp:GridView ID="gvTest" runat="server">

        </asp:GridView>
        </form>
    </asp:Content>