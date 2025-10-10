using MyComparable;
using System.Text;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

//string victor = "Віктор";
//string maria = "Марія";

//Console.WriteLine("victor.CompareTo(maria) {0}",
//    victor.CompareTo(maria));

//Console.WriteLine("maria.CompareTo(maria) {0}",
//    maria.CompareTo(victor));


//if(victor.CompareTo(maria))
//{
//    Console.WriteLine($"{victor} > {maria}");
//}

//HashSet<string> diches = new HashSet<string>();
//diches.Add("Холодець");
//diches.Add("Часник");
//diches.Add("Ананас");
//diches.Add("Ананас");

//foreach (string s in diches)
//{
//    Console.WriteLine("{0}\t", s);
//}


HashSet<Animal> animals = new HashSet<Animal>();
animals.Add(new Animal("Саня",1,Sex.Male));
animals.Add(new Animal("Спартак", 2, Sex.Male));
animals.Add(new Animal("Спартак", 2, Sex.Male));

foreach (var animal in animals)
{
    Console.WriteLine(animal);
}