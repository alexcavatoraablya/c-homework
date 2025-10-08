using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass;

public class PersonProvider
{
    /// <summary>
    /// можна проініціалізувати при створенні або у конструкторі
    /// </summary>
    private readonly List<Person> _persons;

    public PersonProvider()
    {
        _persons = new List<Person>();
    }
    public void ListGeneration(int count)
    {
        Random rnd = new Random();
        for (int i = 0; i < count; i++)
        {
            Person p;
            rnd.Next(0, 2);
            var item = rnd.Next(0, 2);
            if (item == 0)
                p = new Student(true);
            else
                p = new Teacher(true);
            _persons.Add(p);
        }
    }
    /// <summary>
    /// Записує усіх користувачів у файл
    /// </summary>
    /// <param name="stream">Вказівник на потік</param>
    public void WriteAllToFile(Stream stream)
    {

    }
    /// <summary>
    /// Читання із файлу через потік
    /// </summary>
    /// <param name="stream">Вказівник на потік</param>
    public void ReadAllFile(Stream stream)
    {

    }
    public void ShowAll()
    {
        foreach (Person p in _persons)
        {
            p.ViewInfo();
        }
    }
}
