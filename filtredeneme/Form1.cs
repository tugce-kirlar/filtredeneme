using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filtredeneme
{
    public partial class Form1 : Form
    {
        Bitmap resim;
        public Form1()
        {
            InitializeComponent();
            resim = new Bitmap(pictureBox1.Image);
        }

        private void btnGri_Click(object sender, EventArgs e)
        {
            //Red,Green,Blue -> (R+G+B)/3
            Bitmap yeniResim = new Bitmap(resim.Width, resim.Height);

            for (int x = 0; x < resim.Width; x++)
            {
                for (int y = 0; y < resim.Height; y++)
                {
                    Color eskiRenk = resim.GetPixel(x, y);
                    int R = eskiRenk.R;
                    int G = eskiRenk.G;
                    int B = eskiRenk.B;
                    int sonuc = (R + G + B) / 3;
                    Color yeniRenk = Color.FromArgb(sonuc, sonuc, sonuc);
                    yeniResim.SetPixel(x, y, yeniRenk);
                }


            }

            pictureBox1.Image = yeniResim;
        }

        private void btnsiyahbeyaz_Click(object sender, EventArgs e)
        {
            //Red,Green,Blue -> (R+G+B)/3
            Bitmap yeniResim = new Bitmap(resim.Width, resim.Height);

            for (int x = 0; x < resim.Width; x++)
            {
                for (int y = 0; y < resim.Height; y++)
                {
                    Color eskiRenk = resim.GetPixel(x, y);
                    int R = eskiRenk.R;
                    int G = eskiRenk.G;
                    int B = eskiRenk.B;
                    Color yeniRenk = Color.Black;
                    int toplam = (R + G + B);
                    if(toplam>200)
                    {
                        yeniRenk = Color.White;
                    }
                    


                    //  Color yeniRenk = Color.FromArgb(, ,);
                      yeniResim.SetPixel(x, y, yeniRenk);
                }


            }
            pictureBox1.Image = yeniResim;
        }
    }
}

