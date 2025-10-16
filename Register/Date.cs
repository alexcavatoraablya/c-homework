using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register;

internal class Date
{
    private string date;
    public Date(string date)
    {
        this.date = date;
    }
    public override string ToString()
    {
        return date;
    }
}
