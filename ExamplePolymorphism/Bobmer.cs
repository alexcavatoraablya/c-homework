using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePolymorphism;

public class Bobmer : Worker
{
    private int countSpam;
    public override void ViewInfo()
    {
        base.ViewInfo();
        Console.WriteLine($"Count Spam: {countSpam}");
    }
}
