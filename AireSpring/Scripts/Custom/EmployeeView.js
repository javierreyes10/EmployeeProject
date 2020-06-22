
    $(document).ready(function () {
        $('#MainContent_txtPhone').inputmask("(999) 999-9999", { placeholder: "(XXX) XXX-XXXX" });
        $('#MainContent_txtHireDate').inputmask("99/99/9999", {placeholder: "MM/DD/YYYY" });
        $('#MainContent_txtHireDate').datepicker();
    });
