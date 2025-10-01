using ExamplePolymorphism;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

//Поліморфізм - 3-й принцип ооп
//1-ий - інкапсуляція - приховування та захист даних
//2-ий - наслідування - створення нових класів на основі існуючих
//3-ій - поліморфізм - можливість об'єктів різних класів реагувати на однакові повідомлення по-різному
//і т.д

//Worker victor = new Worker();
//victor.ViewInfo();
//Teacher mark = new Teacher();
//mark.ViewInfo();

Worker worker;
Console.WriteLine("хто вам потрібен?");
Console.WriteLine("1. Викладач");
Console.WriteLine("2. Бомбер");
int action = 0;
action = int.Parse(Console.ReadLine());
if (action == 1)
    worker = new Teacher();
else
    worker = new Bobmer();

worker.ViewInfo();

//Worker belle = new Teacher();
//belle.ViewInfo();

//Worker fark = new Bobmer();
//fark.ViewInfo();