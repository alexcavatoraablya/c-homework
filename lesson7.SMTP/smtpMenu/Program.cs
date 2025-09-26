using smtpMenu;
using System.Text;
using MimeKit;
using MailKit.Net.Smtp;
using ExampleSMTP;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;


int action = 0;

do
{
    Console.Write("Введіть номер дії: ");
    Console.WriteLine("Оберіть тип листа:\n" +
    "0.Вихід.\t" +
    "1.Вітаня з днем народження.\t" +
    "2.Вітання із початком тижня.\t" +
    "3.Вітання з Добрим Ранком.\t");

    action = Convert.ToInt32(Console.ReadLine());

    switch (action)
    {
        case 1:
        {
                Message1 msg = new Message1
                {
                    Subject = "З днем народження",
                    Body = "щастя та здоров'я!",
                    To = "alexcavatoraablya@ukr.net"
                };

                var body = new TextPart("plain")
                {
                    Text = msg.Body,
                };

                var multipart = new Multipart("mixed");
                multipart.Add(body);

                //налаштування для відправки
                var em = new MimeMessage();
                em.From.Add(new MailboxAddress(Mailconf.From)); //від кого
                em.To.Add(new MailboxAddress(msg.To)); //кому надсилаємо
                em.Subject = msg.Subject; //тема листa
                                          //тіло повідомлення
                em.Body = multipart; //тіло повідомлення

                //налаштування сервера
                using var client = new SmtpClient();
                try
                {
                    //підключення до сервера - ukr.net smpt
                    client.Connect(Mailconf.SmtpServer, Mailconf.SmtpPort, true);
                    //аутентифікація
                    client.Authenticate(Mailconf.UserName, Mailconf.Password);
                    //відправка
                    client.Send(em);
                    //розриваємо з'єднання
                    client.Disconnect(true);
                    Console.WriteLine("Лист відправлено успішно");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            break;
        case 2:
        {
                Message1 msg = new Message1
                {
                    Subject = "З понеділком!",
                    Body = "сил та терпіння",
                    To = "alexcavatoraablya@ukr.net"
                };

                var body = new TextPart("plain")
                {
                    Text = msg.Body,
                };

                var multipart = new Multipart("mixed");
                multipart.Add(body);

                //налаштування для відправки
                var em = new MimeMessage();
                em.From.Add(new MailboxAddress(Mailconf.From)); //від кого
                em.To.Add(new MailboxAddress(msg.To)); //кому надсилаємо
                em.Subject = msg.Subject; //тема листa
                                          //тіло повідомлення
                em.Body = multipart; //тіло повідомлення

                //налаштування сервера
                using var client = new SmtpClient();
                try
                {
                    //підключення до сервера - ukr.net smpt
                    client.Connect(Mailconf.SmtpServer, Mailconf.SmtpPort, true);
                    //аутентифікація
                    client.Authenticate(Mailconf.UserName, Mailconf.Password);
                    //відправка
                    client.Send(em);
                    //розриваємо з'єднання
                    client.Disconnect(true);
                    Console.WriteLine("Лист відправлено успішно");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            break;

        case 3:
            {
                Message1 msg = new Message1
                {
                    Subject = "Добрий ранок!",
                    Body = "Гарного настрою на весь день!",
                    To = "alexcavatoraablya@ukr.net"
                };

                var body = new TextPart("plain")
                {
                    Text = msg.Body,
                };

                var multipart = new Multipart("mixed");
                multipart.Add(body);

                //налаштування для відправки
                var em = new MimeMessage();
                em.From.Add(new MailboxAddress(Mailconf.From)); //від кого
                em.To.Add(new MailboxAddress(msg.To)); //кому надсилаємо
                em.Subject = msg.Subject; //тема листa
                                          //тіло повідомлення
                em.Body = multipart; //тіло повідомлення

                //налаштування сервера
                using var client = new SmtpClient();
                try
                {
                    //підключення до сервера - ukr.net smpt
                    client.Connect(Mailconf.SmtpServer, Mailconf.SmtpPort, true);
                    //аутентифікація
                    client.Authenticate(Mailconf.UserName, Mailconf.Password);
                    //відправка
                    client.Send(em);
                    //розриваємо з'єднання
                    client.Disconnect(true);
                    Console.WriteLine("Лист відправлено успішно");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            break;

    }
}
while (action != 0);