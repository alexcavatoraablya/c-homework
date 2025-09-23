using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bogus.DataSets.Name;

namespace bogus_homework
{
    public class ProductService
    {
        public static Product[] GetRandomProduct(int count)
        {
            Product[] list = new Product[count];
            Faker faker = new Faker("uk");
            for (int i = 0; i < count; i++)
            {
                string ProductName = faker.Commerce.Product();
                int price = faker.Random.Int(1, 50);
                list[i] = new Product(ProductName, price);
            }
            return list;
        }
    }
}
