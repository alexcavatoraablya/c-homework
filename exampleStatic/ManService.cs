using Bogus;
using static Bogus.DataSets.Name;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleStatic
{
    public static class ManService
    {
        public static Man[] GetRandomMan(int count)
        {
            Man[] list = new Man[count];
            Faker faker = new Faker("uk");
            for (int i = 0; i < count; i++)
            {
                Gender gender = faker.PickRandom<Gender>();
                string lastName = faker.Name.LastName(gender);
                string firstName = faker.Name.FirstName(gender);
                int age = faker.Random.Int(1, 100);
                list[i] = new Man(firstName, lastName, age);
            }
            return list;
        }
    }
}
