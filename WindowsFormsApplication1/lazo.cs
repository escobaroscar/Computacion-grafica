using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class lazo: circunferencia
    {
        public void encender_lazo(ref Bitmap a)
        {
            float t = 0;
            float dt = 0.001f;
            vector v = new vector();
            v.col0 = Color.Black;
            do
            {
                v.x0 = x0 + RD * Math.Sin(2 * t);
                v.y0 = y0 + RD * Math.Cos(3 * t);
                v.proceso_encender(ref a);
                t = t + dt;
            }
            while (t <= 2 * Math.PI);

        }
    }
}
