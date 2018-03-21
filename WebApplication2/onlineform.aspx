<%@ Page Title="" Language="C#" MasterPageFile="~/OnlineMaster.Master" AutoEventWireup="true" CodeBehind="onlineform.aspx.cs" Inherits="WebApplication2.onlineform" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	< onload="alert('Hello World')">
		<script type="text/javascript">
			alert("hello miriam");
			function validate() {
				var name = document.getElementById('userid');

				var ErrorMessage = document.getElementById('error');
				ErrorMessage.innerHTML = "";
				if (name.value == "")
				{ ErrorMessage.innerHTML = "name is blank<br>"; alert("please fill in name"); return false; alert("please fill in name"); }
				name = document.getElementById("password");
				if (name.value == "")
				{ ErrorMessage.innerHTML = ErrorMessage.innerHTML + "password is false<br>"; return false; alert("please fill in password"); }
				return true;
			}


		</script>


		<!--div style="-webkit-margin-bottom-collapse:70px" class="whitetitle"-->
		<div id="news">
			<div class="newsItem">
				<div  id="test4" runat="server"></div>
				<form name="form" action="test.html" onsubmit="return validate()" method="post">
					Name:<br>
					<input type="text" name="userid" id="userid"><br>
					Password:<br>
					<input type="password" name="password" id="password"><br>
					<br>
					<input type="submit" value="Submit">

					<p id="error" style="color: red;"></p>
				</form>
			</div>

		</div>
	</>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
