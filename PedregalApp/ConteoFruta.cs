using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidad;
namespace PedregalApp
{
    public partial class ConteoFruta : Form
    {
        private LoteBLL LoteBLL = new LoteBLL();
        private CortinaBLL CortinaBLL = new CortinaBLL();
        private LineaBLL LineaBLL = new LineaBLL();
        private ArbolBLL ArbolBLL = new ArbolBLL();
        private ConteoFrutaBLL conteoBLL = new ConteoFrutaBLL();
        private TrabajadorBLL trabajadorBLL = new TrabajadorBLL();
        public ConteoFruta()
        {
            InitializeComponent();
            CargarLotes();
            CargarTrabajadores();
        }
        private void CargarLotes()
        {
            List<Lote> lotes = LoteBLL.ObtenerLotes();
            cmbLote.DataSource = lotes;
            cmbLote.DisplayMember = "numero";
            cmbLote.ValueMember = "IdLote";
        }
        private void CargarCortinas(int idLote)
        {
            List<Cortina> cortinas = CortinaBLL.ObtenerCortinasPorLote(idLote);
            cmbCortina.DataSource = cortinas;
            cmbCortina.DisplayMember = "Nombre";
            cmbCortina.ValueMember = "IdCortina";
        }

        private void CargarLineas(int idCortina)
        {
            List<Lineas> lineas = LineaBLL.ObtenerLineasPorCortina(idCortina);
            cmbLinea.DataSource = lineas;
            cmbLinea.DisplayMember = "Numero";
            cmbLinea.ValueMember = "IdLinea";
        }

        private void CargarArboles(int idLinea)
        {
            List<Arbol> arboles = ArbolBLL.ObtenerArbolesPorLinea(idLinea);
            cmbArbol.DataSource = arboles;
            cmbArbol.DisplayMember = "Numero";
            cmbArbol.ValueMember = "IdArbol";
        }
        private void CargarTrabajadores()
        {
            List<Trabajador> trabajadores = trabajadorBLL.ObtenerTrabajadores();
            cmbTrabajador.DataSource = trabajadores;
            cmbTrabajador.DisplayMember = "Nombre";
            cmbTrabajador.ValueMember = "IdTrabajador";
        }


        private void cmbLote_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLote.SelectedValue is int idLote)
            {
                CargarCortinas(idLote);
            }
        }

        private void cmbCortina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCortina.SelectedValue is int idCortina)
            {
                CargarLineas(idCortina);
            }
        }

        private void cmbLinea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLinea.SelectedValue is int idLinea)
            {
                CargarArboles(idLinea);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    CapaEntidad.ConteoFruta nuevoConteo = new CapaEntidad.ConteoFruta
                    {
                        IdArbol = Convert.ToInt32(cmbArbol.SelectedValue),
                        IdTrabajador = cmbTrabajador.SelectedValue.ToString(),
                        FechaHora = DateTime.Now,
                        TotalFrutos = int.Parse(txtTotalFrutos.Text)
                    };



                    bool exito = conteoBLL.RegistrarConteo(nuevoConteo);

                    if (exito)
                        MessageBox.Show("Conteo registrado correctamente.");
                    else
                        MessageBox.Show("Error al registrar conteo.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnMostrarConteos_Click(object sender, EventArgs e)
        {
            try
            {
                List<CapaEntidad.ConteoFruta> conteos = conteoBLL.ObtenerConteos();
                dgvConteos.DataSource = conteos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar conteos: " + ex.Message);
            }
        }
    }
}