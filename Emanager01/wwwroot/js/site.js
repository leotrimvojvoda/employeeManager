// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


var btn = document.getElementById("submit");

var ldr = document.getElementById("ldr");

var tab = document.getElementById("tab");

btn.addEventListener('click', showDots);

tab.addEventListener('click', showDots);



function showDots() {
    console.log('Button clicked');
    ldr.style.display = "inline-block";
}





var pwd = document.getElementById("pwdField");



pwd.addEventListener('click', function () {

    document.getElementsByClassName("error").style.display = "none";
   
});