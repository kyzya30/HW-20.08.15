using System;

namespace HW_Arrays_Indexes__Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк матрицы:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов матрицы:");
            int colums = int.Parse(Console.ReadLine());
            MyMatrix Matrix = new MyMatrix(rows,colums);
            Matrix.FillZero(ref Matrix);
            Matrix.Show();
            Console.WriteLine("Введите количество добавляемых столбцов: ");
            int addedRows = int.Parse(Console.ReadLine());
            rows = rows + addedRows;
            Matrix.ChangeRowsColums(rows, colums, ref Matrix);
            Matrix.Show();
            Console.WriteLine("Введите количество добавляемых строк: ");
            int addedColums = int.Parse(Console.ReadLine());
            colums = colums + addedColums;
            Matrix.ChangeRowsColums(rows, colums, ref Matrix);
            Matrix.Show();
            Console.WriteLine("Введите количество удаляемых столбцов: ");
            int delRows = int.Parse(Console.ReadLine());
            rows = rows - delRows;
            Matrix.ChangeRowsColums(rows,colums,ref Matrix);
            Matrix.Show();
            Console.WriteLine("Введите количество строк: ");
            int delColums = int.Parse(Console.ReadLine());
            colums = colums - delColums;
            Matrix.ChangeRowsColums(rows,colums,ref Matrix);
            Matrix.Show();
        }
    }
    
}
