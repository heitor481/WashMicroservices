// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

$(document).ready(function () {

    var elms = document.getElementsByClassName('splide');
    for (var i = 0; i < elms.length; i++) {
        new Splide(elms[i], {
            type: "loop",
            perPage: 3,
            arrows: false
        })
        .mount();
    }

    DisplayClothes();

    $("#btnDisplayClothes").click(function () {
        DisplayClothes();
    });

    $("#btnDispalyProviders").click(function () {
        DisplayProviders();
    });

    $("#btnGenerateOrder").click(function () {
        GenerateOrder();
    });

});