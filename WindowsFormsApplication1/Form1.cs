using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double X, Y, XF, YF, RAD;
        public Color[] paletaCesped = new Color[16];
        public Color[] paletaPiedra = new Color[16];
        public Color[] paletaAgua = new Color[16];
        public Color[] paleta2 = new Color[16];

        public Color[] colorP = new Color[16];

        private void Form1_Load(object sender, EventArgs e)
        {
            //int width = 640, height = 480;
            //// declaracion de vvariables para el tamaño de la imagen bitmap

            //Bitmap bmp = new Bitmap(width,height);

            //// dibujamos el pixel 
            //bmp.SetPixel(40, 40, Color.FromArgb(204, 18, 4));

            //// ponemos el pexel en la imagen 
            //pictureBox1.Image = bmp;

            //// guardamos la imagen

            //bmp.Save("C:\\Users\\Miguel Escobar\\Desktop\\Pixel.png");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int width = 640, height = 480;
            Bitmap bmp = new Bitmap(width, height);

            for (int i = 0; i < 640; i++)
            {
                for (int j = 0; j < 140; j++)
                {
                    bmp.SetPixel(i, j, Color.Red);
                    pictureBox1.Image = bmp;
                }
            }

            for (int i = 0; i < 640; i++)
            {
                for (int j = 141; j < 340; j++)
                {
                    bmp.SetPixel(i, j, Color.Yellow);
                    pictureBox1.Image = bmp;
                }
            }

            for (int i = 0; i < 640; i++)
            {
                for (int j = 341; j < 480; j++)
                {
                    bmp.SetPixel(i, j, Color.Red);
                    pictureBox1.Image = bmp;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // t = 0;
            //Bitmap bmp = new Bitmap(640, 480);
            // vector ob = new vector();
            // int i;
            // ob.col0 = Color.Black;
            // ob.y0=0;
            //  for (i = 0; i < 100; i++)
            //     {   
            //      ob.x0 = i/10;
            Bitmap bmp = new Bitmap(640, 480);
            vector v = new vector();
            v.x0 = 0;
            v.y0 = 0;
            v.col0 = Color.Black;
            double t = 0;
            do
            {
                v.x0 = -2 + t * 6;
                v.y0 = -4 + t * 3;
                t = t + 0.005;
                v.proceso_encender(ref bmp);
                pictureBox1.Image = bmp;
            } while (t <= 1);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(640, 480);
            segmento s = new segmento();


            s.X0 = -5;
            s.Y0 = -6;
            s.xf = 10;
            s.yf = -5;

            s.encender(ref bmp);
            pictureBox1.Image = bmp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(640, 480);
            circunferencia c = new circunferencia();


            c.x0 = -3;
            c.y0 = 1;
            c.RD = 4;


            c.EncenderC(ref bmp);
            pictureBox1.Image = bmp;
        }

        private void laso_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(640, 480);
            lazo l = new lazo();
            l.x0 = -3;
            l.y0 = 1;
            l.RD = 4;

            l.encender_lazo(ref bmp);
            pictureBox1.Image = bmp;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(640, 480);
            //segmento s = new segmento();
            //s.X0 = -5;
            //s.Y0 = 2;
            //s.xf = -5;
            //s.yf = -4;
            //s.encender(ref bmp);
            //segmento s2 = new segmento();
            //s2.X0 = -4;
            //s2.Y0 = -5;
            //s2.xf = 4;
            //s2.yf = 5;
            //s2.encender(ref bmp);
            //segmento2(-5, 2, -5, -4, ref bmp);
            //segmento2(5, 2, 5, -4, ref bmp);
            //segmento2(-5, -4, 5, -4, ref bmp);
            //segmento2(-5, 2, 5, 2, ref bmp);
            //segmento2(-5, -4, 5, 2, ref bmp);
            //segmento2(5, -4, -5, 2, ref bmp);
            //segmento2(-5, 2, 0, 6, ref bmp);
            //segmento2(5, 2, 0, 6, ref bmp);
            //segmento2(6, -2, 6, -4, ref bmp);
            //segmento2(-10, -7.5, 10, 7.5, ref bmp);








            //circunferencia arriba
            circunferencia c = new circunferencia();
            c.x0 = 0;
            c.y0 = 4;
            c.RD = 1;
            c.EncenderC(ref bmp);
            //circunferencia lado
            circunferencia c2 = new circunferencia();
            c2.x0 = 5;
            c2.y0 = 0;
            c2.RD = 1;
            // c2.EncenderC(ref bmp);
            //lazo abajo
            lazo l = new lazo();
            l.x0 = 6;
            l.y0 = -2;
            l.RD = 0.5;
            l.encender_lazo(ref bmp);
            //  pictureBox1.Image = bmp;
            //lazo lateral
            lazo l2 = new lazo();
            l2.x0 = -4;
            l2.y0 = 0;
            l2.RD = 2;
            //l2.encender_lazo(ref bmp);
            // pictureBox1.Image = bmp;
        }

        public void segmento2(double X0, double Y0, double xf, double yf, ref Bitmap bmp, Color color)
        {
            //Bitmap bmp = new Bitmap(640, 480);
            segmento s = new segmento();
            s.X0 = X0;
            s.Y0 = Y0;
            s.xf = xf;
            s.yf = yf;
            s.col0 = color;
            s.encender(ref bmp);
            pictureBox1.Image = bmp;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(640, 480);

            if (pictureBox1.Image != null)
            {
                bmp = (Bitmap)pictureBox1.Image.Clone();
            }
            segmento2(-10, 0, 10, 0, ref bmp,Color.Red);
            segmento2(0, -8, 0, 8, ref bmp, Color.Red);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(640, 480);

            if (pictureBox1.Image != null)
            {
                bmp = (Bitmap)pictureBox1.Image.Clone();
            }
            vector v = new vector();
            double x = -10;
            double dx = 0.001;
            do
            {
                v.x0 = x;
                v.y0 = Math.Sin(x);
                v.col0 = Color.Black;
                v.proceso_encender(ref bmp);
                v.y0 = 0 + x - Math.Pow(x, 3) / 6 + Math.Pow(x, 5) / 120;
                v.col0 = Color.Green;
                v.proceso_encender(ref bmp);
                x = x + dx;
            } while (x < 20);
            pictureBox1.Image = bmp;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(640, 480);
            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 460; j++)
                {
                    bmp.SetPixel(i, j, pictureBox1.BackColor);
                }
            }
            pictureBox1.Image = bmp;
        }



        private void button9_Click_1(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(640, 480);

            if (pictureBox1.Image != null)
            {
                bmp = (Bitmap)pictureBox1.Image.Clone();
            }
            circunferencia v = new circunferencia();
            double x = 0;
            double dx = 0.3;
            do
            {
                v.x0 = x;
                v.RD = 0.4;
                v.y0 = -x * (x - 9) / 4;
                v.col0 = Color.Blue;
                v.EncenderC(ref bmp);
                pictureBox1.Refresh();
                Thread.Sleep(100);
                v.ApagarC(ref bmp);
                pictureBox1.Image = bmp;
                x = x + dx;
            } while (x <= 9);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(640, 480);

            if (pictureBox1.Image != null)
            {
                bmp = (Bitmap)pictureBox1.Image.Clone();
            }
            vector v = new vector();
            double x = -1;
            double dx = 0.001;
            do
            {
                v.x0 = Math.Sin(x) * Math.Cos(x); ;
                v.y0 = Math.Sin(x) * Math.Tan(x);
                v.col0 = Color.Blue;
                v.proceso_encender(ref bmp);
                pictureBox1.Image = bmp;

                x = x + dx;
            } while (x <= 3);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(640, 480);

            if (pictureBox1.Image != null)
            {
                bmp = (Bitmap)pictureBox1.Image.Clone();
            }
            vector v = new vector();
            circunferencia c = new circunferencia();

            float x = -9;
            float dx = 0.003f;
            c.RD = 0.3;

            do
            {

                v.x0 = (x);
                v.y0 = Math.Pow(0.5, x);
                v.col0 = Color.Green;
                v.proceso_encender(ref bmp);
                v.y0 = 1 + x * Math.Log(0.5) + (Math.Pow(x, 2) * Math.Pow(Math.Log(0.5), 2)) / 2 + (Math.Pow(x, 3) * Math.Pow(Math.Log(0.5), 3)) / 6 + (Math.Pow(x, 4) * Math.Pow(Math.Log(0.5), 4)) / 24 + (Math.Pow(x, 5) * Math.Pow(Math.Log(0.5), 5)) / 120;
                v.col0 = Color.Black;
                v.proceso_encender(ref bmp);
                pictureBox1.Image = bmp;
                x = x + dx;
            } while (x <= 9);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(640, 480);

            if (pictureBox1.Image != null)
            {
                bmp = (Bitmap)pictureBox1.Image.Clone();
            }
            circunferencia v = new circunferencia();
            double x = -10;
            double dx = 0.3;
            do
            {

                v.x0 = x;
                v.RD = 0.4;
                v.y0 = x + 2;
                v.col0 = Color.Blue;
                v.EncenderC(ref bmp);
                pictureBox1.Refresh();
                Thread.Sleep(100);
                v.ApagarC(ref bmp);
                pictureBox1.Image = bmp;
                x = x + dx;
            } while (x <= 10);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(640, 480);

            if (pictureBox1.Image != null)
            {
                bmp = (Bitmap)pictureBox1.Image.Clone();
            }
            circunferencia cir = new circunferencia();
            double x, dx;
            x = 0;
            dx = 0.3;
            do
            {

                cir.col0 = Color.Blue;
                cir.x0 = x - 10;
                cir.y0 = -x * (x - 5);
                cir.EncenderC(ref bmp);
                pictureBox1.Refresh();
                Thread.Sleep(100);
                cir.ApagarC(ref bmp);
                pictureBox1.Image = bmp;
                x = x + dx;
            } while (x <= 5);

            //x = 0;
            //dx = 0.3;
            //do
            //{

            //    cir.col0 = Color.Blue;
            //    cir.x0 = x - 5;
            //    cir.y0 = (-x * (x - 5)) / 1.5;
            //    cir.EncenderC(ref bmp);
            //    pictureBox1.Refresh();
            //    Thread.Sleep(100);
            //    cir.ApagarC(ref bmp);
            //    pictureBox1.Image = bmp;
            //    x = x + dx;
            //} while (x <= 5);

            //x = 0;
            //dx = 0.3;
            //do
            //{
            //    cir.col0 = Color.White;
            //    cir.x0 = x;
            //    cir.y0 = (-x * (x - 5)) / 2;
            //    cir.EncenderC(ref bmp);
            //    pictureBox1.Refresh();
            //    Thread.Sleep(100);
            //    cir.ApagarC(ref bmp);
            //    pictureBox1.Image = bmp;
            //    x = x + dx;
            //} while (x <= 5);

            //x = 0;
            //dx = 0.3;
            //do
            //{
            //    cir.col0 = Color.White;
            //    cir.x0 = x + 5;
            //    cir.y0 = (-x * (x - 5)) / 3;
            //    cir.EncenderC(ref bmp);
            //    pictureBox1.Refresh();
            //    Thread.Sleep(100);
            //    cir.ApagarC(ref bmp);
            //    pictureBox1.Image = bmp;
            //    x = x + dx;
            //} while (x <= 5);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(640, 480);

            if (pictureBox1.Image != null)
            {
                bmp = (Bitmap)pictureBox1.Image.Clone();
            }
            vector v = new vector();
            Color[] paleta1;
            paleta1 = new Color[16];

            paleta1[0] = Color.Black;
            paleta1[1] = Color.Navy;
            paleta1[2] = Color.Green;
            paleta1[3] = Color.Aqua;
            paleta1[4] = Color.Red;
            paleta1[5] = Color.Purple;
            paleta1[6] = Color.Maroon;
            paleta1[7] = Color.FromArgb(150, 150, 150);
            paleta1[8] = Color.FromArgb(90, 90, 90);
            paleta1[9] = Color.Blue;
            paleta1[10] = Color.Lime;
            paleta1[11] = Color.Silver;
            paleta1[12] = Color.Teal;
            paleta1[13] = Color.Fuchsia;
            paleta1[14] = Color.Yellow;
            paleta1[15] = Color.White;

            int colorT;
            double valor;
            Color c;

            for (int i = 0; i < 640; i++)
            {
                for (int j = 0; j < 480; j++)
                {
                    //valor = (Math.Pow(i,3) +Math.Sign(j) +Math.Cos(i))%15;
                    //colorT = (int)((Math.Sqrt(i + j)) % 15); color elegante 
                    colorT = (int)((Math.Sqrt(i*i*i + j*j*j)) % 15);
                    //colorT = (i + i + j * j) % 15;
                    c = paleta1[colorT];
                    bmp.SetPixel(i, j, c);
                    pictureBox1.Image = bmp;
                }
            }




        }

        private void button15_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(640, 480);

            if (pictureBox1.Image != null)
            {
                bmp = (Bitmap)pictureBox1.Image.Clone();
            }
            vector v = new vector();
            double x = 0;
            double dx = 0.0001;
            double xi=0, yi=4;
            double res;
            
            do
            {
                v.x0 = x;
                v.y0 = 5 * Math.Exp(0.5 * Math.Sin(Math.Pow(x, 2) + 2 * x)) - 1;
                v.col0 = Color.Blue;
                v.proceso_encender(ref bmp);
                double k1 = (yi-1)*(xi+1)*Math.Cos(Math.Pow(xi,2)+2*xi);
                /////////////////////////////////////////////////////////
                double xr = xi+(0.5*dx);
                double ys = yi+(0.5*dx*k1);               
                double k2 = (ys-1)*(xr+1)*Math.Cos(Math.Pow(xr,2)+2*xr);
                /////////////////////////////////////////////////////////
                double xt = xi+(0.5*dx);
                double yt = yi+(0.5*dx*k2);
                double k3 = (yt-1)*(xt+1)*Math.Cos(Math.Pow(xt,2)+2*xt);
                /////////////////////////////////////////////////////////
                double xl = xi+dx;
                double yl = yi+(dx*k3);
                double k4 = (yl-1)*(xl+1)*Math.Cos(Math.Pow(xl,2)+2*xl);
                res = yi + 0.1666666667 *dx* (k1 + (2 * k2) + (2 * k3) + k4) ;
                v.y0 = res;
                v.col0 = Color.Black;
                v.proceso_encender(ref bmp);
                pictureBox1.Image = bmp;
                x = x + dx;
                if (yi == 4)
                {
                    yi = 0;
                }
                yi = res;
                xi = xi + dx;
            } while (x <= 3);
            
            label1.Text = (5 * Math.Exp( 0.5 * Math.Sin(Math.Pow(x, 2) + 2 * x))-1).ToString();
            label2.Text = xi.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(640, 480);

            if (pictureBox1.Image != null)
            {
                bmp = (Bitmap)pictureBox1.Image.Clone();
            }
            vector v = new vector();
            Color[] paleta1;
            paleta1 = new Color[16];

            paleta1[0] = Color.Black;
            paleta1[1] = Color.Navy;
            paleta1[2] = Color.Green;
            paleta1[3] = Color.Aqua;
            paleta1[4] = Color.Red;
            paleta1[5] = Color.Purple;
            paleta1[6] = Color.Maroon;
            paleta1[7] = Color.FromArgb(150, 150, 150);
            paleta1[8] = Color.FromArgb(90, 90, 90);
            paleta1[9] = Color.Blue;
            paleta1[10] = Color.Lime;
            paleta1[11] = Color.Silver;
            paleta1[12] = Color.Teal;
            paleta1[13] = Color.Fuchsia;
            paleta1[14] = Color.Yellow;
            paleta1[15] = Color.White;

        Color[] paleta2 = new Color[16];


            int colorT;
            Color c;
            for (int i = 0; i < 15; i++)
            {
                int R = (int)2.333333333 * i + 218;
                int G = (int)2.8 * i + 130;
                int B = (int) (i/-15) + 1;
                paleta2[i] = Color.FromArgb(R, G, B);
            }

            for (int i = 0; i < 640; i++)
            {
                for (int j = 0; j < 480; j++)
                {
                    //valor = (Math.Pow(i,3) +Math.Sign(j) +Math.Cos(i))%15;
                    //colorT = (int)((Math.Sqrt(i + j)) % 15); color elegante 
                    colorT = (int)(((Math.Sqrt(i * j / 16)) + Math.Cos(i * j)) % 16);
                    //colorT = (i + i + j * j) % 15;
                    c = paleta2[colorT];
                    bmp.SetPixel(i, j, c);
                    pictureBox1.Image = bmp;
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }
        private void button18_Click(object sender, EventArgs e)
        {
            Bitmap a = new Bitmap(640, 480);

            if (pictureBox1.Image != null)
            {
                a = (Bitmap)pictureBox1.Image.Clone();
            }
            textura_agua(a);
            //if (Texturas.SelectedItem.ToString() == "Textura agua")
            //
            //    textura_agua(a, 1, 1, 0, 0);
            //}
            //        if (Texturas.SelectedItem.ToString() == "Textura cesped")
            //{
            //    textura_cesped(a, 1, 1, 0, 0);
            //}
            //        if (Texturas.SelectedItem.ToString() == "Textura piedra")
            //{
            //    textura_piedra(a, 1, 1, 0, 0);
            //}
        }

        private void textura_cesped(Bitmap a)
        {

            int c;
            Color s;
            double colorT ;
            vector v = new vector();

            for (int i = 0; i < 15; i++)
            {
                int R = (int)5.07 * i + 20;
                int G = (int)7.0663 * i + 118;
                int B = (int)-2.3997 * i + 41;
                paletaCesped[i] = Color.FromArgb(R, G, B);
            }
            for (int i = 0; i < 640; i++)
            {
                for (int j = 0; j < 480; j++)
                {
                    colorT = Math.Pow((i * j*Math.PI)*Math.Sqrt(j), 7);
                    colorT = Math.Abs(colorT % 15);
                    c = (int)(colorT);
                    s= paletaCesped[c];
                    a.SetPixel(i, j, s);
                    pictureBox1.Image = a;
                }
            }
        }


        private void textura_piedra(Bitmap a)
        {

            int c;
            double colorT ;
            Color s;
            vector v = new vector();
            for (int i = 0; i < 15; i++)
            {
                int R = (int)2.5336 * i + 86;
                int G = (int)2.333 * i + 96;
                int B = (int)2.667 * i + 107;
                paletaPiedra[i] = Color.FromArgb(R, G, B);
            }
            for (int i = 0; i < 640; i++)
            {
                for (int j = 0; j < 480; j++)
                {

                    colorT = (Math.Sqrt(345)*(i*j+100000000) *Math.PI* Math.Sin((j))) / 2;
                    colorT = Math.Abs(colorT % 15);
                    c = (int)(colorT);
                    s = (paletaPiedra[c]);
                    a.SetPixel(i, j, s);
                    pictureBox1.Image = a;
                }
            }
 
        }

        private void textura_agua(Bitmap a)
        {

            int c;
            double colorT;
            Color s;
            for (int i = 0; i < 15; i++)
            {
                int R = (int)11.133 * i + 88;
                int G = (int)5.407 * i + 173;
                int B = (int)2.733 * i + 214;
                paletaAgua[i] = Color.FromArgb(R, G, B);
            }
            vector v = new vector();
            for (int i = 0; i < 640; i++)
            {
                for (int j = 0; j < 480; j++)
                {
                    colorT = ((i * j + 1000000) * Math.Cos((i) / 5)) / 2;
                    colorT = Math.Abs(colorT % 15);
                    c = (int)(colorT);
                    s = (paletaAgua[c]);
                    a.SetPixel(i, j, s);
                    pictureBox1.Image = a;
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Bitmap a = new Bitmap(600, 460);

            if (pictureBox1.Image != null)
            {
                a = (Bitmap)pictureBox1.Image.Clone();
            }
            Color Colores = Color.Black;

            double t = 0;
            double dt = 0.005;
            Vector3D v3d = new Vector3D();
            v3d.col0 = Colores;

            v3d.x0 = 0;
            v3d.y0 = 0;
            v3d.z = 0;

            do
            {
                v3d.x0 = 1 + 5 * Math.Cos(t);
                v3d.y0 = 0 + 5 * Math.Sin(t); //mas adelante 0 es la posicion y 5 es para que acercar la vista 
                v3d.z = -2 + t / 4;
                v3d.encender_vector3D(ref a);
                t = t + dt;
            } while (t <= 25);



            pictureBox1.Image = a;
            
        }

        private void Texturas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Texturas_SelectedValueChanged(object sender, EventArgs e)
        {
              Bitmap a = new Bitmap(640, 480);

            if (pictureBox1.Image != null)
            {
                a = (Bitmap)pictureBox1.Image.Clone();
            }

            if (Texturas.SelectedItem.ToString() == "Textura agua")
            {
            
                textura_agua(a);
            }
            if (Texturas.SelectedItem.ToString() == "Textura cesped")
            {
                textura_cesped(a);
            }
            if (Texturas.SelectedItem.ToString() == "Textura piedra")
            {
                textura_piedra(a);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Bitmap a = new Bitmap(640, 480);

            if (pictureBox1.Image != null)
            {
                a = (Bitmap)pictureBox1.Image.Clone();
            }


            //segmento s = new segmento();

            //for (int i = 0; i < 640; i++)
            //{
            //    for (int j = 0; j < 480; j++)
            //    {
            //        s.X0 = -3;
            //        s.Y0 = -2;
            //        s.xf = 7;
            //        s.yf = 4;
            //        s.col0 = paletaAgua[i];

            //        s.encender(ref bmp);
            //    }
            //}
            //        pictureBox1.Image = bmp;




            for (int i = 0; i < 640; i++)
            {
                for (int j = 0; j < 480; j++)
                {
                    a.SetPixel(i, j, Color.FromArgb((int)(0.1645833333 * j), (int)(0.1645833333 * j), (int)(0.1645833333 * j)));
                    pictureBox1.Image = a;
                }
            }

        }

        private void circulos_Click(object sender, EventArgs e)
        {
            Bitmap bmp= new Bitmap(640, 480);

            if (pictureBox1.Image != null)
            {
                bmp = (Bitmap)pictureBox1.Image.Clone();
            }

            circunferencia c = new circunferencia();
            c.x0 = 3;
            c.y0 = 3;
            c.RD = 3;
            c.col0 = Color.Red;


            c.EncenderC(ref bmp);
            pictureBox1.Image = bmp;

            c.x0 = 3;
            c.y0 = 3;
            c.RD = 5;
            c.col0 = Color.Red;



            c.EncenderC(ref bmp);
            pictureBox1.Image = bmp;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Bitmap a = new Bitmap(600, 460);

            if (pictureBox1.Image != null)
            {
                a = (Bitmap)pictureBox1.Image.Clone();
            }


            Color[] Paleta = new Color[16];
            segmento s = new segmento();
            for (int i = 0; i <= 15; i++)
            {
                Paleta[i] = Color.FromArgb((int)(-11.666666667 * i + 252), (int)(9.733 * i + 53), (int)(4.8 * i + 5));
                s.X0 = -3;
                s.Y0 = -2;

                s.xf = 7;
                s.yf = 4;
                s.col0 = Paleta[i];
                s.encender(ref a);
            }


            
            pictureBox1.Image = a;

        }

        private void button22_Click(object sender, EventArgs e)
        {
           //Color[] color2 = new Color[16];

          Color[] color1 = new Color[16];

            Bitmap bmp = new Bitmap(640, 480);

            if (pictureBox1.Image != null)
            {
                 bmp = (Bitmap)pictureBox1.Image.Clone();
            }

            Color c;
            vector pan = new vector();
            int R, G, B;
            int colorT = 0, g = 0;
            double t = 0;
            double[] x1 = { 0, 15 };
            double[] y1 = { 247, 0 };
            double[] y2 = { 174, 64 };
            double[] y3 = { 28, 229 };

            for (int i = 0; i < 16; i++)
            {
                R = (int)pan.Lagrange(i, x1.Length, x1, y1);
                G = (int)pan.Lagrange(i, x1.Length, x1, y2);
                B = (int)pan.Lagrange(i, x1.Length, x1, y3);
                color1[i] = Color.FromArgb(R, G, B);
            }

            do
            {
                c = color1[colorT];
                g++;
                if (g < 16)
                    colorT++;
                else
                    colorT--;

                for (int i = 0; i < 15; i++)
                {
                    vector v = new vector();
                    t = t + 0.005;
                    v.x0 = -8 + 6 * t;
                    v.y0 = -2 + 3 * t;
                    v.col0 = c;
                    v.proceso_encender(ref bmp);
                    pictureBox1.Image = bmp;

                }
            } while (g < 31);
            //Color c;
            //Color c2;
            //vector pan = new vector();
            //int R, G, B;
            //double[] x1 = { 0, 15 };
            //int count = 0;


            //double[] y1 = { 255, 255 };
            //double[] y2 = { 0, 255 };
            //double[] y3 = { 0, 0 };

            //double[] y4 = { 255, 255 };
            //double[] y5 = { 255, 0 };
            //double[] y6 = { 0, 0 };

            //for (int i = 0; i < 16; i++)
            //{
            //    R = (int)pan.Lagrange(i, x1.Length, x1, y1);
            //    G = (int)pan.Lagrange(i, x1.Length, x1, y2);
            //    B = (int)pan.Lagrange(i, x1.Length, x1, y3);
            //    color1[i] = Color.FromArgb(R, G, B);
            //}
            //for (int i = 0; i < 16; i++)
            //{
            //    R = (int)pan.Lagrange(i, x1.Length, x1, y4);
            //    G = (int)pan.Lagrange(i, x1.Length, x1, y5);
            //    B = (int)pan.Lagrange(i, x1.Length, x1, y6);
            //    color2[i] = Color.FromArgb(R, G, B);
            //}
            //double t = 0 ,r = 0,z=0;
            //double x=0, y=0;

            //do
            //{
            //    c = color1[count];
            //    c2 = color2[count];
            //    count++;
            //    for (int i = 0; i < 30; i++)
            //    {
            //        if(i<15){
            //            vector v = new vector();
            //            t = t + 0.005;
            //            //r = t;
            //            v.x0 = x = (-8 + 6 * t);
            //            v.y0 = y = (-2 + 3 * t);
            //            v.col0 = c;
            //            v.proceso_encender(ref bmp);
            //            pictureBox1.Image = bmp;
            //            label2.Text = r.ToString();

            //        }
            //        else
            //        {

            //            vector v = new vector();
            //            r = r + 0.005;
            //            v.x0 = x + 6 * r;
            //            v.y0 = y + 3 * r;
            //            v.col0 = c2;
            //            v.proceso_encender(ref bmp);
            //            pictureBox1.Image = bmp;

            //        }
                    
            //    }

            //} while (count < 16);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(640, 480);

            if (pictureBox1.Image != null)
            {
                bmp = (Bitmap)pictureBox1.Image.Clone();
            }
            int R, G, B;
            Random md = new Random();

            for (int i = 0; i < 16; i++)
            {
                R = (int)md.Next(1, 255);
                G = (int)md.Next(1, 255);
                B = (int)md.Next(1, 255);
                paleta2[i] = Color.FromArgb(R, G, B);
            }


            circunferencia c = new circunferencia();
            c.x0 = 3;
            c.y0 = 3;
            c.RD = 3;
            c.col0 = Color.Red;


            c.EncenderC(ref bmp);
            pictureBox1.Image = bmp;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(640, 480);

            if (pictureBox1.Image != null)
            {
                bmp = (Bitmap)pictureBox1.Image.Clone();
            }
            int ColorT;
                double x,y,z,z1,z2;

            Color[] PaletaAgua = new Color[16];
            for (int i = 0; i <= 15; i++)
            {
                PaletaAgua[i] = Color.FromArgb((int)(10.2 * i), (int)(10.2 * i), (int)(3.0667 * i + 204));
            }

            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 460; j++)
                {
                    vector pant = new vector();
                    pant.Transforma(i, j, out x, out y);
                    z = 1.5 * (Math.Sqrt(x * x + y * y)) - 9.3 * 0;
                    z = Math.Sin(z) + 1;
                    ColorT = (int)(z * 7.5);
                    bmp.SetPixel(i, j, PaletaAgua[ColorT]);
                    pictureBox1.Image = bmp;
                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(640, 480);

            if (pictureBox1.Image != null)
            {
                bmp = (Bitmap)pictureBox1.Image.Clone();
            }
            
            Color[] paleta1;
            paleta1 = new Color[16];

            paleta1[0] = Color.Black;
            paleta1[1] = Color.Navy;
            paleta1[2] = Color.Green;
            paleta1[3] = Color.Aqua;
            paleta1[4] = Color.Red;
            paleta1[5] = Color.Purple;
            paleta1[6] = Color.Maroon;
            paleta1[7] = Color.FromArgb(150, 150, 150);
            paleta1[8] = Color.FromArgb(90, 90, 90);
            paleta1[9] = Color.Blue;
            paleta1[10] = Color.Lime;
            paleta1[11] = Color.Silver;
            paleta1[12] = Color.Teal;
            paleta1[13] = Color.Fuchsia;
            paleta1[14] = Color.Yellow;
            paleta1[15] = Color.White;

            int ColorT;
            double x, y, z=0, z1=0, z2=0, z3;

            for (int i = 0; i < 640; i++)
            {
                for (int j = 0; j < 480; j++)
                {
                   
                    //z1 = 1.5 * (Math.Sqrt((x +1) * (x +1) + (y - 0) * (y - 0))) - 9.3 * 0;
                    //z2 = 1.5 * (Math.Sqrt((x - 0) * (x - 0) + (y + 0) * (y + 0))) - 9.3 * 0;
                    //z3 = 1.5 * (Math.Sqrt((x - 1) * (x - 1) + (y + 0) * (y + 0))) - 9.3 * 0;
                    //for (int l = 0; l < 20; j++)
                    //{
                    //    z2 = 1.5 * Math.Sqrt(Math.Sqrt(x-10+l)+Math.Sqrt(y)-9.3*0);
                    //    z1 = 1 * Math.Sin(z2)+z1;

                    //}
                    for (int k = 0; k < 20; k++)
                    {
                        vector pant = new vector();
                        pant.Transforma(i, j, out x, out y);
                        z = Math.Sin(z) + 1;
                        z = (1.5 * (Math.Sqrt((x - 10 + k) * (x - 10 + k) + (y) * (y))) - 9.3 * 0);
                        z1 = Math.Sin(z) + 1;
                    }

                    //z1 = Math.Sin(z1) + 1;
                    //z2 = Math.Sin(z2) + 1;
                    //z3 = Math.Sin(z3) + 1;
                    //z = z1 + z2;
                    ColorT = (int)(21+z) *(15/ 42);
                    bmp.SetPixel(i, j, paleta1[ColorT]);
                    pictureBox1.Image = bmp;
                }
            }
        }

 
            //        int i, j;
            //for (i = 0; i < 600; i++)
            //{
            //    for (j = 0; j < 230; j++)
            //    {
            //        Pixel.SetPixel(i, j, Color.FromArgb((int)(-1.108 * j + 255), (int)(1.108 * j), 0));
            //        Plano.Image = Pixel;
            //    }
            //    for (j = 230; j < 460; j++)
            //    {
            //        Pixel.SetPixel(i, j, Color.FromArgb(0, (int)(-1.108 * j + 510), (int)(1.108 * j - 255)));
            //        Plano.Image = Pixel;
            //    }
            //}
       



        //public void PLagrange(int n, double x, out double px)
        //{
        //    double s = 0;
        //    double p = 1;
        //    for (int i = 0; i <= n; i++)
        //    {
        //        p = 1;
        //        for (int j = 0; j <= n; j++)
        //        {
        //            if (i != j)
        //                p = p * ((x - vx[j]) / (vx[i] - vx[j]));
        //        }
        //        s = s + vy[i] * p;
        //    }
        //    px = s;
        //}
    }


}
