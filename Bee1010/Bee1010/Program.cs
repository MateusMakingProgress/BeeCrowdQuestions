using System;

class URI
{

    static void Main(string[] args)
    {
        string[] pedido1 = Console.ReadLine().Split(' ');
        string[] pedido2 = Console.ReadLine().Split(' ');
        int qtdPeca1 = int.Parse(pedido1[1]);
        int qtdPeca2 = int.Parse(pedido2[1]);
        double valPeca1 = double.Parse(pedido1[2]);
        double valPeca2 = double.Parse(pedido2[2]);
        double valorTotal = (qtdPeca1 * valPeca1) + (qtdPeca2 * valPeca2);

        Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F"));  
    }

}