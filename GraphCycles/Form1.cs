using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphCycles
{
    public partial class Form1 : Form
    {

        Graphics g;//класс графикс с именем г
        Pen pen;//карандаш с именем пен


        public Form1()
        {
            InitializeComponent();
            InitGraf();//запуск метода инитграф
        }

        public void InitGraf()//метод инициализации графики с именем инитграф
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);//создание нового битмапа с размером точно в пикчербокс
            pictureBox1.Image = bmp;//записать битмап в пикчербокс
            pictureBox1.Image = bmp;//записать битмап в пикчербокс
            pictureBox1.Image = bmp;//записать битмап в пикчербокс
            g = Graphics.FromImage(pictureBox1.Image);//создание графики статическим методом Graphics
            pen = new Pen(Color.DarkRed);//создание красного карандаша
            //g.DrawLine(pen, 0,0,300,300);//нарисовали линию
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            //g.Clear(Color.White);//закрасить джи белым цветом
            g.Clear(pictureBox1.BackColor);
            RefreshPicture();
        }

        public void RefreshPicture()
        {
            pictureBox1.Refresh();
        }

        public void Sleep1()
        {
            RefreshPicture();
            Thread.Sleep(100);//задержка 100 миллисекунд
        }

        public void Sleep2()
        {
            RefreshPicture();
            Thread.Sleep(20);//задержка 20 миллисекунд
        }

        public void Sleep3()
        {
            RefreshPicture();
            Thread.Sleep(4);//задержка 4 миллисекунды
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.DrawLine(pen, 0, 0, 300, 300);//нарисовали линию
            g.DrawLine(pen, 300, 0, 0, 300);
            RefreshPicture();//обновили, чтобы увидеть нарисованное
        }

        private void button2_Click(object sender, EventArgs e)//горизонтальные линии
        {
            for (int y = 0; y <= 300; y += 30)//не запятые, а точки с запятой!!!
            {
                g.DrawLine(pen, 0, y, 300, y);
                Sleep1();
            }

            //g.DrawLine(pen, 0, 30, 300, 30);
            RefreshPicture();
        }

        private void button3_Click(object sender, EventArgs e)//вертикальные линии
        {
            for (int x = 0; x <= 300; x += 30)
            {
                g.DrawLine(pen, x, 0, x, 300);
                Sleep1();
            }

            //g.DrawLine(pen, 0, 0, 0, 300);//вертикальная линия с левого края пикчербокса
            //g.DrawLine(pen, 30, 0, 30, 300);//вторая вертикальная
            //g.DrawLine(pen, 60, 0, 60, 300);//третья вертикальная
            RefreshPicture();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*for (int y = 0; y <= 300; y += 30)//не запятые, а точки с запятой!!!
            /*for (int y = 0; y <= 300; y += 30)//не запятые, а точки с запятой!!!
            {
                g.DrawLine(pen, 0, y, 300, y);
                Sleep1();
            }
                
            for (int x = 0; x <= 300; x += 30)
            {
                g.DrawLine(pen, x, 0, x, 300);
                Sleep1();
            }*/
            for (int y = 0; y <= 300; y += 30)//не запятые, а точки с запятой!!!
            {
                g.DrawLine(pen, 0, y, 300, y);
                Sleep1();
                int x = y;
                g.DrawLine(pen, x, 0, x, 300);
                Sleep1();
            }

            RefreshPicture();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int a = 0; a <= 300; a += 30)
            {
                g.DrawLine(pen, 0, a, a, 0);
                Sleep1();
            }
            //g.DrawLine(pen, 0, 0, 0, 0);
            //g.DrawLine(pen, 0, 30, 30, 0);
            //g.DrawLine(pen, 0, 60, 60, 0);
            RefreshPicture();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int a = 0; a <= 300; a += 30)
            {
                g.DrawLine(pen, a, 300, 300, a);
                Sleep1();
            }

            //g.DrawLine(pen, 0, 300, 300, 0);
            //g.DrawLine(pen, 30, 300, 300, 30);
            RefreshPicture();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            /*for (int a = 0; a <= 300; a += 30)
            {
                g.DrawLine(pen, 0, a, a, 0);
                Sleep1();
            }
            //g.DrawLine(pen, 0, 0, 0, 0);
            //g.DrawLine(pen, 0, 30, 30, 0);
            //g.DrawLine(pen, 0, 60, 60, 0);
            RefreshPicture();

            for (int a = 0; a <= 300; a += 30)
            {
                g.DrawLine(pen, a, 300, 300, a);
                Sleep1();
            }

            //g.DrawLine(pen, 0, 300, 300, 0);
            //g.DrawLine(pen, 30, 300, 300, 30);
            RefreshPicture();*/


            for (int a = 0; a < 300; a += 30)
            {
                g.DrawLine(pen, 0, a, a, 0);
                Sleep1();
            }
            for (int a = 0; a <= 300; a += 30)
            {
                //if (a != 300)//каждый цикл проверяется, не равно ли а 300
                g.DrawLine(pen, a, 300, 300, a);
                Sleep1();
            }

            //g.DrawLine(pen, 0, 300, 300, 0);
            //g.DrawLine(pen, 30, 300, 300, 30);
            RefreshPicture();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int y = 0; y <= 300; y += 30)
            {
                g.DrawLine(pen, 0, 0, 300, y);
                Sleep1();
                g.DrawLine(pen, 0, 0, y, 300);
                Sleep1();
            }
            //.DrawLine(pen, 0, 0, 300, 0);
            //g.DrawLine(pen, 0, 0, 300, 30);
            //g.DrawLine(pen, 0, 0, 300, 60);

            RefreshPicture();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int x = 300; x >= -0; x -= 30)
            {
                g.DrawLine(pen, 300, 300, x, 0);
                Sleep1();
                g.DrawLine(pen, 300, 300, 0, x);
                Sleep1();
            }
            //g.DrawLine(pen, 300, 300, 300, 0);
            //g.DrawLine(pen, 300, 300, 270, 0);
            //g.DrawLine(pen, 300, 300, 240, 0);

            RefreshPicture();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int y = 0; y <= 300; y += 30)
            {
                g.DrawLine(pen, 0, 0, 300, y);
                Sleep1();
                /* }

                 for (int x = 300; x>=0; x-=30)
                 {*/
                int x = y;
                g.DrawLine(pen, 300, 300, 0, x);
                Sleep1();
            }
            RefreshPicture();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for (int y = 0; y <= 300; y += 30)
            {
                g.DrawLine(pen, 0, 300, y, 0);
                Sleep1();
                g.DrawLine(pen, 0, 300, 300, y);
                Sleep1();
            }
            //.DrawLine(pen, 0, 0, 300, 0);
            //g.DrawLine(pen, 0, 0, 300, 30);
            //g.DrawLine(pen, 0, 0, 300, 60);

            RefreshPicture();
            for (int x = 300; x >= 0; x -= 30)
            {
                g.DrawLine(pen, 300, 0, x, 300);
                Sleep1();
                g.DrawLine(pen, 300, 0, 0, x);
                Sleep1();
            }
            //g.DrawLine(pen, 300, 300, 300, 0);
            //g.DrawLine(pen, 300, 300, 270, 0);
            //g.DrawLine(pen, 300, 300, 240, 0);

            RefreshPicture();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < 300; y += 30)

                for (int x = 0; x < 300; x += 30)
                {
                    g.DrawRectangle(pen, x + 3, y + 3, 24, 24);
                    Sleep2();
                }

            /*for (int x = 0; x < 300; x += 30)//второй ряд по горизонтали квадратиков
            {
                g.DrawRectangle(pen, x + 3, 33, 24, 24);
                Sleep1();
            }

            for (int x = 0; x < 300; x += 30)//второй ряд по горизонтали квадратиков
            {
                g.DrawRectangle(pen, x + 3, 63, 24, 24);
                Sleep1();
            }*/
            /*g.DrawRectangle(pen, 3, 3, 24, 24);//координаты левого верхнего угла 3,3. Ширина 24, высота 24
            g.DrawRectangle(pen, 3, 33, 24, 24);
            g.DrawRectangle(pen, 3, 63, 24, 24);

            g.DrawRectangle(pen, 33, 3, 24, 24);
            g.DrawRectangle(pen, 63, 3, 24, 24);*/

            RefreshPicture();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < 300; y += 30)
                for (int x = 0; x < 300; x += 30)
                    if (x == 0 || x == 270 ||
                        y == 0 || y == 270)
                    {
                        g.DrawRectangle(pen, x + 3, y + 3, 24, 24);
                        Sleep2();
                    }
            //return;


        }

        private void button14_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 300; x += 30)//цикл, рисующий верхний и нижний ряды квадратиков
            {
                g.DrawRectangle(pen, x + 3, 3, 24, 24);
                Sleep2();
                g.DrawRectangle(pen, x + 3, 273, 24, 24);
                Sleep2();

            }
            for (int y = 30; y < 270; y += 30)
            {
                g.DrawRectangle(pen, 3, y + 3, 24, 24);
                Sleep2();
                g.DrawRectangle(pen, 273, y + 3, 24, 24);
                Sleep2();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < 300; y += 30)
                for (int x = 0; x < 300; x += 30)
                {
                    if ((x == 120 || x == 150) && //не будет рисовать квадраты в центре
                        (y == 120 || y == 150))
                        continue;
                    if (x == y || 270 - x == y || x == 150 || x == 120 || y == 120 || y == 150)
                    //if (x == y || 270 - x == y)//нарисует две диагонали
                    //if (x == y)//рисуем квадраты по одной диагонали
                    {
                        g.DrawRectangle(pen, x + 3, y + 3, 24, 24);

                    }
                    Sleep2();
                }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 300; x += 30)
            {
                if (x == 120 || x == 150)
                    continue;
                g.DrawRectangle(pen, x + 3, x + 3, 24, 24);
                Sleep2();
                g.DrawRectangle(pen, (270 - x) + 3, x + 3, 24, 24);
                Sleep2();
                g.DrawRectangle(pen, 120 + 3, x + 3, 24, 24);
                Sleep2();
                g.DrawRectangle(pen, 150 + 3, x + 3, 24, 24);
                Sleep2();
                g.DrawRectangle(pen, x + 3, 120 + 3, 24, 24);
                Sleep2();
                g.DrawRectangle(pen, x + 3, 150 + 3, 24, 24);
                Sleep2();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < 300; y += 30)

                for (int x = 0; x < 300; x += 30)
                {
                    g.DrawRectangle(pen, x + 3, y + 3, 24, 24);
                    Sleep2();

                    for (int z = 0; z <= 24; z += 3)
                    {
                        g.DrawLine(pen, x + 3 + z, y + 3, x + 3 + z, y + 27);//вертикальные линии внутри квадратов
                        g.DrawLine(pen, x + 3, y + 3 + z, x + 27, y + 3 + z);//горизонтальные динии внутри квадратов

                        Sleep3();
                    }
                }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            /*for (int y = 0; y < 300; y += 30)

                for (int x = 0; x < 300; x += 30)
                {
                    g.DrawRectangle(pen, x + 3, y + 3, 24, 24);
                    Sleep2();

                    for (int xx = 6; xx < 24; xx += 6)
                        for (int yy = 6; yy < 24; yy += 6)
                        {
                            g.DrawEllipse(pen,
                                x + 3 + xx - 3, //координата центра по оси Х
                                y + 3 + yy - 3, //координата цетра эллипса по оси У
                                6, 6); //размер эллипса
                            Sleep3();
                        }

                }
            RefreshPicture();*/
            for (int y = 0; y < 300; y += 30)

                for (int x = 0; x < 300; x += 30)
                {
                    g.DrawRectangle(pen, x + 3, y + 3, 24, 24);
                    Sleep2();

                    for (int xx = 6; xx < 24; xx += 6)
                        for (int yy = 6; yy < 24; yy += 6)
                        {
                            g.DrawEllipse(pen,
                                x + 3 + xx - 3, //координата центра по оси Х
                                y + 3 + yy - 3, //координата цетра эллипса по оси У
                                6, 6); //размер эллипса
                            Sleep3();
                        }

                }
            RefreshPicture();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //g.DrawLine(pen, 150, 150, 300, 150);//горизонтальная линия от центра в право до конца
            for (int alfa = 0; alfa < 360; alfa += 15)
            {
                g.DrawLine(pen, 150, 150,//координаты цетра 150 и 150
                    150 + (float)Math.Cos(alfa / 180.0 * Math.PI) * 150,//координаты Х
                    150 - (float)Math.Sin(alfa / 180.0 * Math.PI) * 150);//координаты У
                Sleep1();
            }       
            RefreshPicture();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            float r = 0;//радиус
            float x = 150f;//центр пикчербокса
            float y = 150f;//центр пикчербокса
            float x1, y1;
            for (int s = 1; s < 180; s += 30)
            for (int alfa = 0; alfa < 360 * 10; alfa += s)
            {
                r = alfa / 20f;//радиус увеличивается (тип флоат)
                x1 = 150 + (float)Math.Cos(alfa / 180.0 * Math.PI) * r;//координаты Х
                y1 = 150 - (float)Math.Sin(alfa / 180.0 * Math.PI) * r;//координаты У

                g.DrawLine(pen, x, y, x1, y1);//координаты центра 150 и 150
                                 
                Sleep3();
                x = x1;//координаты первой точки присвоить координате нулевой точки
                y = y1;
            }
            RefreshPicture();
        }

        private void ArcLine (float alfa, float beta)
        {
            float x1 = 150 + (float)Math.Cos(alfa / 180.0 * Math.PI) * 150;//координаты Х1 умножить на радиус 150
            float y1 = 150 - (float)Math.Sin(alfa / 180.0 * Math.PI) * 150;//координаты У1 умножить на радиус 150

            float x2 = 150 + (float)Math.Cos(beta / 180.0 * Math.PI) * 150;//координаты Х2 умножить на радиус 150
            float y2 = 150 - (float)Math.Sin(beta / 180.0 * Math.PI) * 150;
            g.DrawLine(pen, x1, y1, x2, y2);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int coeff;
            try
            {
                coeff = int.Parse(textCoeff.Text);
            }
            catch//а если не получилось считать из текстового окна textCoeff, то в коэфф записать 1
            {
                coeff = 1;
            }
            int total = 180;//количество точек по окружности всего
            //int coeff = 6;//коэффициент на который мы умножаем
            for (int n = 0; n < total; n++)
            {
                ArcLine(n * 2, n * 2 * coeff);
                Sleep3();
            }
            /*ArcLine(0, 180);
            ArcLine(0, 90);
            ArcLine(90, 180);
            ArcLine(180, 270);
            ArcLine(270, 360);
            Sleep2();*/
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int total = 180;//количество точек по окружности всего
            for (float coeff = 1; coeff < total; coeff += 0.1f)
            {
                Sleep2();
                Clear();
                for (int n = 0; n < total; n++)
                    ArcLine(n * 2, n * 2 * coeff);
            }
            
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int a, b, a1, b1;
            int R, r, d, n;
            a1 = 0;
            b1 = 0;
            try
            {
                R = int.Parse(textBox_R_BIG.Text);
                r = int.Parse(textBox_r_small.Text);
                d = int.Parse(textBox_d_penPosition.Text);
                n = int.Parse(textBox_kolichestvo.Text);
            }
            catch
            {
                R = 100;
                r = 30;
                d = 15;
                n = 1;
            }

            int h = 300;
            double koef = (double) h / (2 * (R - (r - d)));
            bool first = true;
            //for (float alfa = 0; alfa < 360 * n; alfa += 0.4f)
            for (int alfa = 0; alfa <= 360 * n; alfa ++)
            {
                a = 150 + (int)((R - r) * Math.Cos(alfa * Math.PI / 180.0) * koef) + (int)(d * Math.Cos((R - r) * alfa * Math.PI / (180.0 * r)) * koef);
                b = 150 + (int)((R - r) * Math.Sin(alfa * Math.PI / 180.0) * koef) - (int)(d * Math.Sin((R - r) * alfa * Math.PI / (180.0 * r)) * koef);

                //a = 150 + (R - r) * (int)Math.Cos(alfa / 180.0 * Math.PI) + d * ((int)Math.Cos((alfa / 180.0 * Math.PI) * R - r));
                //b = 150 + (R - r) * (int)Math.Sin(alfa / 180.0 * Math.PI) - d * ((int)Math.Sin((alfa / 180.0 * Math.PI) * R - r));
                //a1 = a;// + 1;
                // b1 = b;// + 1;
                if (first) { a1 = a; b1 = b; first = false; } // убираем стартовую линию через булевскую переменную
                g.DrawLine(pen, a, b, a1, b1);
                a1 = a;// + 1;
                b1 = b;// + 1;
               // Sleep2();
                RefreshPicture();
            }

            /*for (float alfa = 0; alfa <= 360; alfa += 0.1f)
            {
                float x = (float)((60 - 5) * Math.Cos(alfa) + 25 * Math.Cos((60 - 5) / 5 * alfa)) + 150;
                float y = (float)((60 - 5) * Math.Sin(alfa) - 25 * Math.Sin((60 - 5) / 5 * alfa)) + 150;
                g.DrawLine(pen, x, y, x + 1, y + 1);
                RefreshPicture();//Sleep3();
            } */




            /* float _rb = 108f;//150f;
            float _rm = 150f;//201F;
            float _d = 10f;//87f;
            float _proh = 25f;//25f;

            for (float _alfa = 0; _alfa <= 360 * _proh; _alfa +=1)
            {
                Spirograf(_rb, _rm, _d, _alfa);
                RefreshPicture();
            }
        }

        private void Spirograf (float _rb, float _rm, float _d, float _alfa)
        {
            float _x1 = 150 + (float)((_rb - _rm) * Math.Cos(_alfa / 180.0 * Math.PI) + _d * Math.Cos(((_rb - _rm) / _rm) * (_alfa / 180.0 * Math.PI)));
            float _y1 = 150 - (float)((_rb - _rm) * Math.Sin(_alfa / 180.0 * Math.PI) - _d * Math.Sin(((_rb - _rm) / _rm) * (_alfa / 180.0 * Math.PI)));
            float _x2 = 150 + (float)((_rb - _rm) * Math.Cos((_alfa + 1) / 180.0 * Math.PI + _d * Math.Cos(((_rb - _rm) - _rm) * ((_alfa + 1) / 180.0 * Math.PI))));
            float _y2 = 150 - (float)((_rb - _rm) * Math.Sin((_alfa + 1) / 180.0 * Math.PI - _d * Math.Sin(((_rb - _rm) - _rm) * ((_alfa + 1) / 180.0 * Math.PI))));
            g.DrawLine(pen, _x1, _y1, _x2, _y2);*/
        }

    }
}