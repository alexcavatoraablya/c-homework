using static SchoolStudent.Person;
using SchoolStudent;
using System;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

var items = Bolt.GetRoles();
foreach (var item in items) 
{
    Console.WriteLine(item);
}
Person p = new Student("паша", "ps-106");
p.PrintInfo();

Person victor = new SchoolStudent("вітя");
victor.PrintInfo();