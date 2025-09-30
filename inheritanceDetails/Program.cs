using inheritanceDetails;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

//sealed - забороняє наслідування
//var result = Math.Cos(12); //усі методи та поля будут статичні

//Console.WriteLine("result {0}", result);

var items = Bolt.getRoles(); //отримує список рролей у системі
foreach (var item in items)
{
    Console.WriteLine(item);
}

//base

//partial - дозволяє розбивати клас на кілька файлів 