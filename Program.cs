using shelter_homework;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Animals Мурчик = new Animals(); //створив змінну для Cat - Мурчик - об'єкт

Console.WriteLine("вкажіть тваринку");
string animal = Console.ReadLine();
Мурчик.setAnimal (animal);
Console.WriteLine(Мурчик.getAnimal());

Console.WriteLine("вкажіть ім'я тваринки");
string name = Console.ReadLine();
Мурчик.setName(name);
Console.WriteLine(Мурчик.getName());

Console.WriteLine("вкажіть вік тваринки");
int age = int.Parse(Console.ReadLine());
Мурчик.setAge(age);
Console.WriteLine(Мурчик.getAge());

Console.WriteLine("вкажіть породу тваринки");
string species = Console.ReadLine();
Мурчик.setSpecies(species);
Console.WriteLine(Мурчик.getSpecies());