﻿// js de prueba xd




// ------------------------------------------------------------------------------------------

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

function almacenarSesion() {
    let usuario = document.querySelector('#Credencial_Usuario').value;
    localStorage.setItem('sesionActiva', usuario);
}

function almacenarIdEnForm() {
    let idUsuario = localStorage.getItem('sesionActiva')
    document.querySelector('#idUsuario').value = idUsuario;
}

function obtenerIdUsuario() {
    return localStorage.getItem('sesionActiva');
}

function obtenerUsuarioCarrito() {
    let item = document.querySelector("#boton-carrito-layout");
    let idUsuario = obtenerIdUsuario();

    item.setAttribute("href", `/Carrito?id=${idUsuario}`);
}
// main


