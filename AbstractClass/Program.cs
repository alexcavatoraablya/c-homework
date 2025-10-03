using AbstractClass;
using System;
using System.Text;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

//не можна створити екземпляр абстрактного класу
//Person person = new Person();

Person person = new Student();

person.ViewInfo();