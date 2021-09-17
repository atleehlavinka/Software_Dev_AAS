// Contact Form
"use strict";

const $ = selector => document.querySelector(selector); 

document.addEventListener("DOMContentLoaded", () => {
    
    $("#submit").addEventListener("click", () => {

        const email = $("#email_address");
        const phone = $("#phone");
        const country = $("#country");
        const terms = $("#terms");
        const comments = $("#comments");
        const success = "Successfully submitted! We will be in touch soon.";

        const emailValidation = /^[\w\.\-]+@[\w\.\-]+\.[a-zA-Z]+$/;
        const phoneValidation = /^\d{3}-\d{3}-\d{4}$/;

        let isValid = true;

        if (email.value == "") {
            email.nextElementSibling.textContent = "* Please enter an email address.";
            isValid = false;
        } else if (!emailValidation.test(email.value)) {
            email.nextElementSibling.textContent = "* Please enter a valid email address.";
            isValid = false;
        } else {
            email.nextElementSibling.textContent = "";
        }

        if (phone.value == "") {
            phone.nextElementSibling.textContent = "* Please enter a mobile phone number.";
            isValid = false;
        } else if (!phoneValidation.test(phone.value)) {
            phone.nextElementSibling.textContent = "* Please enter a valid mobile phone number.";
            isValid = false;
        } else {
            phone.nextElementSibling.textContent = "";
        }

        if (country.value == "") {
            country.nextElementSibling.textContent = "* Please select a country.";
            isValid = false;
        } else {
            country.nextElementSibling.textContent = "";
        }

        if (terms.checked == false) {
            terms.nextElementSibling.textContent = "* You must agree to the terms of service.";
            isValid = false;
        } else {
            terms.nextElementSibling.textContent = "";
        }

        if (comments.value == "") {
            comments.nextElementSibling.textContent = "* Please enter a comment.";
            isValid = false;
        } else {
            comments.nextElementSibling.textContent = "";
        }

        if (isValid) {
            alert(success)
        }
    });
    $("#reset_form").addEventListener("click", () => {
        $("form").reset();
            const email = $("#email_address");
            const phone = $("#phone");
            const country = $("#country");
            const terms = $("#terms");
            const comments = $("#comments");

            email.nextElementSibling.textContent = "";
            phone.nextElementSibling.textContent = "";
            country.nextElementSibling.textContent = "";
            terms.nextElementSibling.textContent = ""; 
            comments.nextElementSibling.textContent = "";
    });
});



//Newsletter Modal
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