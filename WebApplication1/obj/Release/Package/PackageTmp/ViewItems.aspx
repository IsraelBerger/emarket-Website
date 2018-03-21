<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ViewItems.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	

	<style type="text/css">
		#hello2 {
			margin-bottom: 83px;
		}
		.auto-style6 {
			margin-left: 419px;
			margin-top: 0px;
			margin-bottom: 0px;
		}
	.auto-style7 {
		margin-left: 0px;
	}
	</style>
	

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div id="hello2" runat="server" class="auto-style7">
		
		
		<asp:Literal ID="Literal1" runat="server"></asp:Literal>
			<br />
			<asp:Button ID="Veiw" runat="server" Text="VIEW ITEMS" OnClick="Veiw_Click" CssClass="auto-style6" Height="55px" Width="187px" />
<asp:Button ID="LogIn" runat="server" OnClick="LogIn_Click" CssClass="auto-style5" Font-Bold="True" ForeColor="#3333CC" Text="Log In" Height="66px" Width="100px" PostBackUrl="~/WebForm6.aspx" />
		<br />
	
			</div>
	
	
	<div id="Div1" runat="server"  style="color: #33CC33; background-color: violet"></div>
	
	<div id="Div2" runat="server" style="background-color:cadetblue">

		<asp:Label ID="Label1" runat="server" Text="Welcome and sign in please" ></asp:Label>		

	</div>
	<div id="Div3" runat="server"  style="background-color: #00ffff"></div>
	<div id="Div4" runat="server" style="background-color:aqua" ></div>
	<asp:PlaceHolder ID="PlaceHolder1" runat="server" ></asp:PlaceHolder>
	<asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
	<asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="ContentPlaceHolder3">
	
</asp:Content>

