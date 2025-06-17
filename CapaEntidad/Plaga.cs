using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Plaga
    {
        public int IdPlaga { get; set; } 
        public string NombrePlaga { get; set; }
        public string TipoPlaga { get; set; }
        public string Descripcion { get; set; }
        public bool Habilitado { get; set; }  
    }
}
