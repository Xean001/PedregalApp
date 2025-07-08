using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class datClasificacion
    {
        private static readonly datClasificacion _instancia = new datClasificacion();
        public static datClasificacion Instancia => _instancia;
        public List<entClasificacion> ListarClasificaciones()
        {
            SqlCommand cmd = null;
            List<entClasificacion> lista = new List<entClasificacion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarClasificaciones", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entClasificacion c = new entClasificacion();
                    c.id_clasificacion = Convert.ToInt32(dr["id_clasificacion"]);
                    c.nombre = dr["nombre"].ToString();
                    lista.Add(c);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }

            return lista;
        }
    }
}
