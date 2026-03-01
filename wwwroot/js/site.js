// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let btnScrollToTop = document.getElementById("btnScrollToTop");

window.onscroll = function () {
    scrollFunction();
}

function scrollFunction() {
    if(document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
        btnScrollToTop.style.display = "block";
    } else {
        btnScrollToTop.style.display = "none";
    }
}
btnScrollToTop.onclick = function () {
    window.scrollTo({ top: 0, behavior: 'smooth' });
}