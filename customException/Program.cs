using System;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

//Обробка виключень
try
{
    //Запит віку
    Console.WriteLine("Скільки вам років");
    Console.Write("->_");
    //читання рядка з консолі
    string text = Console.ReadLine();
    int age = int.Parse(text);
    //перевірка на від'ємне значення
    if (age <= 0)
    {
        throw new Exception("Вік не може бути від'ємним числом");
    }
    //вивід віку
    Console.WriteLine($"ваш вік {age}");
}
//Перехоплення виключень
catch (FormatException fex)
{
    //вивід повідомлення про помилку
    Console.WriteLine("Дані було введено не вірно {0}", fex.Message);
}
//Перехоплення виключень
catch (Exception ex)
{
    //вивід повідомлення про помилку
    Console.WriteLine("Виникла помилка при введенні вашого віку {0}", ex.Message);
}