<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBranch.aspx.cs" Inherits="Interview.WebUI.AddBranch" Theme="MySkin"%>

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
                width: 346px;
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
             <table class="auto-style1">
                 <tr>
                     <td class="auto-style2">
                         <br />
                         <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="Black" Text="Branch Name"></asp:Label>
                         <br />
                         <br />
                     </td>
                     <td>
                         <br />
                         <asp:TextBox ID="txtBname" runat="server"></asp:TextBox>
                         <br />
                         <br />
                     </td>
                 </tr>
             </table>
             <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert" CssClass="btn btn-primary" />
             <br />
             <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
             <asp:GridView ID="gvBranch" runat="server" OnRowCancelingEdit="gvBranch_RowCancelingEdit" OnRowDeleting="gvBranch_RowDeleting" OnRowEditing="gvBranch_RowEditing" OnRowUpdating="gvBranch_RowUpdating">
                 <Columns>
                     <asp:CommandField ShowEditButton="True" />
                     <asp:CommandField ShowDeleteButton="True" />
                 </Columns>
             </asp:GridView>
    </form>
</body>
</html>
