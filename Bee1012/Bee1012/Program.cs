using System;

class URI
{

    static void Main(string[] args)
    {

        string[] abc = Console.ReadLine().Split(' ');

        double areaA = double.Parse(abc[0]);
        double areaB = double.Parse(abc[1]);
        double areaC = double.Parse(abc[2]);

        Console.WriteLine("TRIANGULO: " + ((areaA * areaC) / 2).ToString("F3"));
        Console.WriteLine("CIRCULO: " +  (3.14159 * (areaC * areaC)).ToString("F3"));
        Console.WriteLine("TRAPEZIO: " +  ((areaA + areaB) * areaC / 2).ToString("F3"));
        Console.WriteLine("QUADRADO: " + (areaB * areaB).ToString("F3"));
        Console.WriteLine("RETANGULO: " + (areaA * areaB).ToString("F3"));

    }

}