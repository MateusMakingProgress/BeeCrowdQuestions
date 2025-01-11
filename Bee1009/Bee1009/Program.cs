using System;

class URI
{

    static void Main(string[] args)
    {
        string vendedor = Console.ReadLine();

        double salario = double.Parse(Console.ReadLine());

        double vendas = double.Parse(Console.ReadLine());

        if (vendas != 0)
        {
            salario = (vendas / 100) * 15 + salario;
        }

        Console.WriteLine("TOTAL = R$ " + salario.ToString("F"));
    }

}