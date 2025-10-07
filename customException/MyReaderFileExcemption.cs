using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customException;

public class MyReaderFileExcemption : Exception
{
    //конструктор
    public MyReaderFileExcemption(string text)
        : base(text)
    {
        
    }
}
