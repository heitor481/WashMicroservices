
loading = (isLoading) => {
    var opacity = isLoading ? 0.3 : 1;
    if (isLoading)
        $("#loader").show();
    else
        $("#loader").hide();
}

doRequest = (reqData) => {
    loading(true);

    $.ajax({
        type: reqData.type,
        url: reqData.url,
        data: reqData.payload,
        cache: false,
        success: reqData.callback,
        error: function (err) {
            console.log(err);
            displayError(reqData.errorMsg);
        },
        complete: function () {
            loading(false);
        }
    });
}

displayError = (err) => {
    $("#modalMessage").html(err);
    $("#errorModal").modal();
}

function setElementSelected(el, id) {
    $("#" + id + " .card-selected").each((idx, c) => $(c).removeClass("card-selected"));
    $(el).addClass("card-selected");

    const clotheId = $("#clothes .splide__list .card-selected").first().length;
    const providerId = $("#providers .splide__list .card-selected").first().length;

    if (clotheId && providerId)
        $("#btnGenerateOrder").show();

}