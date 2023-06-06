using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTableroAjedrez
{
    public partial class Form1 : Form
    {
        Graphics gra;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gra = pictureBox1.CreateGraphics();
        }

        private void cmdCrear_Click(object sender, EventArgs e)
        {
            int tamañoCuadro = 80;
            int numFila = 640 / tamañoCuadro;
            int numColumna = 640 / tamañoCuadro;

            for (int fila = 0; fila < numFila; fila++)
            {
                for (int columna = 0; columna < numColumna; columna++)
                {
                    if ((fila + columna) % 2 == 0)
                    {
                        gra.FillRectangle(Brushes.Blue, columna * tamañoCuadro, fila * tamañoCuadro, tamañoCuadro, tamañoCuadro);
                    }
                    else
                    {
                        gra.FillRectangle(Brushes.Black, columna * tamañoCuadro, fila * tamañoCuadro, tamañoCuadro, tamañoCuadro);
                    }
                }
            }




























            //int i = 0;

            //while (i <= pictureBox1.Width && i <= pictureBox1.Height)
            //{
            //    gra.FillRectangle(Brushes.Blue, i, 0, 80, 80);
            //    i = i + 80;
            //    gra.FillRectangle(Brushes.Black, i, 0, 80, 80);
            //    i = i + 80;
            //}
            //i = 0;

            //while (i <= pictureBox1.Width && i <= pictureBox1.Height)
            //{
            //    gra.FillRectangle(Brushes.Blue, 0, i, 80, 80);
            //    i = i + 80;
            //    gra.FillRectangle(Brushes.Black, 0, i, 80, 80);
            //    i = i + 80;
            //}

            //int r = 80;
            //i = 80;

            //while (i <= 560 && r <= 560)
            //{
            //        while (i <= pictureBox1.Width && i <= pictureBox1.Height && r <= pictureBox1.Width && r <= pictureBox1.Height)
            //        {

            //            gra.FillRectangle(Brushes.Blue, r, i, 80, 80);
            //            i = i + 80;
            //            //r = r + 80;

            //            gra.FillRectangle(Brushes.Black, r, i, 80, 80);
            //            i = i + 80;

            //            gra.FillRectangle(Brushes.Blue, r, i, 80, 80);

            //            r = r + 80;

            //            gra.FillRectangle(Brushes.Black, r, i, 80, 80);
            //            r = r + 80;
            //        }
                
            //    i = i + 80;
            //    r = r + 80;

            //}

            //while (r <= 560)
            //{
            //    while (i <= pictureBox1.Width && i <= pictureBox1.Height && r <= pictureBox1.Width && r <= pictureBox1.Height)
            //    {

            //        gra.FillRectangle(Brushes.Blue, r, i, 80, 80);

            //        r = r + 80;

            //        gra.FillRectangle(Brushes.Black, r, i, 80, 80);
            //        r = r + 80;
            //    }

            //    r = r + 80;
            //}




















            //ULTIMO INTENTO MAS O MENOSE DESCENTE


            //int f = 80;
            //int c;

            //while (f <= 560)
            //{
            //    c = 80;
            //    while (c <= 560)
            //    {
            //        while (f <= pictureBox1.Width && f <= pictureBox1.Height && c <= pictureBox1.Width && c <= pictureBox1.Height)
            //        {
            //            gra.FillRectangle(Brushes.Blue, c, f, 80, 80);
            //            c = c + 80;
            //            gra.FillRectangle(Brushes.Black, c, f, 80, 80);
            //            c = c + 80;

            //        }

            //        c = c + 80;
            //    }
            //    while (f <= pictureBox1.Width && f <= pictureBox1.Height && c <= pictureBox1.Width && c <= pictureBox1.Height)
            //    {
            //        gra.FillRectangle(Brushes.Blue, c, f, 80, 80);
            //        f = f + 80;
            //        gra.FillRectangle(Brushes.Black, c, f, 80, 80);
            //        f = f + 80;
            //    }
            //    f = f + 80;
            //}



            //while (f <= pictureBox1.Width && f <= pictureBox1.Height && c <= pictureBox1.Width && c <= pictureBox1.Height)
            //{

            //    gra.FillRectangle(Brushes.Blue, c, f, 80, 80);

            //    c = c + 80;

            //    gra.FillRectangle(Brushes.Black, c, f, 80, 80);
            //    c = c + 80;
            //}

        }






        ////PROBANDO PELOTUDECES
        //r = 160;
        //i = 160;
        //while (i <= pictureBox1.Width && i <= pictureBox1.Height && r <= pictureBox1.Width && r <= pictureBox1.Height)
        //{

        //    gra.FillRectangle(Brushes.Blue, r, i, 80, 80);
        //    i = i + 80;
        //    //r = r + 80;

        //    gra.FillRectangle(Brushes.Black, r, i, 80, 80);
        //    i = i + 80;


        //}

        //r = 160;
        //i = 160;
        //while (i <= pictureBox1.Width && i <= pictureBox1.Height && r <= pictureBox1.Width && r <= pictureBox1.Height)
        //{

        //    gra.FillRectangle(Brushes.Blue, r, i, 80, 80);

        //    r = r + 80;

        //    gra.FillRectangle(Brushes.Black, r, i, 80, 80);
        //    r = r + 80;


        //}

        //r = 240;
        //i = 240;
        //while (i <= pictureBox1.Width && i <= pictureBox1.Height && r <= pictureBox1.Width && r <= pictureBox1.Height)
        //{

        //    gra.FillRectangle(Brushes.Blue, r, i, 80, 80);
        //    i = i + 80;
        //    //r = r + 80;

        //    gra.FillRectangle(Brushes.Black, r, i, 80, 80);
        //    i = i + 80;


        //}

        //r = 240;
        //i = 240;
        //while (i <= pictureBox1.Width && i <= pictureBox1.Height && r <= pictureBox1.Width && r <= pictureBox1.Height)
        //{

        //    gra.FillRectangle(Brushes.Blue, r, i, 80, 80);

        //    r = r + 80;

        //    gra.FillRectangle(Brushes.Black, r, i, 80, 80);
        //    r = r + 80;


        //}

        //r = 320;
        //i = 320;
        //while (i <= pictureBox1.Width && i <= pictureBox1.Height && r <= pictureBox1.Width && r <= pictureBox1.Height)
        //{

        //    gra.FillRectangle(Brushes.Blue, r, i, 80, 80);
        //    i = i + 80;
        //    //r = r + 80;

        //    gra.FillRectangle(Brushes.Black, r, i, 80, 80);
        //    i = i + 80;


        //}

        //r = 320;
        //i = 320;
        //while (i <= pictureBox1.Width && i <= pictureBox1.Height && r <= pictureBox1.Width && r <= pictureBox1.Height)
        //{

        //    gra.FillRectangle(Brushes.Blue, r, i, 80, 80);

        //    r = r + 80;

        //    gra.FillRectangle(Brushes.Black, r, i, 80, 80);
        //    r = r + 80;


        //}

        //r = 400;
        //i = 400;
        //while (i <= pictureBox1.Width && i <= pictureBox1.Height && r <= pictureBox1.Width && r <= pictureBox1.Height)
        //{

        //    gra.FillRectangle(Brushes.Blue, r, i, 80, 80);
        //    i = i + 80;
        //    //r = r + 80;

        //    gra.FillRectangle(Brushes.Black, r, i, 80, 80);
        //    i = i + 80;


        //}

        //r = 400;
        //i = 400;
        //while (i <= pictureBox1.Width && i <= pictureBox1.Height && r <= pictureBox1.Width && r <= pictureBox1.Height)
        //{

        //    gra.FillRectangle(Brushes.Blue, r, i, 80, 80);

        //    r = r + 80;

        //    gra.FillRectangle(Brushes.Black, r, i, 80, 80);
        //    r = r + 80;


        //}

        //r = 480;
        //i = 480;
        //while (i <= pictureBox1.Width && i <= pictureBox1.Height && r <= pictureBox1.Width && r <= pictureBox1.Height)
        //{

        //    gra.FillRectangle(Brushes.Blue, r, i, 80, 80);
        //    i = i + 80;
        //    //r = r + 80;

        //    gra.FillRectangle(Brushes.Black, r, i, 80, 80);
        //    i = i + 80;


        //}

        //r = 480;
        //i = 480;
        //while (i <= pictureBox1.Width && i <= pictureBox1.Height && r <= pictureBox1.Width && r <= pictureBox1.Height)
        //{

        //    gra.FillRectangle(Brushes.Blue, r, i, 80, 80);

        //    r = r + 80;

        //    gra.FillRectangle(Brushes.Black, r, i, 80, 80);
        //    r = r + 80;


        //}

        //r = 560;
        //i = 560;
        //while (i <= pictureBox1.Width && i <= pictureBox1.Height && r <= pictureBox1.Width && r <= pictureBox1.Height)
        //{

        //    gra.FillRectangle(Brushes.Blue, r, i, 80, 80);
        //    i = i + 80;
        //    //r = r + 80;

        //    gra.FillRectangle(Brushes.Black, r, i, 80, 80);
        //    i = i + 80;


        //}

        //r = 560;
        //i = 560;
        //while (i <= pictureBox1.Width && i <= pictureBox1.Height && r <= pictureBox1.Width && r <= pictureBox1.Height)
        //{

        //    gra.FillRectangle(Brushes.Blue, r, i, 80, 80);

        //    r = r + 80;

        //    gra.FillRectangle(Brushes.Black, r, i, 80, 80);
        //    r = r + 80;


        //}














    }
}
