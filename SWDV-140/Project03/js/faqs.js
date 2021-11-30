// // FAQs
"use strict";

$("#faqs").accordion({ 
    event: "click",
    heightStyle: "content",
    collapsible: true,
    active: false
});


document.addEventListener("DOMContentLoaded", () => {
    const $ = selector => document.querySelector(selector); 
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