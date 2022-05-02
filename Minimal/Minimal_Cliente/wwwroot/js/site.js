// js de prueba xd

function almacenarIdEnForm() {
    let idUsuario = localStorage.getItem('sesionActiva')
    document.querySelector('#idUsuario').value = idUsuario;
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
    let texto = localStorage.getItem('sesionActiva')
    document.querySelector('#productos-local-storage').value = texto;
}

function almacenarSesion() {
    let usuario = document.querySelector('#Credencial_Usuario').value;
    localStorage.setItem('sesionActiva', usuario);
}

// main


