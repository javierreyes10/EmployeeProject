<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeView.aspx.cs" Inherits="AireSpring.EmployeeView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
            &nbsp;ID
            <asp:TextBox ID="txtEmployeeId" runat="server" Enabled="False"></asp:TextBox>
            <br />
            <br />
            First Name
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br />
            <br />
            Last Name
            <asp:TextBox ID="txtLastName" runat="server" ></asp:TextBox>
            <br />
            <br />
            Phone
            <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
            <br />
            <br />
            Zip<asp:TextBox ID="txtZip" runat="server"></asp:TextBox>
            <br />
            <br />
            Hire Date<asp:TextBox ID="txtHireDate" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="btnSaveEmployee" runat="server" OnClick="SaveEmployee" Text="Save" />
        <br />
        <br />
        &nbsp;<asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
        <asp:Button ID="btnSearchEmployee" runat="server" OnClick="SearchEmployee" Text="Search" />
</asp:Content>
