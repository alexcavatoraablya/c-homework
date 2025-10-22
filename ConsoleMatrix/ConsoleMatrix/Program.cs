using ConsoleMatrix;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

MyMatrix a = new MyMatrix();
a.InitRandom();

//Console.WriteLine("a[0,0] = "+ a[0,0]);
Console.WriteLine("--------наша матриця A--------");
Console.WriteLine(a.ToString());

MyMatrix b = new MyMatrix();
b.InitRandom();
Console.WriteLine("--------наша матриця B--------");
Console.WriteLine(b.ToString());

MyMatrix c = a.Add(b);
Console.WriteLine("--------наша матриця A + B--------");
Console.WriteLine(c.ToString());

MyMatrix d = a.Minus(b);
Console.WriteLine("--------наша матриця A - B--------");
Console.WriteLine(d.ToString());

MyMatrix e = a.Multiply(b);
Console.WriteLine("--------наша матриця A * B--------");
Console.WriteLine(e.ToString());