using class_car;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

//інформація про студента
//клас - механізм для створення об'єктів.
//Для створення об'єкту нам потрібно зробити клас
//а потім на основі класу створити змінну данного класу (об'єкт)
//string name = "Віктор";
//short age = 18;

int action = 0;
do
{
    Console.WriteLine("оберіть операцію");
    Console.WriteLine("0.Вихід");
    Console.WriteLine("1.Додати автомобіль у файл");
    Console.WriteLine("2.Показати список автомобілів");
    Console.Write("->");
    action = int.Parse(Console.ReadLine());
    switch (action)
    {
        case 1:
            {
                //new - виділяємо память під об'єкт victor
                Car bmw = new Car();
                Console.WriteLine("яка марка автомобіля?");
                bmw.name = Console.ReadLine(); //змінні в середині класу називаються поля
                Console.WriteLine("яка модель автомобіля?");
                bmw.model = Console.ReadLine();
                Console.WriteLine("якого року автомобіль?");
                bmw.year = int.Parse(Console.ReadLine()); //присвоюємо значення 18
                Console.WriteLine("розмір двигуна?");
                bmw.engine = int.Parse(Console.ReadLine());
                Console.WriteLine("вітаю у салон.");
                Console.WriteLine($"{bmw.name} {bmw.model} {bmw.year} {bmw.engine}");

                //Маю файл і режим роботи буде дозапису
                //Вміст файлу видаляти не буде
                StreamWriter sw =
                    new StreamWriter("cars.txt", true);
                sw.WriteLine(bmw.name);
                sw.WriteLine(bmw.year);
                sw.Close();

                break;
            }
        case 2:
            {
                StreamReader sr = new StreamReader("cars.txt");
                string str = sr.ReadLine();
                while (!string.IsNullOrEmpty(str))
                {
                    //Console.WriteLine(str);
                    if (!string.IsNullOrEmpty(str))
                    {
                        //якщо вдалося прочитати name
                        Car temp = new Car();
                        temp.name = str;
                        temp.model = str;
                        temp.year = int.Parse(sr.ReadLine()); //читаю вік
                        Console.WriteLine($"{temp.name} -- {temp.year}");
                    }
                    str = sr.ReadLine();
                }
                str = sr.ReadLine(); //Закриваємо потік читання файлу
                break;
            }
    }

} while (action != 0);