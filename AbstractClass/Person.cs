using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass;

public abstract class Person
{
    //_ - позначка що це приватна змінна
    private string _id = String.Empty;
    private string _name = String.Empty;
    private string _phone = String.Empty;

    //конструктор захищений - можна використовувати у базовому класі
    protected Person()
    {
        _id = Guid.NewGuid().ToString();
        _name = "No name";
        _phone = "+ 38(000) 00 00 000";
    }
    //virtual
    public virtual void ViewInfo()
    {
        Console.WriteLine("Id: "+_id);
        Console.WriteLine("Name: "+_name);
        Console.WriteLine("Phone: "+_phone);
    }
}