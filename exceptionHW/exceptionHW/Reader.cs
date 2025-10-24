using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHW;

public class Reader
{
        private string _fileName;

        public Reader(string fileName)
        {
            _fileName = fileName;
        }

        public void ReadFile()
        {
            // Перевірка чи існує файл
            if (!File.Exists(_fileName))
            {
                throw new FileNotFoundException("Такого файлу не існує.", _fileName);
            }

            try
            {
                // Перевірка чи можна відкрити файл для читання
                using (FileStream fs = File.Open(_fileName, FileMode.Open, FileAccess.Read))
                {

                }

            }
            // Якщо немає доступу до файлу
            catch (UnauthorizedAccessException uex)
            {
                // Перевикидаємо виняток вище
                throw new UnauthorizedAccessException("Файл неможна прочитати.", uex);
            }

            // Читаємо всі рядки з файлу
            string[] lines = File.ReadAllLines(_fileName);

            // Перевіряємо чи більше 100 рядків
            if (lines.Length > 100)
            {
                // Перевикидаємо виняток вище
                throw new Exception("У файлі більше 100 рядків!");
            }
            // Виводимо вміст файлу
            Console.WriteLine("Вміст файлу: ");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
}
