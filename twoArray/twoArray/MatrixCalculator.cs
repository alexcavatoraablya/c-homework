using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace twoArray;

public class MatrixCalculator
{
    //наш масив у середині класу
    private int[,] matrix;
    private object myTwoArray;

    public MatrixCalculator()
    {
        matrix = new int[2, 2];
    }
    public MatrixCalculator(int n, int m)
    {
        matrix = new int[n, m];
        //m = matrix.GetLength(0);
        //n = matrix.GetLength(1);
    }

    public MatrixCalculator(MatrixCalculator calc)
    {
        int n = calc.matrix.GetLength(0);
        int m = calc.matrix.GetLength(1);
        matrix = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = calc.matrix[i, j];
            }
        }
    }

    public void intRandomMatrix(int min=1, int max=100)
    {
        Random random = new Random();
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = random.Next(1, 100);
            }
        }
    }

    public void PrintMatrix()
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
