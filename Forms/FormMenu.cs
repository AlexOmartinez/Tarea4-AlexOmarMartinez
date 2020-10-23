using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_AlexOmarMartinez.Forms
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSalEyN_Click(object sender, EventArgs e)
        {
            Forms.FormSalExtNeto salExtNeto = new FormSalExtNeto();
            salExtNeto.Show();
        }

        private void BtnCuotaMP_Click(object sender, EventArgs e)
        {
            Forms.FormCuotaMenPrest cuotaMenPrest = new FormCuotaMenPrest();
            cuotaMenPrest.Show();
        }

        private void BtnNSal_Click(object sender, EventArgs e)
        {
            Forms.FormNSal nSal = new Forms.FormNSal();
            nSal.Show();
        }

        private void BtnCuotaMV_Click(object sender, EventArgs e)
        {
            Forms.FormCuotaMensVenta cuotaMensVenta = new FormCuotaMensVenta();
            cuotaMensVenta.Show();
        }

        private void BtnTVentas_Click(object sender, EventArgs e)
        {
            Forms.FormTotalVentas totalVentas = new Forms.FormTotalVentas();
            totalVentas.Show();
        }
    }
}
