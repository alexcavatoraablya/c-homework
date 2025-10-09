using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStudent;

internal class SchoolStudent : Person
{
    public SchoolStudent(string name = "Школяр") : base(name)
    {

    }

    public override void PrintInfo()
    {
        Console.WriteLine("Це школяр :)");
        base.PrintInfo();
    }
}
