using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Vector3D : vector
    {


        public double z;



        public void Axonometria(double x, double y, double z, out double ax, out double ay)
        {
            ax = x + (0.6) * y * Math.Cos(0.8);
            ay = (0.6) * y * Math.Sin(0.8) + z;
        }

        public void encender_vector3D(ref Bitmap a)
        {
            double ax;
            double ay;
            int Sx;
            int Sy;
            Axonometria(x0, y0, z, out ax, out ay);
            Pantalla(ax, ay, out Sx, out Sy);
            if (Sx >= 0 && Sx < 640 && Sy >= 0 && Sy < 480)
            {
                Encender_Pixel(Sx, Sy, ref a);
            }
        }
    }
}
