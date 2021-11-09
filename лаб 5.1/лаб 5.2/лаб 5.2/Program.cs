using System;
using System.Drawing;

namespace лаб_5._2
{
    class Program
    {
        public static void Main()
        {
            GetInfo.Input();
            Move m = new Move();
            Rotate r = new Rotate();
        }
    }

    class GetInfo
    {
        public static int x;
        public static int y;
        public static int r;
        public static char Action;
        public static Point a = new Point();
        public static Point b = new Point();
        public static Point c = new Point();
        public static Point d = new Point();

        public static void Input()
        {
            Console.WriteLine("координата по оси ОХ:" );
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("координата по оси ОY:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("длина стороны:");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("что бы перенести квадрат, нажмите 'm', а что бы его перевернуть - 'r'!");
            Action = Convert.ToChar(Console.ReadLine());
        }
        protected void SquarParam()
        {
            a.X = x;
            a.Y = y;
            b.X = a.X;
            b.Y = a.X - r;
            c.X = b.X + r;
            c.Y = b.Y;
            d.X = c.X;
            d.Y = a.Y;
            Show();
        }
        public static void Show()
        {
            Console.WriteLine(" ");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(" ");
            Console.WriteLine("----------------------");
        }
    }

    class Move : GetInfo
    {
        public Move()
        {
            if (Action == 'm')
            {
                SquarParam();
                Console.WriteLine("нажмите стрелку вправо, что бы перенести кварат вправо,");
                Console.WriteLine("нажмите стрелку влево, что бы перенести квадрат влево!");
            }
            while (Action == 'm')
            {
                string button = Convert.ToString(Console.ReadKey().Key);
                if (button == "RightArrow")
                {
                    a.X++;
                    b.X++;
                    c.X++;
                    d.X++;
                    Show();
                }
                if (button == "LeftArrow")
                {
                    a.X--;
                    b.X--;
                    c.X--;
                    d.X--;
                    Show();
                }
            }
        }
    }
    class Rotate : Move
    {
        public static Point fp = new Point(); // fake point; 
        public Rotate()
        {
            if (Action == 'r')
            {
                SquarParam();
                Console.WriteLine("нажмите стрелку вправо, что бы повернуть кварат вправо,");
                Console.WriteLine("нажмите стрелку влево, что бы повернуть квадрат влево!");
            }
            while (Action == 'r')
            {
                string button = Convert.ToString(Console.ReadKey().Key);
                if (button == "RightArrow")
                {
                    fp = a;
                    a = d;
                    d = c;
                    c = b;
                    b = fp;
                    Show();
                }
                if (button == "LeftArrow")
                {
                    fp = a;
                    a = b;
                    b = c;
                    c = d;
                    d = fp;
                    Show();
                }
            }
        }
    }
}


