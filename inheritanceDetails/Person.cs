using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceDetails;

public class Person
{
    //guid - унікальний ідентифікатор
    private readonly Guid _id;
    private string _name;
    public Person()
    {
        _id = Guid.NewGuid(); //створєюмо унікальний id
    }
}
