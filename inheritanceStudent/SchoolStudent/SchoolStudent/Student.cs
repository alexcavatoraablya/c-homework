using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStudent;

public class Student : Person
{
    private string _group;
    public Student(string name = "Студент", string group = "дизайнери") : base(name)
    {
        _group = group;
    }
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Група студентів: {_group}");
    }
}
