// Contact Form
"use strict";

const $ = selector => document.querySelector(selector); 

const displayErrorMsgs = msgs => {
    const dl = document.createElement("dl");
    dl.classList.add("messages");

    for (let msg of msgs) {
        const dd = document.createElement("dd");
        const text = document.createTextNode(msg);
        dd.appendChild(text);
        dl.appendChild(dd);
    }

    const node = $("dl");
    if (node == null) {
        const form = $("dd");
        form.parentNode.insertBefore(dl, form);
    } else {
        node.parentNode.replaceChild(dl, node);
    }  
}

const processEntries = () => {
    const email = $("#email_address");
    const phone = $("#phone");
    const country = $("#country");
    const terms = $("#terms");
    const comments = $("#comments");
    const msgs = [];
    const success = "Success! Thank you for contacting us!";

    if (email.value == "") {
        msgs[msgs.length] = "* Please enter an email address.";
    } 
    if (phone.value == "") {
        msgs[msgs.length] = "* Please enter a mobile phone number."; 
    } 
    if (country.value == "") {
        msgs[msgs.length] = "* Please select a country.";
    } 
    if (terms.checked == false) {
        msgs[msgs.length] = "* You must agree to the terms of service."; 
    }
    if (comments.value == "") {
        msgs[msgs.length] = "* Please enter a comment.";
    }

    if (msgs.length == 0) {
        alert(success);
        $("dl").remove();
    } else {
        displayErrorMsgs(msgs);
    }
};

const resetForm = () => {
    $("form").reset();
    
    $("dl").remove();
    
    $("#email_address").focus();
};

document.addEventListener("DOMContentLoaded", () => {
    $("#register").addEventListener("click", processEntries);
    $("#reset_form").addEventListener("click", resetForm);  
    $("#email_address").focus();   
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