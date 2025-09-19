using Bogus;
using exampleStatic;
using System.ComponentModel;
using System.Text;
//static - дозволяє викликати методи класу без створення екземпляра класу

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

//Console.WriteLine("скільки вам років");
//int age = int.Parse(Console.ReadLine());

//Console.WriteLine($"age = {age}");

//ми використали клас Faker з пакету Bogus

//Faker faker = new Faker("uk");
//string lastName = faker.Name.LastName();
//string firstName = faker.Name.FirstName();
//int age = faker.Random.Int(1, 100);

//Man kiril = new Man();
//Man victor = new Man();
//Man vasya = new Man(firstName, lastName, age);

//Console.WriteLine(vasya);

//Man.Info();
//int count = Man.getCounter();
//Console.WriteLine("Counter Man = {0}", count);
//var list = ManService.GetRandomMan(42);

Man[] list = ManService.GetRandomMan(42);

foreach (var item in list)
{
    Console.WriteLine(item);
}