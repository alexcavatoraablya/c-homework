using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceDetails;

//цей клас не можна наслідувати
public sealed class Bolt
{
    public const string Admin = "адміністратор";
    public const string Manager = "менеджер";
    public const string User = "користувач";

    public static string[] getRoles() => [ Admin, Manager, User ];
}