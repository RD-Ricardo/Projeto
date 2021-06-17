using System;
using System.Linq;
using System.Linq.Expressions;
namespace Projeto
{
    public  class Funcoes 
    {   
        int quantidade ,i; 
        double number, resultado;
        public void Funcao(string nome , string op)
        {
            Console.Write($"Digite a quantidade de numeros  a {nome}...: ");

            quantidade =  Convert.ToInt32(Console.ReadLine());

            double[] array =  new double[quantidade];

            for( i = 0; i < array.Length ; i++)
            {
               Console.Write($"numero {i + 1}...: "); 
               array[i] = Convert.ToDouble(Console.ReadLine());
               if(op == "+")
               {
                  number = number + array[i];
                  resultado = number;    
               }
               if(op == "-")
               {
                   number = number - array[i];
                   resultado = number;
               }
               if(op == "*")
               {
                   number =  number * array[i];
                   resultado =  number;
               }
               if(op == "/")
               {
                   number =   array[i] / array[i];
                   resultado =  number;
               }
               if(op == "**")
               {
                   
               }
            }
           
            Console.WriteLine(resultado);
            Console.WriteLine($"{nome} FIM");
            chamar();
        }
        public void chamar()
        {
            Console.WriteLine("| ------------------------ |");
            Console.WriteLine("| 1 - Somar                |");
            Console.WriteLine("| 2 - Subtracaob           |");
            Console.WriteLine("| 3 - Multiplicacao        |");
            Console.WriteLine("| 4 - Divisao              |");
            Console.WriteLine("| 5 - Exponenciação        |");
            Console.WriteLine("| 6 - radiciação           |");
            Console.WriteLine("| 7 - Fechar Programa      |");   
            Console.WriteLine("|--------------------------|");
            int entradaDados;
            do{
                entradaDados =  Convert.ToInt32(Console.ReadLine());

                if(entradaDados > 8 || entradaDados < 1) 
                {  
                   Console.ForegroundColor = ConsoleColor.Red;
                   Console.WriteLine("Digite somente uma das opcoes abaixo!!!");
                   Console.ForegroundColor = ConsoleColor.White;
                   chamar(); 
                }
                if(entradaDados == 8)
                {
                    Console.Clear();
                    chamar();
                }
                var ola =  new Opcoes(entradaDados);
            } while(entradaDados  >  5);       
        }
    }
}