using AbstractClass;
using System;
using System.Text;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

/*
//не можна створити екземпляр абстрактного класу
//Person person = new Person();

Person person = new Student();
Person teacher = new Teacher();

//as і is
if (person is Student)
{
    Console.WriteLine("-------Student-------");
    person.ViewInfo();
}
else if(person is Teacher)
{
    Console.WriteLine("-------Teacher-------");
    teacher.ViewInfo();
}

//Console.WriteLine("-------Teacher-------");
//teacher.ViewInfo();
//Console.WriteLine("-------Student-------");
//person.ViewInfo();
*/

PersonProvider pp = new PersonProvider();
pp.ListGeneration(12);
Console.WriteLine("-------List of persons-------");
pp.ShowAll();