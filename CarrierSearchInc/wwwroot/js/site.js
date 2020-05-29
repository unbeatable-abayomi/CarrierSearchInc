// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


const firstName = document.querySelector("#firstName");
const lastName = document.querySelector("#lastName");
const email = document.querySelector("#email");
const phone = document.querySelector("#phone");
const address = document.querySelector("#address");

console.log(firstName);
console.log(lastName);
console.log(email);
console.log(phone);
const spanFirstName = document.querySelector(".firstname");
const spanLastName = document.querySelector(".lastname");
const spanEmail = document.querySelector(".email");
const spanPhone = document.querySelector(".phone");
const spanAddress = document.querySelector(".address");


firstName.addEventListener("blur", ValidateFirstName);
lastName.addEventListener("blur", ValidateLastName);

//ValidateFirstName = () => {

//}

function ValidateFirstName() {
    let fName = firstName.value;
    let comparefName = new RegExp('[a-z]{2,15}', "gi");
    if (comparefName.test(fName)) {
        spanFirstName.innerHTML = "Good!";
        spanFirstName.style.color = "green";
    } else {
        spanFirstName.innerHTML = "Oops! incorrect input";
        spanFirstName.style.color = "red";
    }
}

function ValidateLastName() {
    let LName = lastName.value;
    let comparefName = new RegExp('[a-z]{2,15}', "gi");
    if (comparefName.test(LName)) {
        spanLastName.innerHTML = "Good!";
        spanLastName.style.color = "green";
    } else {
        spanLastName.innerHTML = "Oops! incorrect input";
        spanLastName.style.color = "red";
    }
}




