using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class ConteoFrutaDAL
    {
        public bool InsertarConteoFruta(ConteoFruta conteo)
        {
            bool resultado = false;
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(@"INSERT INTO ConteoFruta 
                    (IdArbol, IdTrabajador, FechaHora, TotalFrutos) 
                    VALUES (@IdArbol, @IdTrabajador, @FechaHora, @TotalFrutos)", cn);

                cmd.Parameters.AddWithValue("@IdArbol", conteo.IdArbol);
                cmd.Parameters.AddWithValue("@IdTrabajador", conteo.IdTrabajador);
                cmd.Parameters.AddWithValue("@FechaHora", conteo.FechaHora);
                cmd.Parameters.AddWithValue("@TotalFrutos", conteo.TotalFrutos);

                cn.Open();
                resultado = cmd.ExecuteNonQuery() > 0;
            }
            return resultado;
        }

        public List<ConteoFruta> ListarConteos()
        {
            List<ConteoFruta> lista = new List<ConteoFruta>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())

            {
                string query = @"SELECT c.Id, c.IdArbol, a.Numero AS NumeroArbol,
                                c.IdTrabajador, t.Nombre AS NombreTrabajador,
                                c.FechaHora, c.TotalFrutos
                         FROM ConteoFruta c
                         INNER JOIN Arboles a ON c.IdArbol = a.IdArbol
                         INNER JOIN Trabajadores t ON c.IdTrabajador = t.IdTrabajador";

                SqlCommand cmd = new SqlCommand(query, cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new ConteoFruta
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        IdArbol = Convert.ToInt32(dr["IdArbol"]),
                        NumeroArbol = Convert.ToInt32(dr["NumeroArbol"]),
                        IdTrabajador = dr["IdTrabajador"].ToString(),
                        NombreTrabajador = dr["NombreTrabajador"].ToString(),
                        FechaHora = Convert.ToDateTime(dr["FechaHora"]),
                        TotalFrutos = Convert.ToInt32(dr["TotalFrutos"])
                    });
                }
            }
            return lista;
        }
    }
}
