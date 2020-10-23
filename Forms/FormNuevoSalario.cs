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
    public partial class FormNSal : Form
    {
        Clases.ClassNuevoSalariodeunEmpleado NsalE = new Clases.ClassNuevoSalariodeunEmpleado();
        public FormNSal()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double sala = Convert.ToDouble(TxtSalActual.Text);
            double aum = Convert.ToDouble(TxtAumentoX.Text);

            TxtNuevoSal.Text = NsalE.NuevoSalario2(sala, aum).ToString();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtNuevoSal.Clear();
            TxtAumentoX.Clear();
            TxtSalActual.Clear();
        }
    }
}
