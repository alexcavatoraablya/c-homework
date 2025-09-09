// See https://aka.ms/new-console-template for more information
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Random rnd = new Random(0);
//Перетворорюємо рядок в int
int n = int.Parse(Console.ReadLine() ?? "0"); //вертає string - не можна перетворити в int
int[] marks; //Зберігає оцінки - він пустий
marks = new int[n]; //виділив память на масив 10 елементів

for (int i = 0; i < n; i++)
{
    Console.Write($"{i} -> ");
    marks[i] = int.Parse(Console.ReadLine() ?? "0");
}

int sum = 0;
foreach (int item in marks)
{
    sum += item; //Зберігаємо суму елементів
}

Console.WriteLine($"{0} * {0}");

double s = sum / (double)n;
Console.WriteLine("Відповідь: {0}", s);