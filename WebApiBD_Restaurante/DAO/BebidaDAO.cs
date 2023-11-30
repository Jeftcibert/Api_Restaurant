using System.Data.SqlClient;
using WebApiBD_Restaurante.Entidades;

namespace WebApiBD_Restaurante.DAO
{
    public class BebidaDAO
    {
        private readonly string conexion;

        public BebidaDAO(IConfiguration config)
        {
            conexion = config.GetConnectionString("cn1");
        }

        /*Listado de Bebidas*/
        public List<Bebida> ListarBebidas()
        {
            var lista = new List<Bebida>();
            //
            SqlDataReader dr = SqlHelper.ExecuteReader(conexion, "SP_ListarBebidas");
            //
            while (dr.Read())
            {
                lista.Add(new Bebida()
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

        /*Buscar Bebidas por Iniciales*/
        public List<Bebida> BuscarBebidaPorIniciales(string nombre)
        {
            var lista = new List<Bebida>();
            //
            SqlDataReader dr =
                SqlHelper.ExecuteReader(conexion, "SP_BuscarBebidaPorIniciales", nombre);
            //
            while (dr.Read())
            {
                lista.Add(new Bebida()
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
