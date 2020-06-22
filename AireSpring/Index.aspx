<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AireSpring.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/DataTables/css/jquery.dataTables.min.css" rel="stylesheet" />
    <script src="Scripts/Custom/EmployeeIndex.js"></script>
    <br/>
    <h2>Employees</h2>
    <br/>
    <br/>
    <a href='EmployeeView?employeeID=0' class="btn btn-primary">Add Employee</a>
    <br/>
    <br/>
    <table id="employees" class="table table-striped table-hover table-bordered">
        <thead>
        <tr>
            <th>Name</th>
            <th>Phone</th>
            <th>Zip</th>
            <th>Hire Date</th>
        </tr>
        </thead>
    </table>
</asp:Content>
