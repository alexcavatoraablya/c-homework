using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollection;

public class MyGeneric
{
    private object[] items;

    public MyGeneric()
    {
        items = new object[0];
    }

    public void Add(object item)
    {
        int n = items.Length;
        object[] temp = new object[n+1];
        for(int i = 0; i < n; i++)
        {
            temp[i] = items[i];
        }
        temp[n] = item;
        items = temp;
    }

    public void ViewItems()
    {
        foreach (object item in items)
        Console.WriteLine(item);
    }

    public int SearchIndex(object itemSearch)
    {
        for (int i = 0; i < items.Length; i++)
        {
            var item = items[i];
            if(item.Equals(itemSearch))
                return i;
        }
        //якщо не найшли
        return -1;
    }

    public void Clear()
    {
        items = new object[0];
    }
}
