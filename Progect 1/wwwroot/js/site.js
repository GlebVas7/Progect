// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
window.onscroll = function showHeader() {

    var header = document.querySelector('.header')

    if (window.pageYOffset > 0) {
        header.classList.add('header_fixed');
    } else {
        header.classList.remove('header_fixed');
    }
}



function openFunction() {
    document.getElementById("menu").style.width = "100%";
    document.getElementById("mainbox").style.marginLeft = "0px";
}
function closeFunction() {
    document.getElementById("menu").style.width = "0px";
    document.getElementById("mainbox").style.marginLeft = "0px";
    document.getElementById("mainbox").innerHTML = "&#9776"
}



