using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalOrsplaynInterpolation
{
    public class Point
    {
        public double x { get; set; }
        public double y { get; set; }
        public Point(double x = 0, double y = 0)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class SequencePoints : List<Point>
    {
        public SequencePoints() : base() { }
        public SequencePoints(int capacity) : base(capacity) { }
        public SequencePoints(IEnumerable<Point> collection) : base(collection) { }

        public static void Copy(ref SequencePoints To, SequencePoints From)
        {
            if (To is null) To = new SequencePoints(From.Count);
            if (From is null) return;

            for (int i = 0; i < From.Count; i++)
            {
                To[i] = From[i];
            }
        }

        void AddGetSet(int index)
        {
            while(index >= Count)
            {
                Add(new Point());
            }
        }

        public new Point this[int index]
        {
            get
            {
                AddGetSet(index);
                return ((List<Point>)this)[index];
            }
            set
            {
                AddGetSet(index);
                ((List<Point>)this)[index] = value;
            }
        }

    }


    static class Splayn
    {
        static double[] a;
        static double[] b;
        static double[] c;
        static double[] z;
        static SequencePoints Points;


        public static void InitSplayn(SequencePoints points)
        {
            SequencePoints.Copy(ref Points, points);

            int n = points.Count;
            a = new double[n - 1];
            b = new double[n - 1];
            c = new double[n - 1];
            z = new double[n];

            z[0] = 0;


            //K[0] - Zk-1
            //K[1] - Xk
            //K[2] - Xk-1
            //K[3] - Yk
            //K[4] - Yk-1
            for (int k = 1; k < n; k++)
            {
                a[k - 1] = a_(z[k - 1], points[k].x, points[k - 1].x, points[k].y, points[k - 1].y);
                b[k - 1] = b_(z[k - 1], points[k].x, points[k - 1].x, points[k].y, points[k - 1].y);
                c[k - 1] = c_(z[k - 1], points[k].x, points[k - 1].x, points[k].y, points[k - 1].y);
                z[k] = z_(a[k - 1], points[k].x, b[k - 1]);
            }
        }

        static int SearchInterpolator(double x)
        {
            if (x < Points[0].x) return -1;
            for (int i = 0; i < Points.Count - 1; i++)
            {
                if (x > Points[i].x && x < Points[i + 1].x)
                    return i;
            }
            return -1;
        }

        public static double f(double x)
        {
            if (a is null) throw new Exception($"Сплайн не инициализирован!\n" +
                $"Требуется вызвать Splayn.InitSplayn(SequencePoints points)");

            int Interpolator = SearchInterpolator(x);

            return (a[Interpolator] * x * x) + (b[Interpolator] * x) + c[Interpolator];
        }

        //K[0] - Zk-1
        //K[1] - Xk
        //K[2] - Xk-1
        //K[3] - Yk
        //K[4] - Yk-1
        static double a_(params double[] K)
        {
            return ((K[0] * (K[2] - K[1])) + (K[3] - K[4]))
                / ((K[1] - K[2]) * (K[1] - K[2]));
        }
        static double b_(params double[] K)
        {
            return ((K[0] * ((K[1] * K[1]) - (K[2] * K[2]))) + (2 * K[2] * (K[4] - K[3])))
                / ((K[1] - K[2]) * (K[1] - K[2]));
        }
        static double c_(params double[] K)
        {
            return ((K[1] * K[1] * K[4]) - (K[1] * K[2] * ((2 * K[4]) + (K[1] * K[0]))) + ((K[2] * K[2]) * (K[3] + (K[1] * K[0]))))
                / ((K[1] - K[2]) * (K[1] - K[2]));
        }
        static double z_(double a, double x, double b)
        {
            return (2 * a * x) + b;
        }
    }
}
