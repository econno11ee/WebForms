<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="InitialCSVUpload._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
	<div class="container-fluid form-wrapper">
		<div class="row">
			<form method="post" id="postForm" class="row">
				<h4>Upload your csv file here:</h4>
				<div class="col-md-4">
					<asp:FileUpload ID="FileUpload1" class="btn btn-outline-dark btn-primary" runat="server" />
				</div>
				<div class="col-md-2">
					<asp:Button ID="Button1" type="submit" class="btn btn-submit" runat="server" Text="Submit" OnClick="Button1_Click" />
				</div>
				<div>
					<asp:Label ID="OutputLabel" runat="server"></asp:Label>
				</div>
			</form>
			<div class="col-md-4">
				<asp:Label ID="OutputLabel1" runat="server"></asp:Label>
				<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="MemberInfoSQLDB">
					<Columns>
						<asp:BoundField DataField="EmailAddress" HeaderText="EmailAddress" SortExpression="EmailAddress" />
						<asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
						<asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
					</Columns>
				</asp:GridView>
				<asp:SqlDataSource ID="MemberInfoSQLDB" runat="server" ConnectionString="<%$ ConnectionStrings:MemberInfoConnectionString %>" SelectCommand="SELECT [EmailAddress], [FirstName], [LastName] FROM [Members]"></asp:SqlDataSource>
			</div>
		</div>
</div>
		
</asp:Content>
