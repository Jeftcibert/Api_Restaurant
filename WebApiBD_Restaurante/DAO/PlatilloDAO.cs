using System.Data.SqlClient;
using WebApiBD_Restaurante.Entidades;

namespace WebApiBD_Restaurante.DAO
{
    public class PlatilloDAO
    {
        private readonly string conexion;

        public PlatilloDAO(IConfiguration config)
        {
            conexion = config.GetConnectionString("cn1");
        }

        /*Listado de Platillos*/
        public List<Platillo> ListarPlatillos()
        {
            var lista = new List<Platillo>();
            //
            SqlDataReader dr = SqlHelper.ExecuteReader(conexion, "SP_ListarPlatillos");
            //
            while (dr.Read())
            {
                lista.Add(new Platillo()
                {
                    id = dr.GetInt32(0),
                    nombre = dr.GetString(1),
                    precio = dr.GetDecimal(2),
                    descripcion = dr.GetString(3)
                });
            }
            dr.Close();
            return lista;
        }

        /*Buscar Platillos por Iniciales*/
        public List<Platillo> BuscarPlatillosPorIniciales(string nombre)
        {
            var lista = new List<Platillo>();
            //
            SqlDataReader dr = 
                SqlHelper.ExecuteReader(conexion, "SP_BuscarPlatillosPorIniciales", nombre);
            //
            while (dr.Read())
            {
                lista.Add(new Platillo()
                {
                    id = dr.GetInt32(0),
                    nombre = dr.GetString(1),
                    precio = dr.GetDecimal(2),
                    descripcion = dr.GetString(3)
                });
            }
            dr.Close();
            return lista;
        }


    }
}
