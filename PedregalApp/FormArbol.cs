using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace PedregalApp
{
    public partial class FormArbol : Form
    {
        public FormArbol()
        {
            InitializeComponent();
            CargarLotes();
        }
        public void CargarLotes()
        {
            try
            {
                List<entLote> lotes = logLote.Instancia.ListarLotes();
                cmbLote.DataSource = lotes;
                cmbLote.DisplayMember = "nom_lot";
                cmbLote.ValueMember = "id_lot";
                cmbLote.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar lotes: " + ex.Message);
            }
        }
        private void CargarCortinas(int idLote)
        {
            try
            {
                List<entCortina> cortinas = logCortina.Instancia.ListarCortinasPorLote(idLote);
                cmbCortina.DataSource = cortinas;
                cmbCortina.DisplayMember = "nom_cor";
                cmbCortina.ValueMember = "id_cor";
                cmbCortina.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cortinas: " + ex.Message);
            }
        }
        private void CargarLineas(int idCortina)
        {
            try
            {
                List<entLinea> lineas = logLinea.Instancia.ListarLineasPorCortina(idCortina);
                cmbLinea.DataSource = lineas;
                cmbLinea.DisplayMember = "nom_lin";  // Asegúrate que este sea el nombre correcto
                cmbLinea.ValueMember = "id_lin";
                cmbLinea.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar líneas: " + ex.Message);
            }
        }
        private void cmbCortina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCortina.SelectedItem is entCortina cortinaSeleccionada)
            {
                int idCortina = cortinaSeleccionada.id_cor;
                CargarLineas(idCortina);
            }
        }


        private void cmbLote_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLote.SelectedItem is entLote loteSeleccionado)
            {
                int idLoteSeleccionado = loteSeleccionado.id_lot;
                CargarCortinas(idLoteSeleccionado);
            }
        }
        private void CargarArbolesEnGrilla()
        {
            try
            {
                dgvDatos.DataSource = logArbol.Instancia.ListarArbolesCompleto();
               

                // Ocultar la columna id_arbol
                if (dgvDatos.Columns["id_arbol"] != null)
                {
                    dgvDatos.Columns["id_arbol"].Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los árboles: " + ex.Message);
            }
        }

        private void btnRegistrarArbol_Click(object sender, EventArgs e)
        {
            if (cmbLinea.SelectedItem is entLinea lineaSeleccionada)
            {
                int idLinea = lineaSeleccionada.id_lin;

                if (int.TryParse(txtCantidadArboles.Text, out int cantidad) && cantidad > 0)
                {
                    int totalExistente = logArbol.Instancia.ObtenerTotalArboles(idLinea);

                    for (int i = 1; i <= cantidad; i++)
                    {
                        string codigoGenerado = $"L{cmbLote.SelectedIndex + 1:00}-C{cmbCortina.SelectedIndex + 1}-L{cmbLinea.SelectedIndex + 1}-A{totalExistente + i:000}";

                        entArbol nuevoArbol = new entArbol
                        {
                            id_lin = idLinea,
                            codigo = codigoGenerado,
                            estado = "Activo"
                        };

                        logArbol.Instancia.RegistrarArbol(nuevoArbol);
                        CargarArbolesEnGrilla();
                    }

                    MessageBox.Show("Árbol(es) registrados correctamente.");
                }
                else
                {
                    MessageBox.Show("Ingrese una cantidad válida.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una línea primero.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtBuscar.Text.Trim();
            if (codigo == "") return;

            entArbolMostrar arbol = logArbol.Instancia.BuscarArbolPorCodigo(codigo);
            if (arbol != null)
            {
                dgvDatos.Rows.Clear();
                dgvDatos.Rows.Add(arbol.codigo, arbol.estado, arbol.nombre_lote, arbol.nombre_cortina, arbol.nombre_linea);
            }
            else
            {
                MessageBox.Show("Árbol no encontrado.");
            }
        }
    }
}
