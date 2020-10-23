using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Tarea4_AlexOmarMartinez.Clases
{
    class ClassCuotaVentaComputadora
    {
        public void CuotaVenta(double pc, double tpm)
        {
            double tpc = (pc * 0.35) + pc;
            double cm = tpc / tpm;

            MessageBox.Show(cm.ToString());
        }

        public double CuotaVenta2(double pc, double tpm)
        {
            double tpc = (pc * 0.35) + pc;
            double cm = tpc / tpm;

            return cm;
        }
    }
}
