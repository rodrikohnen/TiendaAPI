using Microsoft.AspNetCore.Mvc;
using TiendaAPI.Datos;
using TiendaAPI.Modelo;

namespace TiendaAPI.Controllers
{

    [ApiController]
    [Route("api/productos")]
    public class ProductosController
    {
        [HttpGet]

        public async Task<ActionResult<List<Mproductos>>> Get()
        {
            var function = new Dproductos();

            var lista = await function.Mostrarproductos();

            return lista;

        }

        [HttpPost]

        public async Task/*<ActionResult>*/ Post([FromBody] Mproductos parametros)
        {
            var function = new Dproductos();

            await function.IntroducirProductos(parametros);
            


        }
    
    }
}
