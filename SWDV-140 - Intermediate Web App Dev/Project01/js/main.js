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