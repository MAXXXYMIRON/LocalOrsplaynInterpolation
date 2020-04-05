using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Design;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LocalOrsplaynInterpolation
{
    public partial class Form1 : Form
    {
        SequencePoints Given = new SequencePoints {
            new Point(-1.2, 3.38688),
            new Point(-0.6, -4.35456),
            new Point(0.5, 11.71875),
            new Point(1.5, 29.53125),
            new Point(1.9, 26.00169),
            new Point(2.6, 6.88896)};

        SequencePoints Points = new SequencePoints(6);

        void Sort(SequencePoints points)
        {
            double temp = 0;
            for (int i = 0; i < points.Count - 1; i++)
                for (int j = 0; j < points.Count - i - 1; j++)
                    if(points[j].x > points[j + 1].x)
                    {
                        temp = points[j].x;
                        points[j].x = points[j + 1].x;
                        points[j + 1].x = temp;
                    }
        }

        const byte CountScales = 20;

        Bitmap[] BitmapsScales = new Bitmap[CountScales];
        Graphics Draw;

        int[] scales = new int[CountScales]
            {2, 3, 5, 6, 10, 12, 15, 20, 24, 25, 30, 40, 50, 60, 75, 100, 150, 200, 300, 600};
        byte s = 10;
        byte scaleIndex
        {
            get => s;
            set => s = (value > CountScales - 1) ? (byte)(CountScales - 1) : value;
        }

        Point Center;
        double TempCenter = 0;


        Pen LinesPen = new Pen(Color.Black, 1),
            GraphPen = new Pen(Color.Yellow, 1),
            CenterPen = new Pen(Color.Red, 2);

        void MakeBitmaps()
        {
            for(int j = 0; j < scales.Length; j++)
            {
                BitmapsScales[j] = new Bitmap(BitmapGraph.Width, BitmapGraph.Height);
                Draw = Graphics.FromImage(BitmapsScales[j]);

                for (int i = 0; i <= BitmapGraph.Width; i += scales[j])
                {
                    Draw.DrawLine(LinesPen, i, 0, i, BitmapGraph.Height);
                }
                for (int i = 0; i <= BitmapGraph.Height; i += scales[j])
                {
                    Draw.DrawLine(LinesPen, 0, i, BitmapGraph.Width, i);
                } 
            }
        }


        bool ClickSplayn = false;

        public Form1()
        {
            InitializeComponent();

            MakeBitmaps();

            Center = new Point((BitmapGraph.Width / 2) - ((BitmapGraph.Width / 2) % scales[scaleIndex]),
                (BitmapGraph.Height / 2) - ((BitmapGraph.Height / 2) % scales[scaleIndex]));

            OptioningScrolls();

            DrawGraphics(Draw);
        }



        private void DrawGraphics(Graphics Draw)
        {
            Bitmap Graph = new Bitmap(BitmapsScales[scaleIndex]);
            Draw = Graphics.FromImage(Graph);

            DrawCenters(Graph, Draw);
            if (ClickSplayn) DrawSplayn(Graph, Draw, Points);

            BitmapGraph.BackgroundImage = Graph;
        }

        private void DrawSplayn(Bitmap Graph, Graphics Draw, SequencePoints points)
        {
            float
                x0 = (float)points[0].x, 
                y0 = (float)points[0].y,
                x1 = 0, y1 = 0,
                xT = 0, yT = 0;

            Sort(points);
            float PosX(float x)
            {
                return (float)(Center.x + (x * scales[scaleIndex]));
            }
            float PosY(float y)
            {
                return (float)(Center.y - (y * scales[scaleIndex]));
            }

            for (int i = 0; i < points.Count - 1; i++)
            {
                x1 = (float)points[i + 1].x;
                y1 = (float)points[i + 1].y;

                while (x0 < x1 - 0.01f)
                {
                    xT = x0 + 0.01f;
                    yT = (float)Splayn.f(xT);

                    Draw.DrawLine(GraphPen, PosX(x0), PosY(y0), PosX(xT), PosY(yT));

                    x0 = xT;
                    y0 = yT;
                }

                x0 = x1;
                y0 = y1;
            }
        }

        private void DrawCenters(Bitmap Graph, Graphics Draw)
        {
            Draw.DrawLine(CenterPen, (float)Center.x, 0, (float)Center.x, BitmapGraph.Height);

            Draw.DrawLine(CenterPen, 0, (float)Center.y, BitmapGraph.Width, (float)Center.y);
        }


        void OptioningScrolls()
        {
            ScrollH.SmallChange = ScrollH.LargeChange =
                ScrollV.SmallChange = ScrollV.LargeChange = scales[scaleIndex];

            ScrollH.Value = (int)(Center.x = Center.x - (Center.x % scales[scaleIndex]));
            ScrollV.Value = (int)(Center.y = Center.y - (Center.y % scales[scaleIndex]));
        }
        

        private void pl_Click(object sender, EventArgs e)
        {
            scaleIndex++;

            OptioningScrolls();

            DrawGraphics(Draw);
        }

        private void mn_Click(object sender, EventArgs e)
        {
            scaleIndex--;

            OptioningScrolls();

            DrawGraphics(Draw);
        }

        private void ScrollV_Scroll(object sender, ScrollEventArgs e)
        {
            TempCenter = Center.y;
            Center.y = ScrollV.Value - (ScrollV.Value % scales[scaleIndex]);
            if(TempCenter != Center.y) DrawGraphics(Draw);
        }

        private void ScrollH_Scroll(object sender, ScrollEventArgs e)
        {
            TempCenter = Center.x;
            Center.x = ScrollH.Value - (ScrollH.Value % scales[scaleIndex]);
            if(TempCenter != Center.x) DrawGraphics(Draw);
        }

        private void SplaynRun_Click(object sender, EventArgs e)
        {
            if (Points.Count == 0) return;

            ClickSplayn = true;
            Splayn.InitSplayn(Points);
            DrawGraphics(Draw);
        }





        /// <summary>
        /// Проверка на ввод цифры, знака, Back, Del или точки.
        /// </summary>
        /// <param name="e">Код нажатой клавиши</param>
        /// <returns></returns>
        (bool, char) IsDigit(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                    return (true, '0');
                case Keys.D1:
                    return (true, '1');
                case Keys.D2:
                    return (true, '2');
                case Keys.D3:
                    return (true, '3');
                case Keys.D4:
                    return (true, '4');
                case Keys.D5:
                    return (true, '5');
                case Keys.D6:
                    return (true, '6');
                case Keys.D7:
                    return (true, '7');
                case Keys.D8:
                    return (true, '8');
                case Keys.D9:
                    return (true, '9');
                case Keys.Subtract:
                    return (true, '-');
                case Keys.Back:
                    return (true, 'B');
                case Keys.OemPeriod:
                    return (true, ',');
                case Keys.Delete:
                    return (true, 'D');
            }
            return (false, '0');
        }

        /// <summary>
        /// Проверка на ввод минуса: второго или не в первой позиции
        /// </summary>
        /// <param name="Text">Вводимое число</param>
        /// <param name="Minuse">Нажатый символ</param>
        /// <returns></returns>
        bool MinuseTest(string Text, char Minuse)
        {
            if (Minuse == '-')
            {
                if (Text.IndexOf('-') != -1) return true;
                if (Text.Length > 0) return true;
            }
            return false;
        }

        /// <summary>
        /// Проверка на ввод точки воторой раз
        /// </summary>
        /// <param name="Text">Вводимое число</param>
        /// <param name="Minuse">Нажатый символ</param>
        /// <returns></returns>
        bool PointTest(string Text, char Point)
        {
            if (Point == ',')
            {
                if (Text.IndexOf(',') != -1) return true;
            }
            return false;
        }

        /// <summary>
        /// Добавит символ нажатой клавиши TextBox.Text
        /// </summary>
        /// <param name="Coordinate">Указанный TextBox</param>
        /// <param name="e">Нажатая клавиша</param>
        void Input(ref TextBox Coordinate, KeyEventArgs e)
        {
            (bool Bool, char Char) Code = IsDigit(e);

            if (MinuseTest(Coordinate.Text, Code.Char)) return;
            if (PointTest(Coordinate.Text, Code.Char)) return;

            int Select = Coordinate.SelectionStart;

            if (Code.Bool)
            {
                if (Code.Char == 'B')
                {
                    if (Coordinate.Text.Length > 0 && Select - 1 >= 0)
                    {
                        Coordinate.Text = Coordinate.Text.Remove(Select - 1, 1);
                    }
                    Coordinate.SelectionStart = (Select - 1 < 0) ? 0 : Select - 1;
                    return;
                }
                else if (Code.Char == 'D')
                {
                    if (Coordinate.Text.Length > 0 && Select != Coordinate.Text.Length)
                    {
                        Coordinate.Text = Coordinate.Text.Remove(Select, 1);
                    }
                    Coordinate.SelectionStart = Select;
                    return;
                }
                else
                {
                    Coordinate.Text += Code.Char;
                    Coordinate.SelectionStart = Coordinate.Text.Length;
                }
            }
        }


        void InitPointsX(int index, TextBox Coordinate)
        {
            Points[index].x = (Coordinate.Text != "" && Coordinate.Text != "-"
                && Coordinate.Text[Coordinate.Text.Length - 1] != ',')
                ? Convert.ToDouble(Coordinate.Text) : 0;
        }

        void InitPointsY(int index, TextBox Coordinate)
        {
            Points[index].y = (Coordinate.Text != "" && Coordinate.Text != "-"
                && Coordinate.Text[Coordinate.Text.Length - 1] != ',')
                ? Convert.ToDouble(Coordinate.Text) : 0;
        }

        private void x1_KeyDown(object sender, KeyEventArgs e)
        {
            Input(ref x1, e);
            InitPointsX(0, x1);
        }

        private void y1_KeyDown(object sender, KeyEventArgs e)
        {
            Input(ref y1, e);
            InitPointsY(0, y1);
        }

        private void x2_KeyDown(object sender, KeyEventArgs e)
        {
            Input(ref x2, e);
            InitPointsX(1, x2);
        }

        private void y2_KeyDown(object sender, KeyEventArgs e)
        {
            Input(ref y2, e);
            InitPointsY(1, y2);
        }

        private void x3_KeyDown(object sender, KeyEventArgs e)
        {
            Input(ref x3, e);
            InitPointsX(2, x3);
        }

        private void y3_KeyDown(object sender, KeyEventArgs e)
        {
            Input(ref y3, e);
            InitPointsY(2, y3);
        }

        private void x4_KeyDown(object sender, KeyEventArgs e)
        {
            Input(ref x4, e);
            InitPointsX(3, x4);
        }

        private void y4_KeyDown(object sender, KeyEventArgs e)
        {
            Input(ref y4, e);
            InitPointsY(3, y4);
        }

        private void x5_KeyDown(object sender, KeyEventArgs e)
        {
            Input(ref x5, e);
            InitPointsX(4, x5);
        }

        private void y5_KeyDown(object sender, KeyEventArgs e)
        {
            Input(ref y5, e);
            InitPointsY(4, y5);
        }

        private void x6_KeyDown(object sender, KeyEventArgs e)
        {
            Input(ref x6, e);
            InitPointsX(5, x6);
        }

        private void y6_KeyDown(object sender, KeyEventArgs e)
        {
            Input(ref y6, e);
            InitPointsY(5, y6);
        }
    }
}
