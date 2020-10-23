using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_AlexOmarMartinez.Clases
{
    class ClassNuevoSalariodeunEmpleado
    {
        public void NuevoSalario(double sala, double aum)
        {
            double res = (sala * aum)+sala;

            MessageBox.Show(res.ToString());
        }

        public double NuevoSalario2(double sala,double aum)
        {
            double res;
            res = (sala * aum) + sala;

            return res;
        }
    }
}
