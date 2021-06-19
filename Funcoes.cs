using System;
using System.Linq;
using System.Linq.Expressions;
using Figgle;

namespace Projeto
{
    public  class Funcoes 
    {   
        public void Funcao(string nome, string op)
        {
            Console.WriteLine($"Selecionou  {nome.ToUpper()}");
            Console.Write($"\nDigite a quantidade que queira a {nome} : "); 
            int quantidade = int.Parse(Console.ReadLine());

            double[] array = new double[quantidade];
            
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"\nDigite o {i + 1}° número : ");
                array[i] = double.Parse(Console.ReadLine());
            }
            
            double resultado = array[0];
            
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
                    {
                        for (int i = 1; i < array.Length; i++)
                                resultado /= array[i];
                    }
                    break;
                case "mda":
                    {
                        for (int i = 1; i < array.Length; i++){
                            resultado += array[i];
                            double teste = quantidade; 
                            resultado = resultado / teste;  
                        }
                    }
                    break; 
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nResultado da sua operação: {resultado}");
            Console.ResetColor();
            Console.WriteLine("\nFim da sua operação , continue navegando ...");
            chamar();
        }
        
        public void funcaoUmaentrada(string nome , string op)
        {
            Console.WriteLine($"Selecionou {nome.ToUpper()}");
            Console.Write($"\nDigite o número que queira para realizar está operação: ");
            double al = Convert.ToDouble(Console.ReadLine());
            double resultado = al;
            switch(op)
            {
                case "**":
                    resultado = Math.Pow(al, resultado);
                break;
                case "***":
                    resultado = Math.Sqrt(al);
                break;
                case "tb":
                Console.Write("Digite o número para o  final da tabuada:");
                double c =  Convert.ToDouble(Console.ReadLine());
                    for(int i = 1; i < c + 1; i++)
                    {
                        resultado = i * al;
                        Console.WriteLine($"{al} X {i } = { resultado}");
                    }
                break;
            } 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nResultado da sua operação: {resultado}");
            Console.ResetColor();
            Console.WriteLine("\nFim da sua operação , continue navegando ...");
            chamar();
        }
        public void chamar()
        {     
            Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");  
            Console.WriteLine("▄                          |                             ▄");
            Console.WriteLine("▄ 0 - Fechar               | 6 - Radiciação              ▄");
            Console.WriteLine("▄ 1 - Soma                 | 7 - Tabuada                 ▄");
            Console.WriteLine("▄ 2 - Subtração            | 8 - Média Aritmética        ▄");
            Console.WriteLine("▄ 3 - Multiplicação        | 9 - Limpar Tela             ▄");
            Console.WriteLine("▄ 4 - Divisão              | 10 -Sobre o programa        ▄");
            Console.WriteLine("▄ 5 - Exponenciação        |                             ▄");
            Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            int entradaDados;         
            do{
                Console.Write("\nSelecione uma opção...: ");

                bool validaNumero = Int32.TryParse(Console.ReadLine(), out entradaDados);

                if(entradaDados >= 11 || !validaNumero) 
                {  
                   Console.ForegroundColor = ConsoleColor.Red;
                   Console.WriteLine("Ops, Digite somente uma das opções disponiveis...");
                   Console.ResetColor();
                   chamar(); 
                }
                var ola =  new Opcoes(entradaDados);
            }while(entradaDados  >=  11);       
        } 
    }
}


