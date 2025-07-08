using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logDisponibilidadPersonal
    {
        #region singleton
        private static readonly logDisponibilidadPersonal _instancia = new logDisponibilidadPersonal();
        public static logDisponibilidadPersonal Instancia { get { return _instancia; } }
        #endregion singleton

        #region metodos
        public List<entDisponibilidadPersonal> ListarDisponibilidad()
        {
            return datDisponibilidadPersonal.Instancia.ListarDisponibilidad();
        }
        public bool InsertarDisponibilidad(entDisponibilidadPersonal disp)
        {
            return datDisponibilidadPersonal.Instancia.InsertarDisponibilidad(disp);
        }

        public bool ActualizarDisponibilidad(entDisponibilidadPersonal disp)
        {
            return datDisponibilidadPersonal.Instancia.ActualizarDisponibilidad(disp);
        }

        //public bool BuscarDisponibilidadUnica(entDisponibilidadPersonal disp)
        //{
        //    return datDisponibilidadPersonal.Instancia.BuscarDisponibilidadPorTrabajador(disp);
        //}
        public List<entDisponibilidadPersonal> BuscarDisponibilidadPorTrabajador(entDisponibilidadPersonal filtro)
        {
            return datDisponibilidadPersonal.Instancia.ListarDisponibilidadPorTrabajador(filtro);
        }
        #endregion metodos
    }
}
