using System;
using Figgle;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(FiggleFonts.Starwars.Render("RD - Calc"));
            Console.ForegroundColor = ConsoleColor.White;
            var function =  new Funcoes();
            function.chamar();
        }
    }
}   
