using ExampleSMTP;
using MimeKit;
using MailKit.Net.Smtp;
using System.Text;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Message msg = new Message
{
    Subject = "chicken jockey",
    Body = "обзор на дра",
    To = "alexcavatoraablya@ukr.net"
};

string pathFile = @"C:\Users\STUDENT\Desktop\images\guinea-pig-information-370 (1).jpg";

var attachment = new MimePart("image", "jpg")
{
    FileName = "життя",
    Content = new MimeContent(File.OpenRead(pathFile)),
};

var body = new TextPart("plain")
{
    Text = msg.Body,
};

var multipart = new Multipart("mixed");
multipart.Add(body);
multipart.Add(attachment);

//налаштування для відправки
var em = new MimeMessage();
em.From.Add(new MailboxAddress(MailConf.From)); //від кого
em.To.Add(new MailboxAddress(msg.To)); //кому надсилаємо
em.Subject = msg.Subject; //тема листa
//тіло повідомлення
em.Body = multipart; //тіло повідомлення

//налаштування сервера
using var client = new SmtpClient();
try
{
    //підключення до сервера - ukr.net smpt
    client.Connect(MailConf.SmtpServer, MailConf.SmtpPort, true);
    //аутентифікація
    client.Authenticate(MailConf.UserName, MailConf.Password);
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