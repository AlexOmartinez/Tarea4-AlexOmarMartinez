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
    public partial class FormSalExtNeto : Form
    {
        Clases.ClassCalculos cal = new ClassCalculos();
   
        public FormSalExtNeto()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double sb = Convert.ToDouble(TxtSalbase.Text);
            double he = Convert.ToDouble(TxtHorasExtras.Text);
            double vhe = Convert.ToDouble(TxtValorHE.Text);

            TxtSalExtra.Text = cal.Salarios2(sb, he, vhe).ToString();
            TxtSalNeto.Text = cal.Salarios3(sb, he, vhe).ToString();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtHorasExtras.Clear();
            TxtSalbase.Clear();
            TxtSalExtra.Clear();
            TxtSalNeto.Clear();
            TxtValorHE.Clear();

        }
    }
}
