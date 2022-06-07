

let editaProducto =  async (ProductoId, SucursalId, Existencia ) => {

  
    let nuevaCantidad = prompt("Ingresar nueva cantidad:", Existencia);
    const dto = {
        ProductoId, SucursalId, Existencia: nuevaCantidad
    }

    await actualizar(dto)
    
 
}


let actualizar = async (dto) => {
    const response = await fetch('../Home/ActualizarExistencia', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'

        },
        body: JSON.stringify(dto)
    });
    const data = await response.json();
    if (data.result > 0) {

        alert("SE ACTUALIZO CORRECTAMENTE");

        await refrescar();
    }
}


let refrescar = async () => {

    let response = await fetch('../Home/_TablaProducto', {
        method: 'GET'
    });

    let html = await response.text();
    document.getElementById('TablaProducto').innerHTML = html;
}




let buscarporId = async (idproducto) => {

   

    let response = await fetch(`../Home/_TablaProducto?id=${idproducto}`, {
        method: 'GET',

     
    });

    let html = await response.text();
    document.getElementById('TablaProducto').innerHTML = html;
}


document.getElementById('btnBusqueda').addEventListener('click', async (e) => {

    
    const id = document.getElementById('Busqueda').value
    
    await buscarporId(id);


})