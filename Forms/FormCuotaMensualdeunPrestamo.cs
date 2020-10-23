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
    public partial class FormCuotaMenPrest : Form
    {
        Clases.ClassCuotadeunPrestamo cp = new Clases.ClassCuotadeunPrestamo();
        public FormCuotaMenPrest()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double p = Convert.ToDouble(TxtPrestamo.Text);
            double pa = Convert.ToDouble(TxtPlazoAños.Text);
            double ia = Convert.ToDouble(TxtTasaIntAnual.Text);

            TxtCuotaMensual.Text = cp.CuotadeunPrestamo2(p, pa, ia).ToString();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtPrestamo.Clear();
            TxtPlazoAños.Clear();
            TxtTasaIntAnual.Clear();
            TxtCuotaMensual.Clear();
        }
    }
}
