using System;
using System.Linq;
using System.Linq.Expressions;
using Figgle;

namespace Projeto
{
    public  class Funcoes 
    {   
        public void chamar()
        {
            int entradaDados;
            Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");  
            Console.WriteLine("▄                          |                             ▄");
            Console.WriteLine("▄ 0 - Fechar               | 6 - Radiciação              ▄");
            Console.WriteLine("▄ 1 - Soma                 | 7 -                         ▄");
            Console.WriteLine("▄ 2 - Subtração            | 8 - Média Aritmética        ▄");
            Console.WriteLine("▄ 3 - Multiplicação        | 9 - Limpar Tela             ▄");
            Console.WriteLine("▄ 4 - Divisão              | 10 -Sobre o programa        ▄");
            Console.WriteLine("▄ 5 - Exponenciação        |                             ▄");
            Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");         
            do{
                Console.Write("\nSelecione uma opção...: ");

                bool validaNumero = Int32.TryParse(Console.ReadLine(), out entradaDados);
                
                if(entradaDados == 0 )
                {
                    Console.ForegroundColor  = ConsoleColor.Green;
                    Console.WriteLine($"\nAté Logo...");
                    Console.ResetColor();
                    Environment.Exit(0);                  
                }

                if(entradaDados > 11 || !validaNumero) 
                {  
                   Console.ForegroundColor = ConsoleColor.Red;
                   Console.WriteLine("Ops, Digite somente uma das opções a baixo..");
                   Console.ResetColor();
                   chamar(); 
                }
                if(entradaDados ==  9) Console.Clear(); chamar();
    
                if(entradaDados ==  10)
                {
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
                }
                if(entradaDados ==  5 || entradaDados ==  6) Console.ForegroundColor =  ConsoleColor.Red; Console.WriteLine("\nAlerta!!, Digite Apenas 1 número"); Console.ResetColor();
                var ola =  new Opcoes(entradaDados);
            } while(entradaDados  >=  11);       
        }
        public void Funcao(string nome, string op)
        {
            Console.Write($"Digite a quantidade de numeros de entrada para {nome}: "); 
            int quantidade = int.Parse(Console.ReadLine());
            double[] array = new double[quantidade];
            //Primeiro insere no arrayos numeros digitados
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"\nDigite o {i + 1}° numero {i + 1}: ");
                array[i] = double.Parse(Console.ReadLine());
            }
            //Pega o primeiro numero do array como resultado inicasdial
            double resultado = array[0];
            //Verifica a operação para calcular o resultado
            switch (op)
            {
                case "+":
                    {
                        for (int i = 1; i < array.Length; i++)
                            resultado += array[i];
                    }
                    break;
                case "-":
                    {
                        for (int i = 1; i < array.Length; i++)
                            resultado -= array[i];
                    }
                    break;
                case "*":
                    {
                        for (int i = 1; i < array.Length; i++)
                            resultado *= array[i];
                    }
                    break;
                case "/":
                        for (int i = 1; i < array.Length; i++)
                            resultado /= array[i];
                    break;

                case "**":
                    {
                        for (int i = 0; i < array.Length; i++)
                            resultado = Math.Pow(resultado, array[i]);
                    } 
                break; 
                case "***":
                    {
                        for (int i = 0; i < array.Length; i++)
                            resultado = Math.Sqrt(array[i]);
                    }
                break;
                case "mda":
                    {
                        for (int i = 1; i < array.Length; i++)
                            resultado += array[i];
                            double teste = quantidade; 
                            resultado = resultado / teste;                        
                    }
                break;     
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"--------------------------");
            Console.WriteLine($"-- Resultado: {resultado} ");
            Console.WriteLine($"--------------------------");
            Console.ResetColor();
            Console.WriteLine($"\nFIM {nome}");
            chamar();
        } 
    }
}