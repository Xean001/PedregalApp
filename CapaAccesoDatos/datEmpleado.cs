﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaAccesoDatos
{

    public class datEmpleado
    {
        private static readonly datEmpleado _instancia = new datEmpleado();
        public static datEmpleado Instancia => _instancia;

        public List<entEmpleado> ListarEmpleados()
        {
            SqlCommand cmd = null;
            List<entEmpleado> lista = new List<entEmpleado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarEmpleados", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new entEmpleado
                    {
                        id_empleado = Convert.ToInt32(dr["id_empleado"]),
                        nombre = dr["nombre"].ToString(),
                        cargo = dr["cargo"].ToString(),
                        dni = dr["dni"].ToString()
                    });
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