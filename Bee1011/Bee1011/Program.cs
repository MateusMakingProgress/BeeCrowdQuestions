﻿using System;

class URI
{

    static void Main(string[] args)
    {
        double raio = double.Parse(Console.ReadLine());

        double pi = 3.14159;

        double calculo = (4.0 / 3) * pi * (raio * raio) * raio;

        Console.WriteLine("VOLUME = " + calculo.ToString("F3"));
    }

}