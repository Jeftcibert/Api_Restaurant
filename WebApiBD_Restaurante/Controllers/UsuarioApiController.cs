using Microsoft.AspNetCore.Mvc;
using WebApiBD_Restaurante.DAO;
using WebApiBD_Restaurante.Entidades;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiBD_Restaurante.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioApiController : ControllerBase
    {
        private readonly UsuarioDAO usuDao;

        public UsuarioApiController(UsuarioDAO _Dao)
        {
            usuDao = _Dao;
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        public List<Usuario> Get()
        {

            return usuDao.ListaUsuarios();
        }

        // GET api/<UsuarioController>/5
        [HttpGet("Get/{id}")]
        
        public Usuario Get(int id)
        {
            var Usuario =
                usuDao.ListaUsuarios().Find(m=> m.id! == id);
            return Usuario;
        }

        // POST api/<UsuarioController>
        [HttpPost]
        [Route("Post")]
        public string Post([FromBody] Usuario obj)
        {
            return usuDao.GrabarUsuario(obj);
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Usuario obj)
        {
            return usuDao.ActualizarUsuario(obj);
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return usuDao.EliminarUsuario(id);
        }
    }
}
