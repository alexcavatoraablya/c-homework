using Bogus;
using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AbstractClass;

public class Teacher : Person
{
    /// <summary>
    /// предмет
    /// </summary>
    private string _subject = String.Empty;
    /// <summary>
    /// посада
    /// </summary>
    private string _position = String.Empty;
    /// <summary>
    /// зарплата
    /// </summary>
    private decimal _salary;

    public Teacher()
    {
        _subject = "програмування C#";
        _position = "куди вітер дує";
        _salary = 0;
    }

    public Teacher(bool isRandom = false)
        : base(isRandom)
    {
        Faker faker = new Faker("uk");
        _salary = faker.Random.Decimal(3000, 8000);
    }

    public override void ViewInfo()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        base.ViewInfo();
        Console.WriteLine($"Предмети: { _subject}");
        Console.WriteLine($"Посада: {_position}");
        Console.WriteLine($"Зарплата: {_salary}");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public override string ToString()
    {
        return $"Предмет: {_subject}, Зарплата: {_salary}";
    }
}
