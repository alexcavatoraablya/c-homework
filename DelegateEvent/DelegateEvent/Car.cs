using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent;

public class Car
{
    //данний делегат повідомляє інформацію про автомобіль
    public delegate void DisplayInfoDelegate(string info);
    public delegate void DisplayProblemInfoDelegate(string info);
    //поле для зберігання посилання на метод делегата
    //повідомляє на дисплей автомобіля інформацію
    private DisplayInfoDelegate? displayInfoCallback;
    //повідомляє на дисплей автомобіля інформацію про проблеми
    //private DisplayProblemInfoDelegate? displayProblemInfoCallback;
    public event DisplayProblemInfoDelegate? displayProblemInfoCallback;

    private string? model; //може зберігати null
    private int speed;
    private int maxSpeed;

    public Car()
    {
        maxSpeed = 200;
    }
    public Car(string? model, int maxSpeed)
    {
        this.model = model;
        this.maxSpeed = maxSpeed;
        speed = 0;
    }

    public void RegisterDisplayAuto(DisplayInfoDelegate? displayInfoCallback)
    {
        //реєструємо метод делегата (у авто є дисплей)
        this.displayInfoCallback = displayInfoCallback;
    }

    //public void RegisterDisplayProblemAuto(DisplayProblemInfoDelegate? displayProblemInfoCallback)
    //{
    //    //реєструємо метод делегата для повідомлення про проблеми
    //    this.displayProblemInfoCallback = displayProblemInfoCallback;
    //}

    public void Run(int speed)
    {
        this.speed += speed;
        if (this.speed > 0)
        {
            if(displayInfoCallback != null)
            {
                displayInfoCallback($"Автомобіль {model} розганяється до швидкості {this.speed} км/год");
            }
        }

        if(this.speed >= maxSpeed)
        {
            if (displayProblemInfoCallback != null)
            {
                displayProblemInfoCallback($"Автомобіль {model} досяг максимальної швидкості {maxSpeed} км/год і зупиняється!");
            }
            speed = maxSpeed;
        }
    }


    private int Speed
    {
        get { return speed; }
    }
    private string? Model
    {
        get { return model; }
        set { model = value; }
    }
}
