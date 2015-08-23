using System;

namespace HW_Arrays_Indexes__Task1
{
    class MyMatrix
    {
        private int[,] array;
        private int rows, colums;
        public int Rows
        {
            get { return rows; }
            set
            {
                if (value > 0)
                    rows = value;
            }
        }
        public int Colums
        {
            get { return colums; }
            set
            {
                if (value > 0)
                    colums = value;
            }
        }
        public int this[int i, int j]
        {
            get { return array[i, j]; }
            set { array[i, j] = value; }
        }
        public MyMatrix(int countOfRows, int countOfColums)
        {
            Rows = countOfRows;
            Colums = countOfColums;
            array = new int[Rows, Colums];
        }
        public void Show()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Colums; j++)
                {
                    Console.Write("{0,5}", array[i, j]);
                }
                Console.WriteLine();
            }
        }
        public void FillZero(ref MyMatrix Matrix)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Matrix[i, j] = 0;
                }
            }
        }
        public void ChangeRowsColums(int newrows, int newcolums, ref MyMatrix currentMatrix)
        {
            MyMatrix tempMatrix = new MyMatrix(newrows, newcolums);
            for (int i = 0; i < newrows; i++)
            {
                for (int j = 0; j < newcolums; j++)
                {
                    tempMatrix[i, j] = 0;
                }
            }
            currentMatrix = tempMatrix;
        }
    }
}
