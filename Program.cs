using includeClass;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Привіт!");

animalss cat = new animalss();
cat.SetName("Барсик");
cat.SetAge(4);
cat.SetPoroda("Дворовий рижий");

animalss dog = new animalss();
dog.SetName("Шарік");
dog.SetAge(6);
dog.SetPoroda("Мопс");


prytulok troy = new prytulok();
troy.AddAnimal(cat);
troy.AddAnimal(dog);

Console.WriteLine("----Тварини у притулку----");
troy.ShowAnimals();

//Console.WriteLine($"{cat.GetName()}\t{cat.GetAge()}\t{cat.GetPoroda()}");
//ToString()
//Console.WriteLine(cat);
//Console.WriteLine(cat.ToString());