using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea4_AlexOmarMartinez.Clases;

namespace Tarea4_AlexOmarMartinez.Forms
{
    public partial class FormTotalVentas : Form
    {
        Clases.ClassTotalVentas Tventas = new ClassTotalVentas();
        public FormTotalVentas()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormTotalVentas_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double vdl = Convert.ToDouble(TxtVentDiaLun.Text);
            double vdm = Convert.ToDouble(TxtVentDiaMart.Text);
            double vdmi = Convert.ToDouble(TxtVentDiaMier.Text);
            double vdj = Convert.ToDouble(TxtVentDiaJueves.Text);
            double vdv = Convert.ToDouble(TxtVentDiaVier.Text);

            TxtSalario.Text = Tventas.TotalVentasySalario3(vdl, vdm, vdmi, vdj, vdv).ToString();
            TxtTotalVentas.Text=Tventas.TotalVentasySalario2(vdl, vdm, vdmi, vdj, vdv).ToString();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtSalario.Clear();
            TxtTotalVentas.Clear();
            TxtVentDiaJueves.Clear();
            TxtVentDiaLun.Clear();
            TxtVentDiaMart.Clear();
            TxtVentDiaMier.Clear();
            TxtVentDiaVier.Clear();
        }
    }
}
