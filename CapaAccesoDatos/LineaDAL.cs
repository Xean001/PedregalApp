using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class LineaDAL
    {
        public List<Lineas> ListarLineasPorCortina(int idCortina)
        {
            List<Lineas> lista = new List<Lineas>();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT IdLinea, IdCortina, Numero FROM Lineas WHERE IdCortina = @IdCortina", cn);
                cmd.Parameters.AddWithValue("@IdCortina", idCortina);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Lineas
                        {
                            IdLinea = (int)dr["IdLinea"],
                            IdCortina = (int)dr["IdCortina"],
                            Numero = (int)dr["Numero"]
                        });
                    }
                }
            }

            return lista;
        }
    }
}