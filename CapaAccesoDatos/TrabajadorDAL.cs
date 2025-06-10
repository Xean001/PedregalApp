using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class TrabajadorDAL
    {
        public List<Trabajador> ListarTrabajadores()
        {
            List<Trabajador> lista = new List<Trabajador>();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("SELECT IdTrabajador, Nombre FROM Trabajadores", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Trabajador
                    {
                        IdTrabajador = dr["IdTrabajador"].ToString(),
                        Nombre = dr["Nombre"].ToString()
                    });
                }
            }

            return lista;
        }
    }
}