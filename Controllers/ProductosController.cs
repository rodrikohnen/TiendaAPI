using Microsoft.AspNetCore.Mvc;
using TiendaAPI.Datos;
using TiendaAPI.Modelo;

namespace TiendaAPI.Controllers
{

    [ApiController]
    [Route("api/productos")]
    public class ProductosController : ControllerBase
    {
        [HttpGet]

        public async Task<ActionResult<List<Mproductos>>> Get()
        {
            var function = new Dproductos();

            var lista = await function.Mostrarproductos();

            return lista;

        }

        [HttpPost]

        public async Task<ActionResult> Post([FromBody] Mproductos parametros)
        {
            var function = new Dproductos();

            await function.IntroducirProductos(parametros);

            return NoContent();


        }

        [HttpPut("{id}")]

        public async Task<ActionResult> Put(int id, [FromBody] Mproductos parametros)
        {
            var function = new Dproductos();

            parametros.id = id;

            await function.ModificarProductos(parametros);

            return NoContent();

        }

        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(int id)
        {
            var function = new Dproductos();
            var parametros = new Mproductos();

            parametros.id = id;

            await function.EliminarProductos(parametros);

            return NoContent();

        }

    }
}
