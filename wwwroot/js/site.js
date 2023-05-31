// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// Select the text elements you want to apply the fade-in effect to
//const textElements = document.querySelectorAll('.fade-in-text');

//// Function to check if an element is in the viewport
//function isElementInViewport(element) {
//    const rect = element.getBoundingClientRect();
//    return (
//        rect.top >= 0 &&
//        rect.left >= 0 &&
//        rect.bottom <= (window.innerHeight || document.documentElement.clientHeight) &&
//        rect.right <= (window.innerWidth || document.documentElement.clientWidth)
//    );
//}

//// Function to handle scroll event
//function handleScroll() {
//    textElements.forEach((element) => {
//        if (isElementInViewport(element)) {
//            element.classList.add('fade-in');
//        }
//    });
//}

//// Add event listener to the scroll event
//window.addEventListener('scroll', handleScroll);
window.addEventListener('load', function () {
    var elements = document.querySelectorAll('.fade-in');
    for (var i = 0; i < elements.length; i++) {
        elements[i].style.opacity = '1';
    }
});
