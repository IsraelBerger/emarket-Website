<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AllProducts.aspx.cs" Inherits="WebApplication1.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	
	
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<asp:GridView id="grid" style="width:1100px" runat="server" Font-Italic="true" BackColor="#ff6666" BorderStyle="Ridge" BorderWidth="2"></asp:GridView>
	
	<br />
	<asp:PlaceHolder ID="PlaceHolder1" runat="server">

	</asp:PlaceHolder>
	
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
	
	
</asp:Content>

