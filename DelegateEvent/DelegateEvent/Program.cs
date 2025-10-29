using DelegateEvent;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

void DisplayAutoInfo(string info) //дисплей авто
{
    Console.WriteLine(info);
}

void DisplayAutoErrorInfo(string info) //дисплей авто
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("-----------------");
    Console.WriteLine(info);
    Console.WriteLine("-----------------");
    Console.ForegroundColor = ConsoleColor.White;
}
//створюємо об'єкт автомобіля
Car car = new Car("BMW", 240);
car.RegisterDisplayAuto(DisplayAutoInfo);//підключили дисплей для авто
//car.RegisterDisplayProblemAuto(DisplayAutoErrorInfo);//підключили дисплей для проблем авто
car.displayProblemInfoCallback += DisplayAutoErrorInfo; //підключили дисплей для проблем авто через event
car.Run(50);
car.Run(200); //збільшуємо швидкість на 200 км/год