"use strict";

const $ = selector => document.querySelector(selector);

document.addEventListener("DOMContentLoaded", () => {
    
    $("#join_list").addEventListener("click", () => {
        const email1 = $('#email_1');
        const email2 = $("#email_2");
        const firstName = $("#first_name");

        const emailValidation1 = /^[\w\.\-]+@[\w\.\-]+\.[a-zA-Z]+$/;
        const emailValidation2 = /^[\w\.\-]+@[\w\.\-]+\.[a-zA-Z]+$/;

        const signup = "Success! Thank you for signing up for our newsletter!";
    
        let isValid = true;

        if (email1.value == "") {
            email1.nextElementSibling.textContent = "This field is required.";
            isValid = false; 
        } else if (!emailValidation1.test(email1.value)) {
            email1.nextElementSibling.textContent = "Enter a valid email address.";
            isValid = false; 
        }
        if (emailValidation1.test(email1.value)) {
            email1.nextElementSibling.textContent = "";
        }
    
        if (email2.value == "") { 
            email2.nextElementSibling.textContent = "This field is required.";
            isValid = false; 
        } else if (!emailValidation2.test(email2.value)) {
            email2.nextElementSibling.textContent = "Enter a valid email address.";
            isValid = false; 
        } else if (email1.value != email2.value) { 
            email2.nextElementSibling.textContent = "Email addresses must match.";
            isValid = false; 
        } else {
            email2.nextElementSibling.textContent = "";
        }
    
        if (firstName.value == "" || !isNaN(firstName.value)) {
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