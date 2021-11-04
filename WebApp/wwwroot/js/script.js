function GetAccountSection(url, divid) {
    $.get(url,
        function (data, status) {
            document.getElementById(divid).innerHTML = data;
        });
}

function PostAccountData(url, json, divid) {
    $.post(url,
        function (data, status) {
            document.getElementById(divid).innerHTML = data;
            ShowAlert();
            CloseAlert();
        });
}

function CloseAlert() {
    $(".alert").delay(6000).slideUp(1000, function () {
        $(this).alert('hide');
    });
}

function ShowAlert() {
    $(".alert").delay(2000).slideUp(2000, function () {
        $(this).alert('show');
    });
}