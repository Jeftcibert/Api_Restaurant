using Microsoft.AspNetCore.Mvc;
using WebApiBD_Restaurante.DAO;
using WebApiBD_Restaurante.Entidades;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiBD_Restaurante.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatilloApiController : ControllerBase
    {
        private readonly PlatilloDAO plaDao;

        public PlatilloApiController(PlatilloDAO _Dao)
        {
            plaDao = _Dao;
        }

        // GET: api/<UsuarioController>
        [HttpGet("GetPlatillos")]
        public List<Platillo> Get()
        {
            return plaDao.ListarPlatillos();
        }

        // GET api/<UsuarioController>/5
        [HttpGet("GetPlatilloNombre/{nombre}")]
        public List<Platillo> Get(string nombre)
        {
            var platillos = plaDao.BuscarPlatillosPorIniciales(nombre);

            return platillos;
        }
    }
}
