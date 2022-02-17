using System;

namespace LogicaDeProgramacao_P5_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Estrutura de repetição:
            REPITA/ ENQUANTO (WHILE)
             */

            int cont = 0;
            while (cont < 20)  //Quantidade de repetição
            {
                Console.WriteLine("Letícia&Célio");
                cont++; //Deverá ser colocado para que haja prosseguimento e adicione um valor ao 0, pra não roda infinitamente.
            }
        }
    }
}
