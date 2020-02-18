using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplaction
{
    public class Matrix
    {
        private static Random _random = new Random();

        /// <summary>
        /// Количесвто столбцов в матрице
        /// </summary>
        public int ColumnsCount { get { return _matrix[0].Length; } }
        /// <summary>
        /// Количество строк в матрице
        /// </summary>
        public int RowsCount { get { return _matrix.Length; } }

        public int this[int row, int column] 
        {
            set { _matrix[row][column] = value; }
            get { return _matrix[row][column]; }
        }

        private int[][] _matrix;

        public Matrix() { }

        public Matrix(int columnsCount, int rowsCount)
        {
            _matrix = new int[rowsCount][];

            for (int row = 0; row < rowsCount; row++)
                _matrix[row] = new int[columnsCount];
        }

        public int[] GetRow(int indexRow)
        {
            return _matrix[indexRow];
        }

        public int[] GetColumn(int indexColumn)
        {
            int[] column = new int[RowsCount];

            for (int i = 0; i < column.Length; i++)
                column[i] = _matrix[i][indexColumn];

            return column;
        }

        public static Matrix GetRandom(int columnsCount, int rowsCount)
        {
            Matrix m = new Matrix();

            m._matrix = new int[rowsCount][];

            for (int i = 0; i < rowsCount; i++)            
                m._matrix[i] = GetRandomColumn(columnsCount);

            return m;
        }

        private static int[] GetRandomColumn(int length)
        {
            int[] line = new int[length];

            for (int j = 0; j < length; j++)
                line[j] = _random.Next(0, 11);

            return line;
        }

        public static Matrix Multiply(Matrix A, Matrix B)
        {
            if (A == null || B == null)
                throw new ArgumentNullException();

            if (A.ColumnsCount != B.RowsCount)
                throw new ArithmeticException();

            Matrix result = new Matrix(A.RowsCount, B.ColumnsCount);

            for (int row = 0; row < result.RowsCount; row++)
                for (int column = 0; column < result.ColumnsCount; column++)
                    result[row, column] = MultiplyVectors(A.GetRow(row), B.GetColumn(column));

            return result;
        }

        public static async Task<Matrix> MultiplyAsync(Matrix A, Matrix B)
        {
            if (A == null || B == null)
                throw new ArgumentNullException();

            if (A.ColumnsCount != B.RowsCount)
                throw new ArithmeticException();

            Matrix result = new Matrix(A.RowsCount, B.ColumnsCount);

            for (int row = 0; row < result.RowsCount; row++)
            {
                int row1 = row;
                for (int column = 0; column < result.ColumnsCount; column++)
                {   
                    int column1 = column;
                    result[row1, column1] = await Task.Run(() => MultiplyVectors(A.GetRow(row1), B.GetColumn(column1))).ConfigureAwait(false);
                }
            }

            return result;
        }


        private static int MultiplyVectors(int[] row, int[] column)
        {
            int result = 0;

            for (int i = 0; i < row.Length; i++)
                result += row[i] * column[i];

            return result;
        }

        //public void Multiply_quard_matix_3_3()
        //{
        //    
        //}
    }
}
