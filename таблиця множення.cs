// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Enter a:");
Random r = new Random();

for (int i = 0; i < 10; i++)
{
    int a = r.Next(2, 9);
    //Console.WriteLine("Enter b:");
    int b = r.Next(2, 9);

    Console.Write($"{a}*{b} = ");
    int c = int.Parse(Console.ReadLine());

    if (c == a * b)
        Console.WriteLine("Вгадав");
    else
        Console.WriteLine("Вчіть таблицю множення");
}
