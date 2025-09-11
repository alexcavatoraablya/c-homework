using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shelter_homework
{
    class Animals
    {
        // тип тварини
        private string animal;

        // Назва тварини
        private string name;

        // Вік тварини
        private int age; // не хочу давати public

        // вид тварини
        private string species;

        // this - звертаюся до данного класу
        public void setAnimal(string animal)
        {
            string[] listAnimal = { "Жук", "Комаха", "Ведмідь", "Лисиця" };
            var findAnimal = listAnimal.FirstOrDefault(x => x == animal);
            if (findAnimal == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Таку тваринку у притулку не приймаємо");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            this.animal = animal;
        }
        public string getAnimal() { return animal; }

        public void setName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ім'я тваринки не може бути пустим!");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            this.name = name;
        }
        public string getName() { return name; }

        public void setAge(int age)
        {
            if (age < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ця тваринка ще не народилась");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            this.age = age;

        }
        public int getAge() { return age; }

        public void setSpecies(string species)
        {
            string[] listSpecies = { "Арктичні" };
            var findSpecies = listSpecies.FirstOrDefault(x => x == species);
            if (findSpecies == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Такий вид у притулку не приймаємо");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            this.species = species;

        }
        public string getSpecies() { return species; }

    }
}
