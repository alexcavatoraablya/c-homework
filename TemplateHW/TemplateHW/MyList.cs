using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateHW;

public class MyList<T>
{
    //зберігаю певний набір данних Т
    private T[] _List;
    public MyList()
    {
        _List = new T[0];
    }
    public void AddItem(T item)
    {
        int n = _List.Length;
        T[] values = new T[n + 1];

        for (int i = 0; i < n; i++)
        {
            values[i] = _List[i];
        }
        values[n] = item;
        _List = values;
    }

    public IEnumerator GetEnumerator()
    {
        return _List.GetEnumerator();
    }
}
