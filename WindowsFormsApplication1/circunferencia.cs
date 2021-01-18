using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsApplication1
{
    class circunferencia:vector
    {

        public
        double RD;

        public void EncenderC(ref Bitmap a)
        {
            float t = 0;
            float dt = 0.002f;
            vector v = new vector();
            v.col0 = col0;
            v.R = R;
            v.G = G;
            v.B = B;
            do
            {
                v.x0 = x0 + RD * Math.Cos(t);
                v.y0 = y0 + RD * Math.Sin(t);
                v.proceso_encender(ref a);
                t = t + dt;
            }
            while (t <= 2 * 3.14);

        }
        public virtual void ApagarC(ref Bitmap Pixel)
        {
            float t = 0;
            float dt = 0.002f;
            vector v = new vector();
            v.col0 = Color.White;
            v.R = R;
            v.G = G;
            v.B = B;
            do
            {
                v.x0 = x0 + RD * Math.Cos(t);
                v.y0 = y0 + RD * Math.Sin(t);
                v.proceso_encender(ref Pixel);
                t = t + dt;
            }
            while (t <= 2 * 3.14);
        }
    }
}
