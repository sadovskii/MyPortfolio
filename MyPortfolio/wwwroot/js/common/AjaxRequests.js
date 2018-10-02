function AjaxForNavLinkByClick(element, actionUrl, result) {
    $(element).on('click', function() {
        $.ajax({
            type: "GET",
            url: actionUrl,
            headers: {
                RequestVerificationToken:
                    $('input:hidden[name="__RequestVerificationToken"]').val()
            }
        }).done(function (date) {
            $(result).html(date)
        }).fail(function () {
            window.alert("Could not send data to Server.");
        })
    })
}

function AjaxForNavLink(element, actionUrl, result) {
    $.ajax({
        type: "GET",
        url: actionUrl,
        headers: {
            RequestVerificationToken:
                $('input:hidden[name="__RequestVerificationToken"]').val()
        }
    }).done(function (date) {
        $(result).html(date)
    }).fail(function () {
        window.alert("Could not send data to Server.");
    })
}