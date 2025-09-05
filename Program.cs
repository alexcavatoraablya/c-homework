using ConsoleApp1;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

//інформація про студента
//клас - механізм для створення об'єктів.
//Для створення об'єкту нам потрібно зробити клас
//а потім на основі класу створити змінну данного класу (об'єкт)
//string name = "Віктор";
//short age = 18;

int action = 0 ;
do
{
    Console.WriteLine("оберіть операцію");
    Console.WriteLine("0.Вихід");
    Console.WriteLine("1.Додати студента у файл");
    Console.WriteLine("2.Показати список студентів на навчанні");
    Console.Write("->");
    action = int.Parse(Console.ReadLine());
    switch (action)
    {
        case 1:
            {
                //new - виділяємо память під об'єкт victor
                Student victor = new Student();
                Console.WriteLine("Як вас звати?");
                victor.name = Console.ReadLine(); //змінні в середині класу називаються поля
                Console.WriteLine("Який ваш вік?");
                victor.age = int.Parse(Console.ReadLine()); //присвоюємо значення 18
                Console.WriteLine("Ви зарахованні на навчання.");
                Console.WriteLine($"{victor.name} {victor.age}");

                //Маю файл і режим роботи буде дозапису
                //Вміст файлу видаляти не буде
                StreamWriter sw =
                    new StreamWriter("students.txt", true);
                sw.WriteLine(victor.name);
                sw.WriteLine(victor.age);
                sw.Close();

                break;
            }
        case 2:
            {
                StreamReader sr = new StreamReader("students.txt");
                string str = sr.ReadLine();
                while (!string.IsNullOrEmpty(str))
                {
                    //Console.WriteLine(str);
                    if(!string.IsNullOrEmpty(str))
                    {
                        //якщо вдалося прочитати name
                        Student temp = new Student();
                        temp.name = str;
                        temp.age = int.Parse(sr.ReadLine()); //читаю вік
                        Console.WriteLine($"{temp.name} -- {temp.age}");
                    }
                    str = sr.ReadLine();
                }
                str = sr.ReadLine(); //Закриваємо потік читання файлу
                break;
            }
    }

} while (action != 0);