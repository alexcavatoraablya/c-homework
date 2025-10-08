using System;
using System.Text;
//тут знаходиться набір класів для роботи з колекціями
using System.Collections;
using MyCollection;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

//може зберігати однаковий тип данних
Int32[] myArray = { 23, 45, 78 };
foreach (int i in myArray)
{
    Console.WriteLine("{0}\t", i);
}
Console.WriteLine();
//він не є generic - він не є шаблонним класом (може зберігати будь-який тип данних)
ArrayList myArrayList = new ArrayList();
myArrayList.Add(23);
myArrayList.Add("Hello");
myArrayList.Add(true);
myArrayList.Add(3.56);

foreach (var item in myArrayList)
{
    Console.WriteLine("{0}\t", item);
}
Console.WriteLine();

//CLS
//CLR - Common Language Runtime - єдине середовище виконання
object myObject = "hello";
Console.WriteLine(myObject);

Console.WriteLine("--------My Array Custom--------");

MyGeneric victor = new MyGeneric();
victor.Add("альона");
victor.Add("віктор");
victor.Add(18);
victor.Add(22);

victor.ViewItems();

int index = victor.SearchIndex(18);
Console.WriteLine("Search index = " + index);