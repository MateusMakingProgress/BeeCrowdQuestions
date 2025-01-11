using System;

class URI
{

    static void Main(string[] args)
    {
        string[] tomadas = Console.ReadLine().Split(' ');

        int contaTomada = 0;

        for (int i = 0; i < tomadas.Length; i++)
        {
            contaTomada += int.Parse(tomadas[i]);
        }

        Console.WriteLine(contaTomada - 3);

    }

}