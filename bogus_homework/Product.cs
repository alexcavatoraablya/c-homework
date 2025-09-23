using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bogus_homework
{
    public class Product
    {
        private string _ProductName;

        public string Name
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }

        public int Price { get; set; }


        //статичне поле для збереження кількості створенних об'єктів
        private static int _counter = 0;

        //ctor - конструктор класу
        public Product()
        {
            Product._counter++;
        }

        /// <summary>
        /// Ми зробилм конструктор з параметрами який викликає конструктор без параметрів
        /// </summary>
        /// <param _ProductName="name">назва</param>
        /// <param name="term">термін</param>

        public Product(string product, int price)
            : this() //виклик конструктора без параметрів
        {
            _ProductName = product;
            Price = price;
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
            return $"Назва = {_ProductName}, Ціна = {Price}";
        }
    }
}
