using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_AlexOmarMartinez.Clases
{
    class ClassCuotadeunPrestamo
    {
        public void CuotadeunPrestamo(double p,double pa,double ia)
        {
            double i = p * pa * ia;
            double td = p + i;
            double cm = td / (pa * 12);

            MessageBox.Show(cm.ToString());
        }

        public double CuotadeunPrestamo2(double p, double pa, double ia)
        {
            double res;
            double i = p * pa * ia;
            double td = p + i;
            res = td / (pa * 12);
            return res;
        }
    }
}
