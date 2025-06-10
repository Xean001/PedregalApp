using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class CortinaDAL
    {
        public List<Cortina> ListarCortinasPorLote(int idLote)
        {
            List<Cortina> lista = new List<Cortina>();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT IdCortina, IdLote, Nombre FROM Cortinas WHERE IdLote = @IdLote", cn);
                cmd.Parameters.AddWithValue("@IdLote", idLote);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Cortina
                        {
                            IdCortina = (int)dr["IdCortina"],
                            IdLote = (int)dr["IdLote"],
                            Nombre = dr["Nombre"].ToString()
                        });
                    }
                }
            }

            return lista;
        }
    }
}
