using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class ArbolDAL
    {
        public List<Arbol> ListarArbolesPorLinea(int idLinea)
        {
            List<Arbol> lista = new List<Arbol>();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT IdArbol, IdLinea, Numero FROM Arboles WHERE IdLinea = @IdLinea", cn);
                cmd.Parameters.AddWithValue("@IdLinea", idLinea);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Arbol
                        {
                            IdArbol = (int)dr["IdArbol"],
                            IdLinea = (int)dr["IdLinea"],
                            Numero = (int)dr["Numero"]
                        });
                    }
                }
            }

            return lista;
        }
    }
}
