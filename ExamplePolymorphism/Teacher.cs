using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePolymorphism;

public class Teacher : Worker
{
    //посада
    private string _position;
    //зарлата
    private decimal _salary;

    public Teacher()
    {
        _position = "no position";
        _salary = 0;
    }
    public override void ViewInfo()
    {
        base.ViewInfo();
        Console.WriteLine($"Position: {_position}");
        Console.WriteLine($"Salary: {_salary}");
    }

}
