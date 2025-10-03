using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass;

public class Student : Person
{
    /// <summary>
    /// дата вступу
    /// </summary>
    private DateTime _entryDate;
    /// <summary>
    /// група у студента
    /// </summary>
    private string _group;

    public Student()
    {
        _entryDate = DateTime.Now;
        _group = "No group";
    }

    public Student(bool isRandom=false)
        : base(isRandom)
    {
        Faker faker = new Faker("uk");
        _group = "Group"+faker.Random.Int(1, 5);
    }

    public override void ViewInfo()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        base.ViewInfo();
        string strDate = _entryDate.ToString("dd.MM.yyyy");
        Console.WriteLine("Дата вступу: "+strDate);
        Console.WriteLine("Група: "+_group);
        Console.ForegroundColor = ConsoleColor.White;
    }
}
