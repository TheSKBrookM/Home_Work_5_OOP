using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_5_2
{
    internal class MyMatrix
    {
        int[][] matrix;

        public MyMatrix(int x, int y)
        {
            matrix = new int[x][];
            for (int i = 0; i < x; i++)
            {
                matrix[i] = new int[y];
            }
            RandomFillArray();
        }
        public void RandomFillArray()
        {
            Random random = new Random();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int y = 0; y < matrix[i].Length; y++)
                {
                    matrix[i][y] = random.Next(10, 100);
                }
            }
        }
        public void ShowMatrix()
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write("{0} ", matrix[i][j]);
                }
                Console.WriteLine();
            }
        }
        public void ChangeSize(int x, int y)
        {
            if (x <= 0 || y <= 0)
            {
                Console.WriteLine("Matrix can not be negative.");
                return;
            }

            int[][] matrixNew = new int[x][];

            for (int i = 0; i < x; i++)
            {
                matrixNew[i] = new int[y];
            }

            for (int i = 0; i < Math.Min(matrix.Length, x); i++)
            {
                for (int j = 0; j < Math.Min(matrix[i].Length, y); j++)
                {
                        matrixNew[i][j] = matrix[i][j];
                }
            }

            Random rand = new Random();
            if (x > matrix.Length)
            {
                for (int i = matrix.Length; i < x; i++)
                {
                    for (int j = 0; j < Math.Min(y, matrix[0].Length); j++)
                    {
                        matrixNew[i][j] = rand.Next(10, 100);
                    }
                }
            }
            if (y > matrix[0].Length)
            {
                for (int i = matrix[0].Length; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        matrixNew[j][i] = rand.Next(10, 100);
                    }
                }
            }
            matrix = matrixNew;
        }
        public int this[int index1, int index2]
        {
            get
            {
                if (index1 >= 0 && index1 < matrix.Length && index2 >= 0 && index2 < matrix[0].Length)
                {
                    return matrix[index1][index2];
                }
                Console.WriteLine("GET out of array");
                return 0;
            }
            set
            {
                if (index1 >= 0 && index1 < matrix.Length && index2 >= 0 && index2 < matrix[0].Length)
                {
                    matrix[index1][index2] = value;
                }
                else
                {
                    Console.WriteLine("SET out of array");
                }
            }
        }

    }
}
