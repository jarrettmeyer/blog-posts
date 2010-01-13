$(function() {
    $(".edit-link").click(function(e) {
        e.preventDefault();
        hideEditLinks();
        var row = $(this).parents("tr");
        var rowId = row[0].id.match(/(\d+)/)[1];
        //$(this).parents("form").attr("action", "/names/update");
        $.get("/names/edit/" + rowId, {}, function(html) {
            row.replaceWith(html);
            registerUpdateButton();
            registerCancelButton();
        });
    });
    $("#addNameLink").click(function(e) {
        e.preventDefault();
        hideEditLinks();
        //$(this).parents("form").attr("action", "/names/create");
        $.get("/names/new", {}, function(html) {
            $("tbody").append(html);
            registerCreateButton();
            registerCancelButton();
        });
    });
    function hideEditLinks() {
        $(".edit-link").hide();
        $("#addNameLink").parents("tr").hide();
    }
    function registerCancelButton() {
        $("#cancelRowButton").click(function(e) {
            e.preventDefault();
            var rowId = $("#Id").val();
            var selector = "tr#name-" + rowId;
            if (rowId > 0) {
                $.get("/names/" + rowId, {}, function(html) {
                    $(selector).replaceWith(html);
                });
            } else {
                $(selector).remove();
            }
            showEditLinks();
        });
    }
    function registerCreateButton() {
        $("#createRowButton").click(function(e) {
            submitForm(this, e, "/names/create", true);
        });
    }
    function registerUpdateButton() {
        $("#updateRowButton").click(function(e) {
            submitForm(this, e, "/names/update", false);
        });
    }
    function showEditLinks() {
        $(".edit-link").show();
        $("#addNameLink").parents("tr").show();
    }
    function submitForm(element, event, url, isNew) {
        event.preventDefault();
        var formData = $(element).parents("form").serialize();
        var rowId = $("#Id").val();
        var selector = "tr#name-" + rowId;
        $.post(url, formData, function(html) {
            $(selector).replaceWith(html);
            var flashRow = isNew ? "tbody tr:last" : selector;
            $(flashRow).effect("highlight", {}, 3000);
            showEditLinks();
        });
    }
});

