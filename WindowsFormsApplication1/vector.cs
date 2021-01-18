using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class vector
    {
        public double x0, y0;

        public int R = 0, G = 0, B = 0;
        public Color col0;




        public void proceso_encender(ref Bitmap a)
        {
            int Sx, Sy;
            Pantalla(x0, y0, out Sx, out Sy);
            if (Sx >= 0 && Sx < 640 && Sy >= 0 && Sy < 480)
            {
                Encender_Pixel(Sx, Sy, ref a);


            }


        }
        //Ventana del computador
        public static int Sx1 = 0;
        public static int Sx2 = 640;
        public static int Sy1 = 0;
        public static int Sy2 = 480;

        //Ventana real
        public static double x1 = -10;
        public static double x2 = 10;
        public static double y1 = -7.5;
        public static double y2 = 7.5;
        public void Pantalla(double x, double y, out int sx, out int sy)
        {
            sx = (int)(((Sx1 - Sx2) / (x1 - x2)) * (x - x1)) + Sx1;
            sy = (int)(((Sy1 - Sy2) / (y2 - y1)) * (y - y2)) + Sy1;
        }

        public void Encender_Pixel(int Sxx, int Syy, ref Bitmap a)
        {
            for (int i = Sxx; i <= Sxx; i++)
            {
                a.SetPixel(Sxx, Syy, col0);

            }

        }
        public virtual void Apagar(ref Bitmap Pixel)
        {
            col0 = Color.Red;
            proceso_encender( ref Pixel);
        }

        public virtual void Transforma(int sx, int sy, out double x, out double y)
        {
            x = ((((double)(sx) - 0) / (0 - 640)) * (-10 - 10)) + (-10);
            y = ((((double)(sy) - 0) / (0 - 480)) * (7.67 - (-7.67))) + 7.67;
        }
        public double Lagrange(int x, int nD, double[] vx, double[] vy)
        {
            double S, P;
            int i, j; S = 0;
            for (i = 0; i < nD; i++)
            {
                P = 1;
                for (j = 0; j < nD; j++)
                {
                    if (j != i)
                    {
                        P = P * (x - vx[j]) / (vx[i] - vx[j]);
                    }
                }
                S = S + vy[i] * P;
            }
            return S;
        }
    }
}
