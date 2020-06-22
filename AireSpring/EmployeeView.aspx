<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeView.aspx.cs" Inherits="AireSpring.EmployeeView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%: Scripts.Render("~/bundles/inputmask") %>
    <script src="Scripts/jquery-ui-1.12.1.min.js"></script>
    <link href="Content/themes/base/jquery-ui.min.css" rel="stylesheet" />
    <script src="Scripts/Custom/EmployeeView.js"></script>

    <div>
        <h2>Employee</h2>
        <br/>
        <div class="form-group">
            ID
            <br />
            <asp:TextBox ID="txtEmployeeId" runat="server" Enabled="False" required class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            First Name
            <br />
            <asp:TextBox ID="txtFirstName" runat="server" required class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            Last Name
            <br />
            <asp:TextBox ID="txtLastName" runat="server" required class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            Phone
            <br />
            <asp:TextBox ID="txtPhone" runat="server" required class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            Zip
            <br />
            <asp:TextBox ID="txtZip" runat="server" required class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            Hire Date
            <br />
            <asp:TextBox ID="txtHireDate" runat="server" required class="form-control"></asp:TextBox>
        </div>
    </div>
    <asp:Label ID="lblErrorMessage" runat="server" class="label label-danger"></asp:Label>
    <br />
    <br />

    <asp:Button ID="btnSaveEmployee" runat="server" OnClick="SaveEmployee" Text="Save" class="btn btn-primary" />
</asp:Content>
