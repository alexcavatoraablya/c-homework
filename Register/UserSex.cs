using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register;

internal class UserSex
{
    private string sex;
    public UserSex(string sex)
    {
        this.sex = sex;
    }

    public override string ToString()
    {
        return sex;
    }
}
