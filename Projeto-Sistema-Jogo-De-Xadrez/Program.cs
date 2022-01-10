using System;
using tabuleiro;

namespace xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Posicao posicao = new Posicao(3, 4);
            Tabuleiro tab = new Tabuleiro(8, 8);
            //   Console.WriteLine(posicao);

            Tela.imprimirTabuleiro(tab);



        }

    }








}