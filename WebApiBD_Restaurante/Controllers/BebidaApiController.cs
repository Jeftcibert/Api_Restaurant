using Microsoft.AspNetCore.Mvc;
using WebApiBD_Restaurante.DAO;
using WebApiBD_Restaurante.Entidades;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiBD_Restaurante.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BebidaApiController : ControllerBase
    {
        private readonly BebidaDAO bebDao;

        public BebidaApiController(BebidaDAO _Dao)
        {
            bebDao = _Dao;
        }

        // GET: api/<UsuarioController>
        [HttpGet("GetBebidas")]
        public List<Bebida> Get()
        {
            return bebDao.ListarBebidas();
        }

        // GET api/<UsuarioController>/5
        [HttpGet("GetBebidaNombre/{nombre}")]
        public List<Bebida> Get(string nombre)
        {
            var bebidas = bebDao.BuscarBebidaPorIniciales(nombre);

            return bebidas;
        }
    }
}
