using System;
using System.Drawing;

namespace лаб_5._2
{
    class Program
    {
        public static int WhichCon;
        static void Main()
        {
            Console.WriteLine("Что бы расчитать обычный конус, нажмите 1");
            Console.WriteLine("Что бы расчитать усеченный конус, нажмите 2");
            WhichCon = Convert.ToInt32(Console.ReadLine());
            if ( WhichCon == 1 )
            {
                Cone.InputC();
                Cone c = new Cone();
            } 
            else if (WhichCon == 2)
            {
                Frustum.InputF();
                Frustum f = new Frustum();
            }
        }
    }

    class Cone : Program
    {
        public static Point point = new Point();
        public static double s;
        public static double v;

        public Cone()
        {
            if (WhichCon == 1)
            {
                ConeArea();
                ConeVolume();
            }
        }

        public static void ConeArea()
        {
            s = Math.PI * Math.Pow(point.X, 2);
            Console.WriteLine("Площадь нижней основы: " + s);
        }

        public static void ConeVolume()
        {
            v = (s * point.Y) * 1 / 3;
            Console.WriteLine("Обьем конуса: " + v);
        }

        public static void InputC()
        {
            Console.WriteLine("radius of cone:");
            point.X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("height of cone: ");
            point.Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("r = " + point.X + " h= " + point.Y);
        }
    }

    class Frustum : Cone
    {
        public static double r1;
        public Frustum()
        {
            if (WhichCon == 2)
            {
                ConeArea();
                FrustumVolume();
            }
        }

        public static void FrustumVolume()
        {
            v = Math.PI * point.Y * (Math.Pow(point.X, 2) + Math.Pow(r1, 2) + r1 * point.X) * 1 / 3; // r^2 + r1^2 + r1*r
            Console.WriteLine("Обьем конуса: " + v);
        }

        public static void InputF()
        {
            Console.WriteLine("радиус нижнего основания:");
            point.X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("радиус верхнего основания:");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("height of cone: ");
            point.Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("r = " + point.X + " h= " + point.Y + " r1= " + r1);
        }
    }
}

