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
    }
}
    

