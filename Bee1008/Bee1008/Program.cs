using System;

class URI
{

    static void Main(string[] args)
    {
        int numero = int.Parse(Console.ReadLine());
        int hora = int.Parse(Console.ReadLine());
        double valor = double.Parse(Console.ReadLine());

        double calculo = valor * hora;

        Console.WriteLine("NUMBER = " + numero + "\n" +
                          "SALARY = U$ " + calculo.ToString("F"));
    }

}