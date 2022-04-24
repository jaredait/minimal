// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function agregarCarrito(element) {
    localStorage.setItem(element.id, "1");
}

function getProductosLocalStorage() {
    let listaProductos = [];
    let keys = Object.keys(localStorage)
    let key;

    for (let i = 0; key = keys[i]; i++) {
        listaProductos.push([key, localStorage.getItem(key)]);
    }

    return listaProductos;
}

function hi() {
    
}

function almacenarSesion() {
    let usuario = document.querySelector('#Credencial_Usuario').value;
    localStorage.setItem('sesionActiva', usuario);
}
