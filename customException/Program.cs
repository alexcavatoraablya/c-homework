using System;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;


try
{
    Console.WriteLine("Скільки вам років");
    Console.Write("->_");
    string text = Console.ReadLine();
    int age = int.Parse(text);

    Console.WriteLine("Ваше ім'я");
    Console.Write("->_");
    int name = int.Parse(text);
    if (age <= 0)
    {
        throw new Exception("Вік не може бути від'ємним числом");
    }
    Console.WriteLine($"ваш вік {age}");
}
catch (FormatException fex)
{
    Console.WriteLine("Дані було введено не вірно {0}", fex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Виникла помилка при введенні вашого віку {0}", ex.Message);
}