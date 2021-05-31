using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        int cR, cG, cB;
        int cRx, cGx, cBx;
        int n = 0;
        int x = 0;
        int y = 0;   
        Color[] colores;
        int[] numeroColrs;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Bitmap bmp = new Bitmap(openFileDialog1.FileName);
            picImagen.Image = bmp;
        }

        private void btnReconocer_Click(object sender, EventArgs e)
        {
            Escaner(0, 130, 0, 94, PaletaT);
            Escaner(138, 250, 223, 340, PaletaL);
            Escaner(436, 544, 122, 280, PaletaV);

        }

        private void Order(int indice)
        {
            for (int i = 0; i < indice; i++)
            {
                for (int j = 0; j < indice - i - 1; j++)
                {
                    if (numeroColrs[j] < numeroColrs[j + 1])
                    {
                        int aux = numeroColrs[j + 1];
                        numeroColrs[j + 1] = numeroColrs[j];
                        numeroColrs[j] = aux;

                        Color aux2 = colores[j + 1];
                        colores[j + 1] = colores[j];
                        colores[j] = aux2;
                    }
                }
            }
        }

        private void Escaner(int xi, int xf, int yi, int yf, PictureBox P)
        {
            Bitmap bmp = new Bitmap(picImagen.Image);
            Bitmap bmpPaleta = new Bitmap(250, 50);
            Color c = new Color();
            x = bmp.Width;
            y = bmp.Height;
            colores = new Color[x * y];
            numeroColrs = new int[x * y];
            for (int i = xi; i < xf; i = i + 2)
                for (int j = yi; j < yf; j = j + 2)
                {
                    c = bmp.GetPixel(i, j);
                    int e = Existe(c, n);
                    if (e == -1)
                    {
                        colores[n] = c;
                        numeroColrs[n] = 1;
                        n++;
                    }
                    else
                    {
                        numeroColrs[e]++;
                    }
                }
            Order(n);

            int cc = 0;
            for (int k = 0; k < bmpPaleta.Width; k += 50)
            {
                for (int i = k; i < bmpPaleta.Width; i++)
                {
                    for (int j = 0; j < bmpPaleta.Height; j++)
                    {
                        bmpPaleta.SetPixel(i, j, colores[cc]);
                    }
                }
                cc++;
            }

            P.Image = bmpPaleta;
        }

        private int Existe(Color c, int indice)
        {
            int sw = -1;
            for (int i = 0; i < indice + 1; i++)
            {
                if (colores[i].Equals(c))
                {
                    sw = i;
                    break;
                }
            }
            return sw;

        }

        private void picImagen_MouseClick_1(object sender, MouseEventArgs e)
        {
            Bitmap bmp = new Bitmap(picImagen.Image);
            Color c = new Color();
            c = bmp.GetPixel(e.X, e.Y);
            cRx = 0;
            cGx = 0;
            cBx = 0;
            picColor.BackColor = c;
            for (int i = e.X; (i < e.X + 10) && (i < bmp.Width); i++)
                for (int j = e.Y; (j < e.Y + 10) && (j < bmp.Height); j++)
                {                    
                    c = bmp.GetPixel(i, j);                    
                }
            
            txtR.Text = c.R.ToString() ;
            txtG.Text = c.G.ToString() ;
            txtB.Text = c.B.ToString() ;
            textBox1.Text = e.X.ToString();
            textBox2.Text = e.Y.ToString();
        }


        private void picPaletaT_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap img = new Bitmap(picImagen.Image);
            Bitmap bmp = new Bitmap(PaletaT.Image);
            Bitmap bmp2 = new Bitmap(img.Width, img.Height);
            Color c = new Color();
            c = bmp.GetPixel(e.X, e.Y);
            cR = c.R;
            cG = c.G;
            cB = c.B;
            int p = 0;
            for (int i = 0; i < img.Width; i++)
                for (int j = 0; j < img.Height; j++)
                {
                    Color cx = img.GetPixel(i, j);
                    cRx = cx.R;
                    cGx = cx.G;
                    cBx = cx.B;
                    if (((cR - 15 <= cRx) && (cRx <= cR + 15)) && ((cG - 15 <= cGx) && 
                        (cGx <= cG + 15)) && ((cB - 15 <= cBx) && (cBx <= cB + 15)))
                    {
                        bmp2.SetPixel(i, j, cx);
                    }
                }
            picModificado.Image = bmp2;
        }

        private void picPaletaL_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap img = new Bitmap(picImagen.Image);
            Bitmap bmp = new Bitmap(PaletaL.Image);
            Bitmap bmp2 = new Bitmap(img.Width, img.Height);
            Color c = new Color();
            c = bmp.GetPixel(e.X, e.Y);
            cR = c.R;
            cG = c.G;
            cB = c.B;
            int p = 0;
            for (int i = 0; i < img.Width; i++)
                for (int j = 0; j < img.Height; j++)
                {
                    Color cx = img.GetPixel(i, j);
                    cRx = cx.R;
                    cGx = cx.G;
                    cBx = cx.B;
                    if (((cR - 15 <= cRx) && (cRx <= cR + 15)) && ((cG - 15 <= cGx) && 
                        (cGx <= cG + 15)) && ((cB - 15 <= cBx) && (cBx <= cB + 15)))
                    {
                        bmp2.SetPixel(i, j, cx);
                    }
                }
            picModificado.Image = bmp2;
        }

        private void txtR_TextChanged(object sender, EventArgs e)
        {

        }

        private void picPaletaL_Click(object sender, EventArgs e)
        {

        }

        private void picPaletaV_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap img = new Bitmap(picImagen.Image);
            Bitmap bmp = new Bitmap(PaletaV.Image);
            Bitmap bmp2 = new Bitmap(img.Width, img.Height);
            Color c = new Color();
            c = bmp.GetPixel(e.X, e.Y);
            cR = c.R;
            cG = c.G;
            cB = c.B;
            int p = 0;
            for (int i = 0; i < img.Width; i++)
                for (int j = 0; j < img.Height; j++)
                {
                    Color cx = img.GetPixel(i, j);
                    cRx = cx.R;
                    cGx = cx.G;
                    cBx = cx.B;
                    if (((cR - 15 <= cRx) && (cRx <= cR + 15)) && ((cG - 15 <= cGx) && 
                        (cGx <= cG + 15)) && ((cB - 15 <= cBx) && (cBx <= cB + 15)))
                    {
                        bmp2.SetPixel(i, j, cx);
                    }
                }
            picModificado.Image = bmp2;
        }


        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

     
        private void picModificado_Click(object sender, EventArgs e)
        {

        }

    }
}
