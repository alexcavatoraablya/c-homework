using twoArray;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

//int[] myArray = { 3, 8, 12, 42 };
//foreach (var item in myArray)
//{
//    Console.Write(item + "\t");
//}
//Console.WriteLine();

//int[,] myTwoArray =
//{
//    {9, 45, 12 },
//    {42, 89, 90 },
//    {3, 78, 6 }
//};

//int n = myTwoArray.GetLength(0); //рядки
//int m = myTwoArray.GetLength(1); //стовпці

////myTwoArray[0, 0] \t myTwoArray[0,1] \t myTwoArray[0,2] \n

//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < m; j++)
//    {
//        Console.Write(myTwoArray[i, j] + "\t");
//    }
//    Console.WriteLine();
//}

/*
MatrixCalculator calculator = new MatrixCalculator();
//MatrixCalculator calculator = new MatrixCalculator(2,4);

//заповняємо матрицю числами від 1 до 100
calculator.intRandomMatrix(1, 100);
calculator.PrintMatrix();

*/

MatrixCalculator a = new MatrixCalculator(3, 4);

a.intRandomMatrix();

MatrixCalculator b = new MatrixCalculator(a);

b.PrintMatrix();