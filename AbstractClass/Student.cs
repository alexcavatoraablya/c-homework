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

    public override void ViewInfo()
    {
        base.ViewInfo();
        string strDate = _entryDate.ToString("dd.MM.yyyy");
        Console.WriteLine("Дата вступу: "+strDate);
        string strGroup = _group.ToString();
        Console.WriteLine("Група: "+strGroup);
    }
}
