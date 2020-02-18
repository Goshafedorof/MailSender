using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixMultiplaction
{
    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        public void Multiply_quard_matix_3_3()
        {
            // Матрица A:
            // 1 2 3
            // 4 5 6
            // 7 8 9
            //
            // Матрица B:
            // 9 8 7
            // 6 5 4
            // 3 2 1

            Matrix a = new Matrix(3, 3);
            a[0, 0] = 1; a[0, 1] = 2; a[0, 2] = 3;
            a[1, 0] = 4; a[1, 1] = 5; a[1, 2] = 6;
            a[2, 0] = 7; a[2, 1] = 8; a[2, 2] = 9;

            Matrix b = new Matrix(3, 3);
            b[0, 0] = 9; b[0, 1] = 8; b[0, 2] = 7;
            b[1, 0] = 6; b[1, 1] = 5; b[1, 2] = 4;
            b[2, 0] = 3; b[2, 1] = 2; b[2, 2] = 1;

            Matrix expected_matrix = new Matrix(3, 3);
            expected_matrix[0, 0] = 30; expected_matrix[0, 1] = 24; expected_matrix[0, 2] = 18;
            expected_matrix[1, 0] = 84; expected_matrix[1, 1] = 69; expected_matrix[1, 2] = 54;
            expected_matrix[2, 0] = 138; expected_matrix[2, 1] = 114; expected_matrix[2, 2] = 90;

            var actual_matrix =  Matrix.Multiply(a, b);

            Assert.AreEqual(expected_matrix, actual_matrix);
        }
    }
}
