using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customException;

public class MyReaderFile
{
    //ім'я файлу
    private string _fileName;
    //к-сть рядків у файлі
    private List<string> _lines;
    //конструктор
    public void ReadLines(string fileName)
    {
        //ініціалізація
        _lines = new List<string>();
        _fileName = fileName;
        //перевірка чи існує файл
        if (!File.Exists(_fileName))
        {
            //генерація виключення
            throw new MyReaderFileExcemption($"Файл {_fileName} не знайдено");
        }

        //вміст усього файлу
        var allLines = File.ReadAllLines(_fileName);
    }
}
