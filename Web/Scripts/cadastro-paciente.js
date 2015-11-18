$(document).ready(function () {
    $(".form_datetime").datetimepicker({ format: 'yyyy-mm-dd' });

    $('#InputData').datepicker({
        format: "dd/mm/yyyy"
    });

    //Buttons actions
    $("[data-pdsa-action]").on("click", function (a) {
        a.preventDefault();
        $("#EventCommand").val($(this).attr("data-pdsa-action"));

        $("form").submit();
    });
});