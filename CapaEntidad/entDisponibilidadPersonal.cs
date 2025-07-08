using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDisponibilidadPersonal
    {
        public int idDisponibilidad { get; set; }
        public int idEmpleado { get; set; }
        public int idLote { get; set; }
        public DateTime horaInicio { get; set; }
        public DateTime horaFin { get; set; }
    }
}
