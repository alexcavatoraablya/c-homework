using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smtpMenu;

internal class Mailconf
{
    //хто надсилає листа
    public static string From { get; set; } = "alexcavatoraablya@ukr.net";
    //назва сервера
    public static string SmtpServer { get; set; } = "smtp.ukr.net";
    //порт сервера
    public static int SmtpPort { get; set; } = 555;

    //ім'я користувача для авторизації
    public static string UserName { get; set; } = "alexcavatoraablya@ukr.net";
    //пароль для доступу до ukr.net
    public static string Password { get; set; } = "i2KkSjMGLRDNSLuS";
}