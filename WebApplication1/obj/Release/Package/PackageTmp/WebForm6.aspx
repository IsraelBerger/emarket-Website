<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="WebApplication1.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	
							<table cellpadding="1" cellspacing="0" style="border-collapse:collapse; " >
								<tr >
							
									<td class="auto-style4" >
										<table cellpadding="0"  >
											<tr>
												<td align="center" colspan="2" style="color:White;background-color:#6B696B;font-weight:bold;">Log In</td>
											</tr>
											<tr>
												<td align="right">
													<asp:Label ID="UserNameL" runat="server"  style="font-family: Century; font-size: inherit; color: #660033; text-decoration: blink; background-color: #0099FF;">User Name:</asp:Label>
												</td>
												<td>
													<asp:TextBox id="name" runat="server" background-color="Aqua" bordercolor="#0099FF" forecolor="#33CCFF" style="background-color: #00FFFF" />
												</td>
											</tr>
											<tr>
												<td align="right" style="font-family: Century; font-size: inherit; color: #660033; text-decoration: blink; background-color: #0099FF;">
													<asp:Label ID="AdrressL" runat="server" >Address:</asp:Label>
												</td>
												<td>
													<asp:TextBox ID="Adrress" runat="server" BackColor="Aqua" BorderColor="#0099FF" ForeColor="#33CCFF"></asp:TextBox>
													</td>
											</tr>
												<tr>
												<td align="right" style="font-family: Century; font-size: inherit; color: #660033; text-decoration: blink; background-color: #0099FF;">
													<asp:Label ID="PostCodeL" runat="server" >PostCode:</asp:Label>
												</td>
												<td>
													<asp:TextBox ID="PostCode" runat="server" BackColor="Aqua" BorderColor="#0099FF" ForeColor="#33CCFF"></asp:TextBox>
													</td>
											</tr>
											<tr>
												<td align="right" style="font-family: Century; font-size: inherit; color: #660033; text-decoration: blink; background-color: #0099FF;">
													<asp:Label ID="CountryL" runat="server" >Country:</asp:Label>
												</td>
												<td>
													<asp:TextBox ID="Country" runat="server" BackColor="Aqua" BorderColor="#0099FF" ForeColor="#33CCFF"></asp:TextBox>
													</td>
											</tr>
											
											<tr>
												<td colspan="2">
													<asp:CheckBox ID="RememberMe" runat="server" Text="Remember Me" />
												</td>
											</tr>
											<tr>
												<asp:Label runat="server" ID="FeedBack" align="center"   colspan="2" style="color:Red;">&nbsp;</asp:Label>
											</tr>
											<tr>
												<td align="right" colspan="2">
													<asp:Button ID="LoginButton" runat="server" OnClick="SubmitForm"  Text="Log In"  />
												</td>
											</tr>
										</table>
									</td>
								</tr>
									
							</table>
			<asp:Button ID="Veiw" runat="server" Text="MAIN MENU" OnClick="Veiw_Click" CssClass="auto-style6" Height="55px" Width="187px"  PostBackUrl="~/ViewItems.aspx" style="margin-left: 0px" />
	<div id="Div1" runat="server"  style="color: #33CC33; background-color: violet"></div>
	
	<div id="Div2" runat="server" style="background-color:cadetblue"></div>
	<div id="Div3" runat="server"  style="background-color: #00ffff"></div>
	<div id="Div4" runat="server" style="background-color:aqua" ></div>
</asp:Content>
