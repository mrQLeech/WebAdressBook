
var CheckFieldsIsEmpty = function () {
    var loginField = document.getElementById("loginBox");
    var passField = document.getElementById("passBox");
    
    var login = loginField !== undefined ? loginField.value : "";
    var pass = passField !== undefined ? passField.value : "";

    if (login === "" || pass === "") {
        return true;
    }
    return false;
}

var ChangeButtonVisibility = function (visible) {
    if (visible) {
        document.getElementById("buttonHolder").style.display = "block"; 
    } else {
        document.getElementById("buttonHolder").style.display = "none";
    }
}

var BindInputFieldKeyUpHandler = function (field) {   
    field.onkeyup = function () {
        ChangeButtonVisibility(!CheckFieldsIsEmpty());
    };
}


var BindInputFieldsHandlers = function(){
    var loginField = document.getElementById("loginBox");
    var passField = document.getElementById("passBox");
    BindInputFieldKeyUpHandler(loginField);
    BindInputFieldKeyUpHandler(passField);
}

BindInputFieldsHandlers();
ChangeButtonVisibility(false);

