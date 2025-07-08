using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;


namespace CapaAccesoDatos
{
    public class datLote
    
        {
            private static readonly datLote _instancia = new datLote();
            public static datLote Instancia => _instancia;

            public List<entLote> ListarLotes()
            {
                SqlCommand cmd = null;
                List<entLote> lista = new List<entLote>();

                try
                {
                    SqlConnection cn = Conexion.Instancia.Conectar();
                    cmd = new SqlCommand("spListarLotes", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        entLote l = new entLote();
                        l.id_lot = Convert.ToInt32(dr["id_lot"]);
                        l.nom_lot = dr["nom_lot"].ToString();
                    lista.Add(l);
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


