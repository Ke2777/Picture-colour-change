using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Работа_с_цветом
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color nColor, iColor;
        int x, y, w, h, wi, hi, r1,g1,b1,d1,p1;
        Bitmap bmp1, bmp2,bmp3;

        private void right_Click(object sender, EventArgs e)
        {
            bmp2.RotateFlip(RotateFlipType.Rotate90FlipNone);
            PicterMain.Image = bmp2;

        }

        private void left_Click(object sender, EventArgs e)
        {
            bmp2.RotateFlip(RotateFlipType.Rotate270FlipNone);
            PicterMain.Image = bmp2;
        }

        private void Rot_up_Click(object sender, EventArgs e)
        {
            bmp2.RotateFlip(RotateFlipType.RotateNoneFlipY);
            PicterMain.Image = bmp2;
        }

        private void Rot_left_Click(object sender, EventArgs e)
        {
            bmp2.RotateFlip(RotateFlipType.RotateNoneFlipX);
            PicterMain.Image = bmp2;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            PicterMain.Image = null;
            bmp2 = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Red.Value = 0;
            Red_text.Text = "0";
            Green.Value = 0;
            Green_text.Text = "0";
            Blue.Value = 0;
            Blue_text.Text = "0";
            Dopysk.Value = 0;
            Dopysk_text.Text = "0";
            Proz.Value = 0;
            Proz_text.Text = "0";

            ToolTip t = new ToolTip();
            t.SetToolTip(plus, "Увеличить изображение");
            t.SetToolTip(minus, "Уменьшить изображение");
            t.SetToolTip(ishod, "Исходное изображение");
            t.SetToolTip(right, "Поворот изображение вправо, по часовой");
            t.SetToolTip(left, "Поворот изображение влво, против часовой");
            t.SetToolTip(Rot_up, "Отзеркаливание по вертикали");
            t.SetToolTip(Rot_left, "Отзеркаливание по горизонтали");
            t.SetToolTip(clear, "Удалить изображение");
        }

        private void сохранитьКартинкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Title = "Сохранить картинку";
                sf.InitialDirectory = @"D:\donlowd";
                sf.Filter = "JPG|*.jpg|PNG|*.png";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    PicterMain.Image.Save(sf.FileName);
                }
            }
  
        }

        private void чернобелыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PicterMain.Image = bmp2;
            PicterMain.Refresh();
            Color colOld, colNew ;
            byte r, g, b;
             int gray ;
            for (int i = 0; i < bmp2.Width; i++)
            {
                for (int j = 0; j < bmp2.Height; j++)
                {
                    colOld = bmp3.GetPixel(i, j);
                    r = colOld.R;
                    g = colOld.G;
                    b = colOld.B;
                    gray = (r + g + b) / 3;
                    colNew = Color.FromArgb(255, gray, gray, gray);
                    bmp3.SetPixel(i,j,colNew);
                    
                }
                
            }
            
            PicterMain.Refresh();
           
        }

        private void негативToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PicterMain.Image = bmp2;
            PicterMain.Refresh();
            Color colOld, colNew ;
            int r, g, b;      
            for (int i = 0; i < bmp2.Width; i++)
            {
                for (int j = 0; j < bmp2.Height; j++)
                {
                    colOld = bmp3.GetPixel(i, j);
                    r = colOld.R;
                    g = colOld.G;
                    b = colOld.B;
                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;
                    colNew = Color.FromArgb(255, r, g, b);
                    bmp3.SetPixel(i,j,colNew);
                    nColor = colNew;
                }
                
            }
    
            PicterMain.Refresh();
            
        }

        private void сепияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PicterMain.Image = bmp2;
            PicterMain.Refresh();
            Color colOld, colNew;
            int r, g, b;
            double tr, tg, tb;
            for (int i = 0; i < bmp2.Width; i++)
            {
                for (int j = 0; j < bmp2.Height; j++)
                {
                    colOld = bmp3.GetPixel(i, j);
                    tr = 0.393 * colOld.R + 0.769 * colOld.G + 0.189 * colOld.B;
                    if (tr > 255) r = 255;
                    else r = (int)tr;
                    tg = 0.349 * colOld.R + 0.686 * colOld.G + 0.168 * colOld.B;
                    if (tg > 255) g = 255;
                    else g = (int)tg;
                    tb = 0.272 * colOld.R + 0.534 * colOld.G + 0.131 * colOld.B;
                    if (tb > 255) b = 255;
                    else b = (int)tb;
                    colNew = Color.FromArgb(255, r, g, b);
                    bmp3.SetPixel(i, j, colNew);
                    nColor = colNew;
                }

            }
            PicterMain.Refresh();
           
        }

        private void осветлитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PicterMain.Image = bmp2;
            PicterMain.Refresh();
            Color colOld, colNew;
            int r, g, b, c = 100;

            for (int i = 0; i < bmp2.Width; i++)
            {
                for (int j = 0; j < bmp2.Height; j++)
                {
                    colOld = bmp3.GetPixel(i, j);
                    r = colOld.R + c;
                    if(r > 255) r = 255;
                    g = colOld.G + c;
                    if (g > 255) g = 255;
                    b = colOld.B + c;
                    if (b > 255) b = 255;
                    colNew = Color.FromArgb(255, r, g, b);
                    bmp3.SetPixel(i, j, colNew);
                    nColor = colNew;
                }

            }
            PicterMain.Refresh();
            
        }


        private void затемнитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PicterMain.Image = bmp2;
            PicterMain.Refresh();
            Color colOld, colNew;
            int r, g, b, c = 100;

            for (int i = 0; i < bmp2.Width; i++)
            {
                for (int j = 0; j < bmp2.Height; j++)
                {
                    colOld = bmp3.GetPixel(i, j);
                    r = colOld.R - c;
                    if (r < 0 ) r = 0;
                    g = colOld.G - c;
                    if (g < 0) g = 0;
                    b = colOld.B - c;
                    if (b < 0) b = 0;
                    colNew = Color.FromArgb(255, r, g, b);
                    bmp3.SetPixel(i, j, colNew);
                    nColor = colNew;
                }

            }
            PicterMain.Refresh();
            
        }

        private void perekrasit_Click(object sender, EventArgs e)
        {
            Color color2 = isxod_pic.BackColor;

            for (int i = 0; i < PicterMain.Image.Height - 1; i++)
            {
                for (int j = 0; j < PicterMain.Image.Width - 1; j++)
                {


                    Color color = bmp2.GetPixel(j, i);

                        if (color.R - Dopysk.Value / 2 <= isxod_pic.BackColor.R
                                 && color.R + Dopysk.Value / 2 >= isxod_pic.BackColor.R
                                 && color.G - Dopysk.Value / 2 <= isxod_pic.BackColor.G
                                 && color.G + Dopysk.Value / 2 >= isxod_pic.BackColor.G
                                 && color.B - Dopysk.Value / 2 <= isxod_pic.BackColor.B
                                 && color.B + Dopysk.Value / 2 >= isxod_pic.BackColor.B
                                 && color.A - Dopysk.Value / 2 <= isxod_pic.BackColor.A
                                 && color.A + Dopysk.Value / 2 >= isxod_pic.BackColor.A)
                            {
                              
                               
                                int colorB = color.B - color2.B;
                                int colorG = color.G - color2.G;
                                int colorR = color.R - color2.R;
                                int colorA = color.A - color2.A;
                                if (zhel_pic.BackColor.R + colorR < 0)
                                    colorR = zhel_pic.BackColor.R;
                                if (zhel_pic.BackColor.G + colorG < 0)
                                    colorG = zhel_pic.BackColor.G;
                                if (zhel_pic.BackColor.B + colorB < 0)
                                    colorB = zhel_pic.BackColor.B;
                                if (zhel_pic.BackColor.A + colorA < 0)
                                    colorA = zhel_pic.BackColor.A;
                                if (zhel_pic.BackColor.R + colorR > 255)
                                    colorR = 255 - zhel_pic.BackColor.R;
                                if (zhel_pic.BackColor.G + colorG > 255)
                                    colorG = 255 - zhel_pic.BackColor.G;
                                if (zhel_pic.BackColor.B + colorB > 255)
                                    colorB = 255 - zhel_pic.BackColor.B;
                                if (zhel_pic.BackColor.A + colorA > 255)
                                    colorA = 255 - zhel_pic.BackColor.A;
                                

                                color2 = Color.FromArgb(zhel_pic.BackColor.A + colorA, zhel_pic.BackColor.R + colorR,
                                                                                 zhel_pic.BackColor.G + colorG,
                                                                                 zhel_pic.BackColor.B + colorB);
                               
                               bmp2.SetPixel(j, i, color2);
                           }

                }
                PicterMain.Refresh();

            }   
        }

        private void Red_Scroll(object sender, EventArgs e)
        {
            Red_text.Text = Red.Value.ToString();
            r1 = Red.Value;
            nColor = Color.FromArgb(p1, r1, g1, b1);
            zhel_pic.BackColor = nColor;
        }

        private void Green_Scroll(object sender, EventArgs e)
        {
            Green_text.Text = Green.Value.ToString();
            g1 = Green.Value;
            nColor = Color.FromArgb(p1, r1, g1, b1);
            zhel_pic.BackColor = nColor;
        }

        private void Blue_Scroll(object sender, EventArgs e)
        {
            Blue_text.Text = Blue.Value.ToString();
            b1 = Blue.Value;
            nColor = Color.FromArgb(p1, r1, g1, b1);
            zhel_pic.BackColor = nColor;
        }

        private void Dopysk_Scroll(object sender, EventArgs e)
        {
            Dopysk_text.Text = Dopysk.Value.ToString();
            d1 = Dopysk.Value;   
        }

        private void Proz_Scroll(object sender, EventArgs e)
        {
            Proz_text.Text = Proz.Value.ToString();
            p1 = Proz.Value;
            nColor = Color.FromArgb(p1, r1, g1, b1);
            zhel_pic.BackColor = nColor;
        }

        private void ishod_Click(object sender, EventArgs e)
        {
            bmp2 = new Bitmap(bmp2, wi, hi);
            w = bmp2.Width;
            h = bmp2.Height;
            PicterMain.Image = bmp1;
        }

        private void zuumout_Click(object sender, EventArgs e)
        {
           
                if (bmp2.Height > hi && bmp2.Width > wi)
                {
                    bmp2 = new Bitmap(bmp2, w - 10, h - 10);
                    w = bmp2.Width;
                    h = bmp2.Height;
                    PicterMain.Image = bmp2;
                }
            
        }

        private void загрузитьКартинкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Выберете картинку";
            openFileDialog1.InitialDirectory = @"D:\donlowd";
            openFileDialog1.Filter = "JPG|*.jpg|PNG|*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {                
                bmp1 = new Bitmap(openFileDialog1.FileName);
                bmp1 = new Bitmap(bmp1, PicterMain.Width, PicterMain.Height);
                w = bmp1.Width;
                h = bmp1.Height;
                wi = w;
                hi = h;
                PicterMain.Image = bmp1;
                bmp2 = bmp1;
                bmp3 = bmp2;
                
            }
        }

        private void Palitra_Click(object sender, EventArgs e)
        {  
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                nColor = colorDialog1.Color;
                zhel_pic.BackColor = nColor;
                r1 = nColor.R;
                Red_text.Text = r1.ToString();
                g1 = nColor.G;
                Green_text.Text = g1.ToString();
                b1 = nColor.B;
                Blue_text.Text = b1.ToString();
                p1 = nColor.A;
                Proz_text.Text = p1.ToString();
            }         
        }

        private void zoomup_Click(object sender, EventArgs e)
        {
            {    
                bmp2 = new Bitmap(bmp2, w + 10, h + 10);
                w = bmp2.Width;
                h = bmp2.Height;
                PicterMain.Image = bmp2;
            }
        }

        private void PicterMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
                isxod_pic.BackColor = bmp2.GetPixel(x, y);
                isxod_text.Text = bmp2.GetPixel(x, y).ToString();
                zhel_pic.BackColor = bmp2.GetPixel(x, y);
                zhel_text.Text = bmp2.GetPixel(x, y).ToString();
                nColor = bmp2.GetPixel(x, y);
                Red.Value = bmp2.GetPixel(x, y).R;
                Red_text.Text = bmp2.GetPixel(x, y).R.ToString();
                Green.Value = bmp2.GetPixel(x, y).G;
                Green_text.Text = bmp2.GetPixel(x, y).G.ToString();
                Blue.Value = bmp2.GetPixel(x, y).B;
                Blue_text.Text = bmp2.GetPixel(x, y).B.ToString();
                Proz.Value = bmp2.GetPixel(x, y).A;
                Proz_text.Text = bmp2.GetPixel(x, y).A.ToString();
                iColor = isxod_pic.BackColor;
                r1 = Red.Value;
                g1 = Green.Value;
                b1 = Blue.Value;
                d1 = Dopysk.Value;
                p1 = Proz.Value;
            }
        }
    }
}
