using InheritanceShapes;
using System.Text;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("фігури");

Rectangle rectangle = new Rectangle(15, 10);
Console.WriteLine("Площа прямокутника: {0},", rectangle.GetArea());

Circle circle = new Circle(6);
Console.WriteLine("Площа кола: {0},", circle.GetArea());