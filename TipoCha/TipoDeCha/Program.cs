using System;

internal class URI
{
    private static void Main(string[] args)
    {
        //---------------------- Minha Resposta ----------------------\\

        int tipoCha = int.Parse(Console.ReadLine());
        int[] participantes = new int[5];
        int acertos = 0;

        for (int i = 0; i < participantes.Length; i++)
        {
            participantes[i] = int.Parse(Console.ReadLine());
            if (participantes[i] == tipoCha)
            {
                acertos++;
            }
        }

        Console.WriteLine(acertos);

        //---------------------- Resposta Aceita ----------------------\\

        //int tipoCha = int.Parse(Console.ReadLine());
        //string[] participantes = Console.ReadLine().Split(' ');
        //int acertos = 0;

        //for (int y = 0; y < participantes.Length; y++)
        //{
        //    Console.WriteLine(participantes[y]);
        //}

        //for (int i = 0; i < participantes.Length; i++)
        //{
        //    if (int.Parse(participantes[i]) == tipoCha)
        //    {
        //        acertos++;
        //    }
        //}
        //Console.WriteLine(acertos);
    }
}