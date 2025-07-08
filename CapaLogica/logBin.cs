using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogica
{
    public class logBin
    {
        #region sigleton
        private static readonly logBin _instancia = new logBin();
        public static logBin Instancia { get {  return _instancia; } }
        #endregion singleton
        #region metodos
        public List<entBin> ListarBin()
        {
            return datBin.Instancia.ListarBin();
        }
        public void InsertaBin(entBin Bin)
        {
            datBin.Instancia.InsertarBin(Bin);
        }
        public void EditaBin(entBin Bin)
        {
            datBin.Instancia.EditarBin(Bin);
        }
        public void DeshabilitarBin(entBin Bin)
        {
            datBin.Instancia.DeshabilitarBin(Bin);
        }
        public void BuscarBin(entBin Bin)
        {
            datBin.Instancia.BuscarBin(Bin);
        }
        #endregion metodos

    }
}
