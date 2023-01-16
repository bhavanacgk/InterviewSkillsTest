<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="Interview.WebUI.AboutUs" Theme="MySkin" %>

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
		</style> 
</head>
<body style="background-image:url(~\images\img7.jpg);background-color:lightgreen;background-size:cover;">
    <form id="form1" runat="server" style="font-style: normal; color: #000000; font-size: medium;">
    <!-- header of website layout -->
		<div class = "header"> 
			<h2 style = "color:white;font-size:200%; font-weight: bolder;"> 
				Interview Skills Test
			</h2> 
        </div><br/> 
        <asp:Label ID="lblMsg" runat="server" ForeColor="#990000" Text="About Us:" Font-Bold="True" Font-Size="Large" Font-Underline="True"></asp:Label>
        <br />
        <br />
        We are the students of Narasaraopeta Engineering College, Narasaraopet. For any further details and doubts regarding our website please contact us
        through the information provided here.<br />
        <h4 style="font-size: medium; font-weight: bold; color: #000000">Bhavana Gaddam(17471A0597) - B.Tech 3rd year</h4>
           e-mail.:bhavanagaddam15@gmail.com<br />
           contact number.:7036904800       
        <h4 style="font-weight: bold; font-size: medium; color: #000000">Asha Kankanampati(17471A0583) - B.Tech 3rd year</h4>
        e-mail.:ashakankanampati30@gmail.com<br/>
           contact number.:7093729728        
        <h4 style="font-size: medium; font-weight: bold; color: #000000">Vasanthi Lakshmi Maguluri(17471A05B7) - B.Tech 3rd year</h4>
        e-mail.:magulurivasanthilakshmi@gmail.com<br />
           contact number.:9703783551
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Font-Underline="True" ForeColor="#990000" Text="NOTE:"></asp:Label>
        <br />
        <br/>
        <p style="color: #000000; font-weight: normal; font-style: normal;">The information given in this website is collected from various unknown websites and other unknown books.
            The information provided in this website has completely verified by the various subject experts and professors.
             And the details given here are true.</p>
    </form>
</body>
</html>
