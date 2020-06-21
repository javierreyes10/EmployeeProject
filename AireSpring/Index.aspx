<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AireSpring.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            var table = $("#employees").DataTable({
                ajax: {
                    url: "/EmployeeHandler.ashx",
                    dataSrc: "" //Empty string because of our data source is a array of objects itself
                },
                columns: [
                    {
                        data: "FirstName",
                        render: function (data, type, employee) {
                            return "<a href='EmployeeView?employeeID=" + employee.Id + "'>" + employee.FirstName + " " + employee.LastName + "</a>";
                        }
                    },
                    {
                        data: "Phone"
                    },
                    {
                        data: "Zip"
                    }
                ]
            });
        });
    </script>
    <br/>
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
