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
    public partial class FormControlCalidad : Form
    {
        public FormControlCalidad()
        {
            InitializeComponent();
            CargarComboLotes();
            CargarComboEmpleados();
            ListarConteo();
            cmbLote.SelectedIndexChanged += cmbLote_SelectedIndexChanged;
            cmbCortina.SelectedIndexChanged += cmbCortina_SelectedIndexChanged;
            cmbLinea.SelectedIndexChanged += cmbLinea_SelectedIndexChanged;

        }
        private void CargarComboLotes()
        {
            cmbLote.DataSource = logLote.Instancia.ListarLotes();
            cmbLote.DisplayMember = "num_lot";
            cmbLote.ValueMember = "id_lot";
            cmbLote.SelectedIndex = -1;
        }
        private void CargarComboEmpleados()
        {
            cmbEmpleado.DataSource = logEmpleado.Instancia.ListarEmpleados();
            cmbEmpleado.DisplayMember = "nom_emp";
            cmbEmpleado.ValueMember = "id_emp";
            cmbEmpleado.SelectedIndex = -1;
        }

        private void cmbLote_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLote.SelectedValue is int idLote)
            {
                cmbCortina.DataSource = logCortina.Instancia.ListarCortinasPorLote(idLote);
                cmbCortina.DisplayMember = "num_cor";
                cmbCortina.ValueMember = "id_cor";
            }
        }
        private void cmbCortina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCortina.SelectedValue is int idCortina)
            {
                cmbLinea.DataSource = logLinea.Instancia.ListarLineasPorCortina(idCortina);
                cmbLinea.DisplayMember = "num_lin";
                cmbLinea.ValueMember = "id_lin";
            }
        }
        private void cmbLinea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLinea.SelectedValue is int idLinea)
            {
                cmbArbol.DataSource = logArbol.Instancia.ListarArbolesPorLinea(idLinea);
                cmbArbol.DisplayMember = "num_arb";
                cmbArbol.ValueMember = "id_arb";
            }
        }


        public void ListarConteo()
        {
            dgvDatos.DataSource = logConteo.Instancia.ListarConteo();

            if (dgvDatos.Columns["id_lot"] != null)
                dgvDatos.Columns["id_lot"].Visible = false;

            if (dgvDatos.Columns["id_emp"] != null)
                dgvDatos.Columns["id_emp"].Visible = false;
            
        }

        private void btnNuevo1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;

            btnNuevo1.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;
        }
        private void LimpiarVariables()
        {
            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbLote.SelectedValue == null || cmbEmpleado.SelectedValue == null || string.IsNullOrWhiteSpace(txtCantidad.Text))
                {
                    MessageBox.Show("Debe completar todos los campos.");
                    return;
                }

                if (!int.TryParse(txtCantidad.Text, out int cantidad))
                {
                    MessageBox.Show("Cantidad debe ser un número válido.");
                    return;
                }

                entConteo c = new entConteo
                {
                    id_lot = Convert.ToInt32(cmbLote.SelectedValue),
                    id_emp = Convert.ToInt32(cmbEmpleado.SelectedValue),
                    can_con = cantidad
                };

                logConteo.Instancia.InsertarConteo(c);

                MessageBox.Show("¡Conteo agregado correctamente!");
                ListarConteo();
                groupBox1.Enabled = false;
                LimpiarVariables();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }
    }
    
}
