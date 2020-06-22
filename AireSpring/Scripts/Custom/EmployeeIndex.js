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
            },
            {
                data: "HireDate"
            }
        ]
    });
});