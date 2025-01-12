using System;

internal class URI
{
    private static void Main(string[] args)
    {

        int tipoCha = int.Parse(Console.ReadLine());
        string[] participantes = Console.ReadLine().Split(' ');
        int acertos = 0;

        for (int y = 0; y < participantes.Length; y++)
        {
            Console.WriteLine(participantes[y]);
        }

        for (int i = 0; i < participantes.Length; i++)
        {
            if (int.Parse(participantes[i]) == tipoCha)
            {
                acertos++;
            }
        }
        Console.WriteLine(acertos);
    }
}