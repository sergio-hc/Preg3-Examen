//Sergio Luis Huanca Cuellar
//INF 324
//DOCENTE: Lic. Moises Silva
//I/2022
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        int pR, pG, pB;
        int[] texturas = new int[9];
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Todos *.*|";
            openFileDialog1.ShowDialog();
            bmp = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Color c = new Color();
            c = bmp.GetPixel(15, 15);
            textBox1.Text = c.R.ToString();
            textBox2.Text = c.G.ToString();
            textBox3.Text = c.B.ToString();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Color c = new Color();
            //c = bmp.GetPixel(e.X, e.Y);
            //textBox1.Text = c.R.ToString();
            //textBox2.Text = c.G.ToString();
            //textBox3.Text = c.B.ToString();
            //pR = c.R;
            //pG = c.G;
            //pB = c.B;
            pR = 0;
            pG = 0;
            pB = 0;
            for (int ki = e.X; ki < e.X + 10; ki++)
                for (int kj = e.Y; kj < e.Y + 10; kj++)
                {
                    c = bmp.GetPixel(ki, kj);
                    pR = pR + c.R;
                    pG = pG + c.G;
                    pB = pB + c.B;
                }
            pR = pR / 100;
            pG = pG / 100;
            pB = pB / 100;
            textBox1.Text = c.R.ToString();
            textBox2.Text = c.G.ToString();
            textBox3.Text = c.B.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Color c = new Color();
            int mR = 0, mG = 0, mB = 0;
            for (int i = 15; i < 25; i++)
                for (int j = 15; j < 25; j++)
                {
                    c = bmp.GetPixel(i, j);
                    mR = mR + c.R;
                    mG = mG + c.G;
                    mB = mB + c.B;
                }
            mR = mR / 100;
            mG = mG / 100;
            mB = mB / 100;

            textBox1.Text = mR.ToString();
            textBox2.Text = mG.ToString();
            textBox3.Text = mB.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        { // cambio a textura fucsia 10 x 10
            Color c = new Color();
            Bitmap bmpR = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    if ((c.R-10<= pR && pR <=c.R+10) && (c.G - 10 <= pG && pG <= c.G + 10) && (c.B - 10 <= pB && pB <= c.B + 10))
                    {
                        bmpR.SetPixel(i, j, Color.Fuchsia);
                    }
                    else
                    {
                        bmpR.SetPixel(i, j, Color.FromArgb(c.R, c.G, c.B));
                    }
                }
            pictureBox2.Image = bmpR;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int mR = 0, mG = 0, mB = 0;
            Color c = new Color();
            Bitmap bmpR = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width-10; i = i + 10)
            {for (int j = 0; j < bmp.Height - 10; j = j + 10)
                {
                    mR = 0;
                    mG = 0;
                    mB = 0;
                    for (int ki = i; ki < i + 10; ki++)
                    {
                        for (int kj = j; kj < j + 10; kj++)
                        {
                            c = bmp.GetPixel(ki, kj);
                            mR = mR + c.R;
                            mG = mG + c.G;
                            mB = mB + c.B;
                        }
                        mR = mR / 100;
                        mG = mG / 100;
                        mB = mB / 100;
                    }

                    
                    c = bmp.GetPixel(i, j);
                    if ((c.R - 10 <= pR && pR <= c.R + 10) && (c.G - 10 <= pG && pG <= c.G + 10) && (c.B - 10 <= pB && pB <= c.B + 10))
                    {
                        bmpR.SetPixel(i, j, Color.Fuchsia);
                    }
                    else
                    {
                        bmpR.SetPixel(i, j, Color.FromArgb(c.R, c.G, c.B));
                    }
                }
                
            pictureBox2.Image = bmpR;
        }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // cambio a textura yellow 10 x 10
            Color c = new Color();
            Bitmap bmpR = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    if ((c.R - 10 <= pR && pR <= c.R + 10) && (c.G - 10 <= pG && pG <= c.G + 10) && (c.B - 10 <= pB && pB <= c.B + 10))
                    {
                        bmpR.SetPixel(i, j, Color.Yellow);
                    }
                    else
                    {
                        bmpR.SetPixel(i, j, Color.FromArgb(c.R, c.G, c.B));
                    }
                }
            pictureBox2.Image = bmpR;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            // cambio a textura 10 x 10
            Color c = new Color();
            Bitmap bmpR = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    if ((c.R - 10 <= pR && pR <= c.R + 10) && (c.G - 10 <= pG && pG <= c.G + 10) && (c.B - 10 <= pB && pB <= c.B + 10))
                    {
                        bmpR.SetPixel(i, j, Color.Beige);
                    }
                    else
                    {
                        bmpR.SetPixel(i, j, Color.FromArgb(c.R, c.G, c.B));
                    }
                }
            pictureBox2.Image = bmpR;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Color c = new Color();
            Bitmap bmpR = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i<bmp.Width; i++){
                for(int j=0; j< bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    bmpR.SetPixel(i, j, Color.FromArgb(c.R, 0, 0));
                }
                pictureBox2.Image = bmpR;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Color c = new Color();
            Bitmap bmpR = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    bmpR.SetPixel(i, j, Color.FromArgb(0, c.G, 0));
                }
                pictureBox2.Image = bmpR;
            }
        }
    }
}
