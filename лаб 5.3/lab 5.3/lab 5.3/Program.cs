using System;
using System.Drawing;

namespace lab_5._3
{
    class Program
    {
        static void Main()
        {
            Matrix.GetNum();
        }
    }

    class Matrix 
    {
        public static int[,] arac;
        public static int[,] arr;
        public static int summ;

        public static void GetNum()
        {
            int[,] ara = new int[3, 3];
            Console.WriteLine("Заполните матрицу: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(i +" "+ j + ": ");
                    ara[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", ara[i, j]);
                }
                Console.WriteLine();
            }
            arr = ara;
            arac = ara;
            Console.WriteLine("Если хотите создать единичную матрицу, нажмите 2!");
            Console.WriteLine("Если хотите создать верхнюю треугольную матрицу нажмите 3!");
            Console.WriteLine("Если хотите посчитать матрицу, нажмите 4!");
            int button = Convert.ToInt32(Console.ReadLine());
            if (button == 2)
            {
                IdentityMatrix.GetIdenMat();
            } else if (button == 3)
            {
                UpperTriangularMatrix.GetUpperTrianMat();
            } else if (button == 4)
            {
                MatrixCount.Count();
            }
        }
    }

    class IdentityMatrix : Matrix
    {
        public static int[,] idenarr;
        public static void GetIdenMat()
        {
            idenarr = new int [3,3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", idenarr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }

    class UpperTriangularMatrix : Matrix
    {
        public static void GetUpperTrianMat()
        {
            arr[1, 0] = 0;
            arr[2, 0] = 0;
            arr[2, 1] = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }

    class MatrixCount : Matrix
    {

        public static void Count()
        {
            summ = arac [0, 0] * arac[1,1] * arac[2,2] + arac[2,0] * arac[0,1] * arac[1,2] + arac[1,0] * arac[0,2] * arac[2,1] - arac[2,0] * arac[1,1] * arac[0,2] - arac[0,0] * arac[2,1] * arac[1,2] - arac[1,0] * arac[0,1]* arac[2,2];
            Console.WriteLine("Подсчет матрицы= " + summ);
        }
    }
}
