using System;
using tabuleiro;
using xadrez;
namespace xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Posicao posicao = new Posicao(3, 4);
                Tabuleiro tab = new Tabuleiro(8, 8);
                //   Console.WriteLine(posicao);
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));

                Tela.imprimirTabuleiro(tab);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }


        }

    }








}