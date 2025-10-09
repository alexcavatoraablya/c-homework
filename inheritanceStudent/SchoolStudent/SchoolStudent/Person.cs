using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStudent;

public class Person
{
    private readonly Guid _id;
    private string _name;
    public Person(string name = "саша")
    {
        _id = Guid.NewGuid();
        _name = name;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Person: {_name}, Id: {_id}");
    }
}
