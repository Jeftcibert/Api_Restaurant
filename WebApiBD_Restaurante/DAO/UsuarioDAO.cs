using System.Data;

using System.Data.SqlClient;
using WebApiBD_Restaurante.Entidades;

namespace WebApiBD_Restaurante.DAO
{
    public class UsuarioDAO
    {
        private readonly string conexion;

        public UsuarioDAO(IConfiguration config)
        {
            conexion = config.GetConnectionString("cn1");
        }
        
        /*Listado de Usuarios*/
        public List<Usuario> ListaUsuarios()
        {
            var lista = new List<Usuario>();
            //
            SqlDataReader dr = SqlHelper.ExecuteReader(conexion, "sp_usuario_list");
            while (dr.Read())
            {
                lista.Add(new Usuario()
                {
                    id = dr.GetInt32(0),
                    nombre = dr.GetString(1),
                    correo = dr.GetString(2),
                    clave = dr.GetString(3),
                    rol = dr.GetInt32(4)
                    

                });
            }
            dr.Close();
            return lista;
        }
        /*Registrar un Usuario*/
        public string GrabarUsuario(Usuario objs)
        {
            string mensaje = "";
            try {
                SqlHelper.ExecuteNonQuery(conexion, "sp_Usuario_reg",
                    objs.nombre!,objs.correo!,objs.clave!,objs.rol!);
                //
                return mensaje = $"El Usuario {objs.nombre!} fue registrado correctamente";
            } catch(Exception e)
            
            { return mensaje = e.Message; }
   
        }

        /*Actalizar un Usuario*/

        public string ActualizarUsuario (Usuario obj)
        {
            string mensaje = "";
            try
            {
                SqlHelper.ExecuteNonQuery(conexion, "sp_usuario_act",
                   obj.id, obj.nombre!, obj.correo!, obj.clave!, obj.rol!);
                //
                return mensaje = $"El Usuario {obj.nombre!} fue Actualizado correctamente";
            }
            catch (Exception e) { return e.Message; }

        }
        /*Eliminar un Usuario*/
        public string EliminarUsuario (int id)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(conexion, "sp_usuario_eliminar", id);
                return  $"El Usuario usuario fue Eliminado correctamente";

            }
            catch (Exception e) { return e.Message; }

        }
        /*BuscarUsuario*/
        public Usuario BuscarUsuario(int id)
        {
            Usuario? buscado =
                ListaUsuarios().Find(x => x.id == id);
            if (buscado == null)
            {
                buscado = new Usuario();
            }
            return buscado;
        }

    }   
}
