// js de prueba xd

function alertarProductos() {
    let productos = [];
    productos = getProductosLocalStorage();

    console.log(productos);
}



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

function cargarEnInput() {
    document.querySelector('#inputPrueba').value = localStorage.getItem('sesionActiva');
}

function almacenarSesion() {
    let usuario = document.querySelector('#Credencial_Usuario').value;
    localStorage.setItem('sesionActiva', usuario);
}

// main


