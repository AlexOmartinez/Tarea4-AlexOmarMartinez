using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_AlexOmarMartinez.Clases
{
    class ClassCalculos
    {
        public void Salarios(double sb, double he,double vhe)
        {
            double tsaex = he * vhe;
            double res = sb + tsaex;
            double ded = res * 0.05;
            double tsal = res - ded;

            MessageBox.Show(tsaex.ToString());
            MessageBox.Show(tsal.ToString());

        }

        public double Salarios2(double sb, double he, double vhe)
        {
            double tsa,tsaex;
            tsaex = he * vhe;
            double res = sb + tsaex;
            double ded = sb * 0.05;
            tsa = res - ded;

            return tsaex;
            
        }

        public double Salarios3(double sb, double he, double vhe)
        {
            double tsa, tsaex;
            tsaex = he * vhe;
            double res = sb + tsaex;
            double ded = sb * 0.05;
            tsa = res - ded;
            return tsa;
        }
    }
}
