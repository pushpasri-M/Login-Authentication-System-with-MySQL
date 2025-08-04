function Alt() {
    alert("Your Data is Stored.... \n We will reach you in Short period of time");
}
function loginMessage() {
    alert("Succesfully Login");
}
function signUpMessage() {
    alert("You have signed up successfully!");
}
function validateSignUpForm() {
    var pass = document.getElementById("password").value;
    var confirmPass = document.getElementById("confirmPassword").value;

    if (pass !== confirmPass) {
        alert("Passwords do not match!");
        return false; // stop form submission
    }
    return true; // allow form to submit
}
