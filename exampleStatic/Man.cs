using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bogus.DataSets.Name;

namespace exampleStatic
{
    public class Man
    {
        private string _firstName;

        //public Gender Gender { get; set; }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public int Age { get; set; }


        //статичне поле для збереження кількості створенних об'єктів
        private static int _counter = 0;

        //ctor - конструктор класу
        public Man()
        {
            Man._counter++;
        }

        /// <summary>
        /// Ми зробилм конструктор з параметрами який викликає конструктор без параметрів
        /// </summary>
        /// <param name="firstName">Імя</param>
        /// <param name="lastName">Прізвище</param>
        /// <param name="age">Вік</param>

        public Man(string firstName, string lastName, int age)
            : this() //виклик конструктора без параметрів
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public static void Info()
        {
            Console.WriteLine("на клас для роботи Man");
        }

        public static int getCounter()
        {
            return _counter;
        }

        public override string ToString()
        {
            return $"Ім'я = {FirstName}, Прізвище = {LastName}, Вік = {Age}";
        }   
    }
}
