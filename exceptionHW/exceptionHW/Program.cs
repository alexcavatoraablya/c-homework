using exceptionHW;
using System.Reflection.PortableExecutable;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

try
{
    Console.WriteLine("Введіть назву файлу: ");
    Console.Write("->_");
    string fileName = Console.ReadLine();

    Reader reader = new Reader(fileName);
    reader.ReadFile();
}
catch (FileNotFoundException fnfex)
{
    Console.WriteLine("Файл не знайдено. {0}", fnfex.Message);
}
catch (UnauthorizedAccessException uex)
{
    Console.WriteLine("Файл неможна прочитати. {0}", uex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Помилка. {0}", ex.Message);
}