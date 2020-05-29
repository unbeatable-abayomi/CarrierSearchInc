// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


const firstName = document.querySelector("#firstName");
const lastName = document.querySelector("#lastName");
const email = document.querySelector("#email");
const phone = document.querySelector("#phone");
const address = document.querySelector("#address");


const spanFirstName = document.querySelector(".firstname");
const spanLastName = document.querySelector(".lastname");
const spanEmail = document.querySelector(".email");
const spanPhone = document.querySelector(".phone");
const spanAddress = document.querySelector(".address");


firstName.addEventListener("blur", ValidateFirstName);
lastName.addEventListener("blur", ValidateLastName);
email.addEventListener("blur", ValidateEmail);
phone.addEventListener("blur", ValidatePhone);
address.addEventListener("blur", ValidateAddress);

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

function ValidateEmail() {

    let emailAd = email.value;
        let compareEmail = new RegExp('[a-z0-9_.]+@[a-z0-9-]+\.[a-z]{2,6}', "gi");
        if (compareEmail.test(emailAd)) {
            spanEmail.innerHTML = "Good!";
            spanEmail.style.color = "green";
        } else {
            spanEmail.innerHTML = "Oops! incorrect input";
            spanEmail.style.color = "red";
        }
    
}

function ValidatePhone() {
    let phoneNumber = phone.value;
    let comparePhone = new RegExp('[1-9]{4,15}', "gi");
    if (comparePhone.test(phoneNumber)) {
        spanPhone.innerHTML = "Good!";
        spanPhone.style.color = "green";
    } else {
        spanPhone.innerHTML = "Oops! incorrect input";
        spanPhone.style.color = "red";
    }
}

function ValidateAddress() {
    let addres = address.value;
    let comparefName = new RegExp('[a-z]{4,100}', "gi");
    if (comparefName.test(addres)) {
        spanAddress.innerHTML = "Good!";
        spanAddress.style.color = "green";
    } else {
        spanAddress.innerHTML = "Oops! incorrect input";
        spanAddress.style.color = "red";
    }
}



