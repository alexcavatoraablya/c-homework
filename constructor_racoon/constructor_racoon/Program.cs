using constructor_racoon;
using System;
using System.Text;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

racoon victor = new racoon();

victor.setName("Вітя");

victor.name = "Марков"; //викликаємо set

victor.color = "рижий";

racoon pushok = new racoon("Пушок", "сірий");

//Console.WriteLine(victor.getFirstName());
//Console.WriteLine(victor.LastName); //визначаємо get
//Console.WriteLine(victor.Phone);

Console.WriteLine(victor);
Console.WriteLine(pushok);




capibara vitya = new capibara();

vitya.setName("Вітя");

vitya.name = "Вася"; //викликаємо set

vitya.color = "коричневий";

capibara vasya = new capibara("Гоша", "коричневий");

//Console.WriteLine(victor.getFirstName());
//Console.WriteLine(victor.LastName); //визначаємо get
//Console.WriteLine(victor.Phone);

Console.WriteLine(vitya);
Console.WriteLine(vasya);