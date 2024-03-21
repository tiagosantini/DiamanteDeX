using System.ComponentModel.DataAnnotations.Schema;

namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanhoDoDiamante = 5;

            int quantidadeDeLinhas = (tamanhoDoDiamante - 1) / 2;
            int quantidadeDeEspacos = (tamanhoDoDiamante - 1) / 2;
            int quantidadeDeX = 1;

            DesenharParteSuperior(quantidadeDeLinhas, ref quantidadeDeEspacos, ref quantidadeDeX);

            DesenharMeio(tamanhoDoDiamante);

            DesenharParteInferior(quantidadeDeLinhas, ref quantidadeDeEspacos, ref quantidadeDeX);

            Console.ReadLine();
        }

        private static void DesenharParteSuperior(int quantidadeDeLinhas, ref int quantidadeDeEspacos, ref int quantidadeDeX)
        {
            for (int linha = 0; linha < quantidadeDeLinhas; linha++)
            {
                for (int espacos = 0; espacos < quantidadeDeEspacos; espacos++)
                    Console.Write(" ");

                for (int x = 0; x < quantidadeDeX; x++)
                    Console.Write("x");

                quantidadeDeEspacos--;
                quantidadeDeX += 2;

                Console.WriteLine();
            }
        }

        private static void DesenharMeio(int tamanhoDoDiamante)
        {
            for (int coluna = 0; coluna < tamanhoDoDiamante; coluna++)
            {
                Console.Write("x");
            }

            Console.WriteLine();
        }

        private static void DesenharParteInferior(int quantidadeDeLinhas, ref int quantidadeDeEspacos, ref int quantidadeDeX)
        {
            quantidadeDeEspacos = 1;
            quantidadeDeX = quantidadeDeX - 2;

            for (int linha = 0; linha < quantidadeDeLinhas; linha++)
            {
                for (int espacos = 0; espacos < quantidadeDeEspacos; espacos++)
                    Console.Write(" ");

                for (int x = 0; x < quantidadeDeX; x++)
                    Console.Write("x");

                quantidadeDeEspacos++;
                quantidadeDeX -= 2;

                Console.WriteLine();
            }
        }
    }
}
