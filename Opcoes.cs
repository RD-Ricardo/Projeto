namespace Projeto
{
    public class Opcoes : Funcoes
    {
        public Opcoes(int op)
        {
            switch(op){
                case 1:  
                    Funcao("soma","+");
                break;
                case 2 : 
                    Funcao("subtrair","-");
                break;
                case 3: 
                    Funcao("multiplicacao","*");
                break;
                case 4 : 
                    Funcao("divisao","/");
                break;
                
            }
        }
    }
}