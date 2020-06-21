<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeView.aspx.cs" Inherits="AireSpring.EmployeeView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%: Scripts.Render("~/bundles/inputmask") %>

    <script type="text/javascript">
        $(document).ready(function () {
            $('#MainContent_txtPhone').inputmask("(999) 999-9999", { placeholder: "(XXX) XXX-XXXX" });
            $('#MainContent_txtHireDate').inputmask("99/99/9999", { placeholder: "MM/DD/YYYY" });
        });
    </script>
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
</asp:Content>
