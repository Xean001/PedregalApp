using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ConteoFruta
    {
        public int Id { get; set; }
        public int IdArbol { get; set; }
        public string IdTrabajador { get; set; }
        public DateTime FechaHora { get; set; }
        public int TotalFrutos { get; set; }
        public string NombreTrabajador { get; set; }
        public int NumeroArbol { get; set; }
    }
}
