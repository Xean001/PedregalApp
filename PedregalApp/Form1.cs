using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedregalApp
{
    public partial class Form1 : Form
    {
        bool sideBarExpand;
        bool monitoreoCollapse;
        bool controlCalidadCollapse;
        bool cosechaRecepcionCollapse;
        bool empaqueCollapse;
        FormControlCalidad formControlCalidad;
        FormArbol formArbol;
        FormCategorizacion formCategorizacion;
        public Form1()
        {
            InitializeComponent();
        }
        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBar.Width -= 20;
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                sideBar.Width += 20;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    sideBarTimer.Stop();
                }
            }
        }

        private void menuBotton_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void monitoreoTimer_Tick(object sender, EventArgs e)
        {
            if (monitoreoCollapse)
            {
                monitoreoContainer.Height -= 20;
                if (monitoreoContainer.Height == monitoreoContainer.MinimumSize.Height)
                {
                    monitoreoCollapse = false;
                    monitoreoTimer.Stop();
                }
            }
            else
            {
                monitoreoContainer.Height += 20;
                if (monitoreoContainer.Height == monitoreoContainer.MaximumSize.Height)
                {
                    monitoreoCollapse = true;
                    monitoreoTimer.Stop();
                }
            }
        }

        private void btnMoniBiolo_Click(object sender, EventArgs e)
        {
            monitoreoTimer.Start();
        }

        private void controlCalidadTimer_Tick(object sender, EventArgs e)
        {
            if (controlCalidadCollapse)
            {
                controlCalidadContainer.Height -= 20;
                if (controlCalidadContainer.Height == controlCalidadContainer.MinimumSize.Height)
                {
                    controlCalidadCollapse = false;
                    controlCalidadTimer.Stop();
                }
            }
            else
            {
                controlCalidadContainer.Height += 20;
                if (controlCalidadContainer.Height == controlCalidadContainer.MaximumSize.Height)
                {
                    controlCalidadCollapse = true;
                    controlCalidadTimer.Stop();
                }
            }
        }

        private void btnControlCalidad_Click(object sender, EventArgs e)
        {
            controlCalidadTimer.Start();
        }

        private void btnCosechaRecepcion_Click(object sender, EventArgs e)
        {
            cosechatimer.Start();
        }

        private void cosechatimer_Tick(object sender, EventArgs e)
        {
            if (cosechaRecepcionCollapse)
            {
                cosechaRecepcionContainer.Height -= 20;
                if (cosechaRecepcionContainer.Height == cosechaRecepcionContainer.MinimumSize.Height)
                {
                    cosechaRecepcionCollapse = false;
                    cosechatimer.Stop();
                }
            }
            else
            {
                cosechaRecepcionContainer.Height += 20;
                if (cosechaRecepcionContainer.Height == cosechaRecepcionContainer.MaximumSize.Height)
                {
                    cosechaRecepcionCollapse = true;
                    cosechatimer.Stop();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void empaqueTimer_Tick(object sender, EventArgs e)
        {
            if (empaqueCollapse)
            {
                empaqueContainer.Height -= 20;
                if (empaqueContainer.Height == empaqueContainer.MinimumSize.Height)
                {
                    empaqueCollapse = false;
                    empaqueTimer.Stop();
                }
            }
            else
            {
                empaqueContainer.Height += 20;
                if (empaqueContainer.Height == empaqueContainer.MaximumSize.Height)
                {
                    empaqueCollapse = true;
                    empaqueTimer.Stop();
                }
            }
        }

        private void btnEmpaque_Click(object sender, EventArgs e)
        {
            empaqueTimer.Start();   
        }

        private void btnConteo_Click(object sender, EventArgs e)
        {
            if (formArbol == null)
            {
                formArbol = new FormArbol();
                formArbol.FormClosed += formArbol_FormClosed;
                formArbol.MdiParent = this;
                formArbol.Show();
            }
            else
            {
                formArbol.Activate();
            }
        }
           
        private void formArbol_FormClosed(object sender, FormClosedEventArgs e)
        {
            formArbol = null;
        }

        private void btnCategorizacion_Click(object sender, EventArgs e)
        {
            if (formCategorizacion == null)
            {
                formCategorizacion = new FormCategorizacion();
                formCategorizacion.FormClosed += formCategorizacion_FormClosed;
                formCategorizacion.MdiParent = this;
                formCategorizacion.Show();
            }
            else
            {
                formCategorizacion.Activate();
            }
        }
        private void formCategorizacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            formCategorizacion = null;
        }
    }
}
    

