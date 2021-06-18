namespace Projeto
{
    public class Opcoes : Funcoes
    {
        public Opcoes(int op)
        {
            switch(op){
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
                    Funcao("Exponenciação","**");
                break;
                case 6 : 
                    Funcao("Radiciação","***");
                break;
                case 8 : 
                    Funcao("Média Aritmética" ,  "mda");
                break;
            }
        }
    }
}