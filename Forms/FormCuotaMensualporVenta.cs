﻿using System;
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
    public partial class FormCuotaMensVenta : Form
    {
        Clases.ClassCuotaVentaComputadora cv = new Clases.ClassCuotaVentaComputadora();
        public FormCuotaMensVenta()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double pc = Convert.ToDouble(TxtPrecioCont.Text);
            double cm = Convert.ToDouble(TxtTMeses.Text);

            TxtCuotaMens.Text = cv.CuotaVenta2(pc,cm).ToString();

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtCuotaMens.Clear();
            TxtPrecioCont.Clear();
            TxtTMeses.Clear();
        }
    }
}
