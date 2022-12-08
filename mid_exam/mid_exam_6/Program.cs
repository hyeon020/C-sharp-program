using System;

namespace mid_exam_6
{
    class Matrix2D
    {
        private double[,] num;
        public Matrix2D()
        {
            num = new double[2, 2];
        }
        public double this[int row, int col]
        {
            get { return num[row, col]; } //행과 열 리턴
        }
        public static Matrix2D operator +(Matrix2D a, Matrix2D b)
        {
            return new Matrix2D();
            
        }
        override public string ToString()
        {
            string r_string;
            r_string = " \n";

            for(int i = 0; i<2; i++) 
            {
                for (int j = 0; j < 2; j++)
                    r_string += String.Format($"M[{i},{j}]={num[i, j]} "); //i와 j 합
                r_string += String.Format("\n");
            }
            return r_string;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix2D A = new Matrix2D();
            Matrix2D B = new Matrix2D();
            Matrix2D C = new Matrix2D();
           
            C = A + B;
            Console.WriteLine("****************** A, Matrix2D ===========");
            Console.WriteLine(A);
            Console.WriteLine("****************** B, Matrix2D ===========");
            Console.WriteLine(B);
            Console.WriteLine("****************** Result=A+B, Matrix2D ===========");
            Console.WriteLine(C);
        }
    }
}
