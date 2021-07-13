function checkPassword() { 
    var pass = document.getElementById("psw").value;
    var pass2 = document.getElementById("psw-repeat").value;
     if (pass != pass2){  
        alert ("Passwords do not match! Try again :( ") 
     }
    } 
