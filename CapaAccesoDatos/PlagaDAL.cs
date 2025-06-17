using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class PlagaDAL
    {
        public bool InsertarPlaga(Plaga plaga)
        {
            bool resultado = false;
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                string query = @"INSERT INTO Plaga (NombrePlaga, TipoPlaga, Descripcion, Habilitado) 
                         VALUES (@NombrePlaga, @TipoPlaga, @Descripcion, @Habilitado)";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@NombrePlaga", plaga.NombrePlaga);
                cmd.Parameters.AddWithValue("@TipoPlaga", plaga.TipoPlaga);
                cmd.Parameters.AddWithValue("@Descripcion", plaga.Descripcion);
                cmd.Parameters.AddWithValue("@Habilitado", plaga.Habilitado);

                cn.Open();
                resultado = cmd.ExecuteNonQuery() > 0;
            }
            return resultado;
        }
        public List<Plaga> ListarPlagas()
    {
        List<Plaga> lista = new List<Plaga>();
        using (SqlConnection cn = Conexion.Instancia.Conectar())
        {
            string query = "SELECT IdPlaga, NombrePlaga, TipoPlaga, Descripcion, Habilitado FROM Plaga";
            SqlCommand cmd = new SqlCommand(query, cn);

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Plaga
                {
                    IdPlaga = Convert.ToInt32(dr["IdPlaga"]),
                    NombrePlaga = dr["NombrePlaga"].ToString(),
                    TipoPlaga = dr["TipoPlaga"].ToString(),
                    Descripcion = dr["Descripcion"].ToString(),
                    Habilitado = Convert.ToBoolean(dr["Habilitado"])
                });
            }
        }
        return lista;
    }
    }
}