using System;
using System.Text;
using TemplateHW;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

MyList<Dishes> commanda = new MyList<Dishes>();
commanda.AddItem(new Dishes());
commanda.AddItem(new Dishes());

foreach (var item in commanda)
{
    Console.WriteLine(item);
}