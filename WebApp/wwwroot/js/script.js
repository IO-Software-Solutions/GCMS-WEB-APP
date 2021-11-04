function GetAccountSection(url) {
    $.get(url,
        function (data, status) {
            document.getElementById("account").innerHTML = data;
        });
}