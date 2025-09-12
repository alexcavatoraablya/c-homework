namespace includeClass
{
    internal class prytulok
    {
        //Набір тварин у притулку
        private animalss[] animals;

        //додаємо нову тваринку
        public void AddAnimal(animalss animal)
        {
            // || - або хибне значення лише тоді коли двоє разом хибні
            if (animals == null || animals.Length == 0)
            {
                animals = new animalss[1];
                animals[0] = animal;
            }
            else
            {
                var tempAnimals = new animalss[this.animals.Length + 1];
                int i;
                for (i = 0; i < animals.Length; i++)
                {
                    tempAnimals[i] = this.animals[i];
                }
                tempAnimals[i] = animal;
                this.animals = tempAnimals;
            }
        }

        public void ShowAnimals()
        {
            foreach(var animal in this.animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
