// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

function signUp() {
    window.location.replace("/users/create");

}

let uName = document.getElementById("uName")
let psw = document.getElementById("psw")

function signIn() {
    for (var item in Model.user) {
        console.log(item.Username)
        if (uName.value == item.Username && psw.value == item.Password) {
            window.location.replace("/users/index");
        }
    }

    

}