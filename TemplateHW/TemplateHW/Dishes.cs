using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateHW;

public class Dishes
{
    private string _name;
    private int _age;
    private string _phone;

    public Dishes()
    {
        _name = "холодець";
    }

    public override string ToString()
    {
        string str = string.Format("{0}", _name);
        return str;
    }
}
