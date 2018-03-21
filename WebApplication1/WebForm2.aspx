<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

	
	
	
	<style type="text/css">
		.auto-style4 {
			margin-left: 181px;
		}
		.auto-style5 {
			width: 425px;
			margin-left: 428px;
		}
		.auto-style6 {
			margin-left: 51px;
			margin-top: 0px;
		}
		.auto-style7 {
			margin-left: 68px;
		}
	</style>

	
	
	
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
	<asp:PlaceHolder ID="PlaceHolder1" runat="server">
<asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
	<asp:Button ID="Button2" runat="server" BackColor="#0099FF" BorderColor="Red" Font-Bold="true"  BorderStyle="Double" CssClass="auto-style4" OnClick="Button2_Click" Text="Add Item To Cart" Height="42px" Width="150px" ForeColor="Yellow"/>

		
	</asp:PlaceHolder>

	<asp:Button ID="Button4" runat="server" Text="MAIN MENU"  Height="42px" Width="150px" BackColor="Maroon" CssClass="auto-style7" Font-Bold="True" ForeColor="#33CCFF" PostBackUrl="~/ViewItems.aspx" />
	<asp:Button ID="Button3" runat="server" BackColor="Yellow" BorderColor="Red" CssClass="auto-style6" Height="42px" PostBackUrl="~/WebForm6.aspx" Text="Log In Please" visible="False" Width="150px" Font-Bold="True" ForeColor="Red" />
	<br />
&nbsp;<div id="Message" runat="server" class="auto-style5" style="border: thick solid #FF00FF; background-color: #00FFFF; font-family: 'Miriam Fixed'; font-size: xx-large; color: #000000; text-decoration: blink" visible="False">
	</div>
	<div></div>
	
	<asp:Image ID="Image1" runat="server"  />
</asp:Content>
