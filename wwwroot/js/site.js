// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

window.addEventListener('load', function () {
    var elements = document.querySelectorAll('.fade-in');
    for (var i = 0; i < elements.length; i++) {
        elements[i].style.opacity = '1';
    }
});


(function (app) {
    app.homepage = function () {
        setCopyrightDate();
    };

    function setCopyrightDate() {
        const date = new Date();
        document.getElementById('copyrightYear').innerText = date.getFullYear();
    }
})((window.app = window.app || {}));