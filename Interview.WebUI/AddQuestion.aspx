<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddQuestion.aspx.cs" Inherits="Interview.WebUI.AddQuestion" Theme="MySkin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Interview Skills Test</title>
		<style> 
			* { 
				box-sizing: border-box; 
			} 
			
			/* CSS property for header section */ 
			.header { 
				background-color: green; 
				padding: 15px; 
				text-align: center; 
			} 
			
			  /* CSS property for nevigation menu */ 
            .nav_menu { 
                overflow: hidden; 
                background-color: #333; 
            } 
            .nav_menu a { 
                float: left; 
                display: block; 
                color: white; 
                text-align: center; 
                padding: 14px 16px; 
                text-decoration: none; 
            } 
            .nav_menu a:hover { 
                background-color: white; 
                color: green; 
            } 
              
			
			/* CSS property for content section */ 
			.columnA, .columnB, .columnC { 
				float: left; 
				width: 31%; 
				padding: 15px; 
				text-align:justify; 
			} 
			h2 { 
				color:green; 
				text-align:center; 
			} 
			
			/* Media query to set website layout 
			according to screen size */ 
			@media screen and (max-width:600px) { 
				.columnA, .columnB, .columnC { 
					width: 50%; 
				} 
			} 
			@media screen and (max-width:400px) { 
				.columnA, .columnB, .columnC { 
					width: 100%; 
				} 
			} 
		    .auto-style1 {
                width: 100%;
            }
            .auto-style2 {
                width: 374px;
            }
		    .auto-style3 {
                width: 374px;
                height: 26px;
            }
            .auto-style4 {
                height: 26px;
            }
		    .auto-style5 {
                width: 374px;
                height: 48px;
            }
            .auto-style6 {
                height: 48px;
            }
		</style> 
	</head> 
	
	<body style="background-color:lightgreen"> 
		 <form id="form1" runat="server">
		<!-- header of website layout -->
		<div class = "header"> 
			<h2 style = "color:white;font-size:200%; font-weight: bolder;"> 
				Interview Skills Test
			</h2> 
		</div>
             <div>

                 <table class="auto-style1">
                     <tr>
                         <td class="auto-style2">
                             <br />
                             <asp:Label ID="Label2" runat="server" Text="Topic" Font-Bold="True" Font-Size="Medium" ForeColor="Black"></asp:Label>
                             <br />
                             <br />
                         </td>
                         <td>
                             <br />
                             <asp:DropDownList ID="ddlTopic" runat="server">
                             </asp:DropDownList>
                             <br />
                             <br />
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style5">
                             <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="Black" Text="Question"></asp:Label>
                             <br />
                             <br />
                         </td>
                         <td class="auto-style6">
                             <asp:TextBox ID="txtQues" runat="server" TextMode="MultiLine"></asp:TextBox>
                             <br />
                             <br />
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style2">
                             <asp:Label ID="Label3" runat="server" Text="Choice1" Font-Bold="True" Font-Size="Medium" ForeColor="Black"></asp:Label>
                             <br />
                             <br />
                         </td>
                         <td>
                             <asp:TextBox ID="txtChoice1" runat="server"></asp:TextBox>
                             <br />
                             <br />
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style2">
                             <asp:Label ID="Label4" runat="server" Text="Choice2" Font-Bold="True" Font-Size="Medium" ForeColor="Black"></asp:Label>
                             <br />
                             <br />
                         </td>
                         <td>
                             <asp:TextBox ID="txtChoice2" runat="server"></asp:TextBox>
                             <br />
                             <br />
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style2">
                             <asp:Label ID="Label5" runat="server" Text="Choice3" Font-Bold="True" Font-Size="Medium" ForeColor="Black"></asp:Label>
                             <br />
                             <br />
                         </td>
                         <td>
                             <asp:TextBox ID="txtChoice3" runat="server"></asp:TextBox>
                             <br />
                             <br />
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style2">
                             <asp:Label ID="Label6" runat="server" Text="Choice4" Font-Bold="True" Font-Size="Medium" ForeColor="Black"></asp:Label>
                             <br />
                             <br />
                         </td>
                         <td>
                             <asp:TextBox ID="txtChoice4" runat="server"></asp:TextBox>
                             <br />
                             <br />
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style2">
                             <asp:Label ID="Label7" runat="server" Text="Answer" Font-Bold="True" Font-Size="Medium" ForeColor="Black"></asp:Label>
                             <br />
                             <br />
                         </td>
                         <td>
                             <asp:TextBox ID="txtAnswer" runat="server"></asp:TextBox>
                             <br />
                             <br />
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style3">
                             <asp:Label ID="Label8" runat="server" Text="TSeries" Font-Bold="True" Font-Size="Medium" ForeColor="Black"></asp:Label>
                             <br />
                             <br />
                         </td>
                         <td class="auto-style4">
                             <asp:TextBox ID="txtTseries" runat="server"></asp:TextBox>
                             <br />
                             <br />
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style3">
                             <asp:Label ID="Label9" runat="server" Text="Hint" Font-Bold="True" Font-Size="Medium" ForeColor="Black"></asp:Label>
                             <br />
                             <br />
                         </td>
                         <td class="auto-style4">
                             <asp:TextBox ID="txtHint" runat="server" TextMode="MultiLine"></asp:TextBox>
                             <br />
                             <br />
                         </td>
                     </tr>
                 </table>

             </div>
             <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert" CssClass="btn btn-primary" />
             <br />
             <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>

    </form>
</body>
</html>
