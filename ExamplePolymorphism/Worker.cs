using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePolymorphism;

public class Worker
{
    private string _id;
    private string _name;
    private string _description;
    private ushort _age; //ushort - додатнє иаленьке число

    public Worker()
    {
        _id = Guid.NewGuid().ToString();
        _name = "no name";
        _description = "no description";
        _age = 0;
    }
    //Віртуальний метод - метод, який може бути перевизначений у похідному класі
    public virtual void ViewInfo()
    {
        Console.WriteLine($"ID: {_id}");
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Age: {_age}");
    }
}
