using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class PlagaBLL
    {
        private PlagaDAL plagaDAL = new PlagaDAL();

        public bool RegistrarPlaga(Plaga plaga)
        {
            return plagaDAL.InsertarPlaga(plaga);
        }

        public List<Plaga> ObtenerPlagas()
        {
            return plagaDAL.ListarPlagas();
        }
    }
}
