//Order Online Modal
"use strict";

const $ = selector => document.querySelector(selector);

document.addEventListener("DOMContentLoaded", () => {

    $("#submit").addEventListener("click", () => {
        const day = $("#day").value;
        const time = $("#time").value;
        const contact = $("#contact").value;
        const number = $("#number").value;

        let errorMessage = "";
    
        if (day == "Monday") {
            errorMessage = "There are no openings available for "+ day;
            alert(errorMessage);
            $("#day").focus();
        } 
        else if (time == "6:00 AM") {
            errorMessage = time + " is not available";
            alert(errorMessage);
            $("#time").focus();
        } 
        else if (contact == "") {
            errorMessage = "Please enter your name";
            alert(errorMessage);
            $("#contact").focus();
        } else if (isNaN(number) || number == "" || number.length < 10) {
            errorMessage = "Please enter a valid phone number";
            alert(errorMessage);
            $("#number").focus();
        } else {
            errorMessage = "We will call you to place your order\nThank you!";
            alert(errorMessage)
            $("#day").focus();
        }
    });
    $("#day").focus();
});

//Newsletter Modal
document.addEventListener("DOMContentLoaded", () => {
    
    $("#join_list").addEventListener("click", () => {
        const email1 = $("#email_1");
        const email2 = $("#email_2");
        const firstName = $("#first_name");
        const signup = "Success! Thank you for signing up for our newsletter!";
    
        let isValid = true;

        if (email1.value == "") {
            email1.nextElementSibling.textContent = "This field is required.";
            isValid = false; 
        } else {
            email1.nextElementSibling.textContent = "";
        }
    
        if (email2.value == "") { 
            email2.nextElementSibling.textContent = "This field is required.";
            isValid = false; 
        } else {
            email2.nextElementSibling.textContent = "";
        }
    
        if (email1.value != email2.value) { 
            email2.nextElementSibling.textContent = "Email addresses must match.";
            isValid = false; 
        }
    
        if (firstName.value == "") {
            firstName.nextElementSibling.textContent = "First name is required.";
            isValid = false;
        } else {
            firstName.nextElementSibling.textContent = "";
        }
    
        if (isValid) {
            alert(signup);
        }
    });

    $("#clear_form").addEventListener("click", () => {
        $("#email_1").value = "";
        $("#email_2").value = "";
        $("#first_name").value = "";

        $("#email_1").focus();
    });
    
    $("#email_1").focus();
});