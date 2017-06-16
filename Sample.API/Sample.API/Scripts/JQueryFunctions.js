$(function () {
    $('#btnTest').click(function () {
        $.get("/Home/ReturnString", null, function (data) {

            for (var i = 0; i < 10; i++) {
                var row = $('<tr><td>' + data + '</td></tr>');
                $('#myTable').append(row);
            }
        });
    });
});