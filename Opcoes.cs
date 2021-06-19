using System;

namespace Projeto
{
    public class Opcoes : Funcoes
    {
        public Opcoes(int op)
        {
            switch(op){
                case 0:
                    Console.ForegroundColor  = ConsoleColor.Green;
                    Console.WriteLine($"\nAté Logo...");
                    Console.ResetColor();
                    Environment.Exit(0);      
                break;
                case 1:  
                    Funcao("Soma","+");
                break;
                case 2 : 
                    Funcao("Subtração","-");
                break;
                case 3: 
                    Funcao("Multiplicação","*");
                break;
                case 4 : 
                    Funcao("Divisão","/");
                break;
                case 5 : 
                    funcaoUmaentrada("Exponenciação","**");
                break;
                case 6 : 
                    funcaoUmaentrada("Radiciação","***");
                break;
                case 7 : 
                    funcaoUmaentrada("Tabuada","tb");
                break;
                case 8 : 
                    Funcao("Média Aritmética" ,  "mda");
                break;
                case 9:
                    Console.Clear(); 
                    chamar();
                break;
                case 10:
                    Console.ForegroundColor = ConsoleColor.Blue; 
                    Console.WriteLine("\nCreditos:");
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine("- Desenvolvido por: Ricardo Dias                                 -");
                    Console.WriteLine("- Contato:                                                      -");
                    Console.WriteLine("- GitHub - https://github.com/RD-Ricardo                         -");
                    Console.WriteLine("- Instagram - https://www.instagram.com/ricardodias169/?hl=pt-br -");
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.White; 
                    chamar();
                break;
            }
        }
    }
}