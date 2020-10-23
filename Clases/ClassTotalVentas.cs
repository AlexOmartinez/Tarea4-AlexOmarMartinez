using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_AlexOmarMartinez.Clases
{
    class ClassTotalVentas
    {
        public void TotalVentasySalario(double vdl,double vdm,double vdmi,double vdj,double vdv)
        {
            double tv = vdl + vdm + vdmi + vdj + vdv;
            double sal = tv * 0.05;

            MessageBox.Show(tv.ToString());
            MessageBox.Show(sal.ToString());

        }

        public double TotalVentasySalario2(double vdl, double vdm, double vdmi, double vdj, double vdv)
        {
            double tv = vdl + vdm + vdmi + vdj + vdv;
            double sal;
            sal = tv * 0.05;

            return tv;
        }

        public double TotalVentasySalario3(double vdl, double vdm, double vdmi, double vdj, double vdv)
        {
            double tv = vdl + vdm + vdmi + vdj + vdv;
            double sal;
            sal = tv * 0.05;

            return sal;
        }
    }
}
