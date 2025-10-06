using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSMTP;

public class Message1
{
    //тема листа
    public string Subject { get; set; } = string.Empty;

    //вміст листа
    public string Body { get; set; } = string.Empty;

    //кому надсилаємо листа
    public string To { get; set; } = string.Empty;
}
