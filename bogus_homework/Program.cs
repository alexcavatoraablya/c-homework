using Bogus;
using bogus_homework;
using System.ComponentModel;
using System.Text;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Product[] list = ProductService.GetRandomProduct(50);

foreach (var item in list)
{
    Console.WriteLine(item);
}