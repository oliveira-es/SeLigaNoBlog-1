﻿using System;
using System.Configuration;

namespace SeLigaNoBlog.Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var servico = new ServicoRecomendacao();

            servico.Executar(); 

            Console.ReadLine();
        }
    }
}
