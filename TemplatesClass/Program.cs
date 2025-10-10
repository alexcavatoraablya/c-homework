using System;
using System.Text;
using TemplatesClass;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

//масив який зберігає певний шаблон - тип данних
//List<string> list = new List<string>();
//list.Add("Віктор");
//list.Add("Олександр");
//list.Add("Іван");
//foreach (string item in list)
//{
//    string str = string.Format("{0}\t", item);
//    Console.WriteLine("{0}\t", item);
//}

//Mylist<string> mylist = new Mylist<string>();
//mylist.AddItem("Хліб");
//mylist.AddItem("Цибуля");
//mylist.AddItem("Сало");

//foreach (var item in mylist)
//{
//    Console.WriteLine("{0}\t", item);
//}

Mylist<People> commanda = new Mylist<People>();
commanda.AddItem(new People());
commanda.AddItem(new People());

foreach (var item in commanda)
{
    Console.WriteLine(item);
}