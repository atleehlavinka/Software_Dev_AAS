"use strict";

const $ = selector => document.querySelector(selector); 

document.addEventListener("DOMContentLoaded", () => {
    
    $("#submit").addEventListener("click", () => {

        const email = $("#email_address");
        const phone = $("#phone");
        const comments = $("#comments");
        const success = "Successfully submitted! I will be in touch soon.";

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

        if (comments.value == "") {
            comments.nextElementSibling.textContent = "* Please enter a comment.";
            isValid = false;
        } else {
            comments.nextElementSibling.textContent = "";
        }

        if (isValid) {
            alert(success)
            setTimeout($("#reset_form").click(), 5000);
        }
    });
    $("#reset_form").addEventListener("click", () => {
        $("form").reset();
            const email = $("#email_address");
            const phone = $("#phone");
            const comments = $("#comments");

            email.nextElementSibling.textContent = "";
            phone.nextElementSibling.textContent = "";
            comments.nextElementSibling.textContent = "";
    });
});