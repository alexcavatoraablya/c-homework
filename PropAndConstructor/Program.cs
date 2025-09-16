using PropAndConstructor;
using System.Text;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Person victor = new Person();

victor.setFirstName("Вітя");

victor.LastName = "Марков"; //викликаємо set

victor.Phone = "+38(097) 223 45 76";

Person ira = new Person("Сидоренко", "Іра", "+38(050) 123 45 67");

//Console.WriteLine(victor.getFirstName());
//Console.WriteLine(victor.LastName); //визначаємо get
//Console.WriteLine(victor.Phone);

Console.WriteLine(victor);
Console.WriteLine(ira);