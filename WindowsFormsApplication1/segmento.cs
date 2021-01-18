using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class segmento:vector
    {

        public
        double xf, yf, X0, Y0;
        vector ve = new vector();
        public Color col0;
        public void encender(ref Bitmap a)
        {
            vector ve = new vector();
            ve.col0 = col0;
            double t = 0, dt = 0.001;
            do
            {
                ve.x0 = X0 * (1 - t) + xf * t;
                ve.y0 = Y0 * (1 - t) + yf * t;
                ve.proceso_encender(ref a);
                t = t + dt;
            }
            while (t <= 1);

        }
    }
}
