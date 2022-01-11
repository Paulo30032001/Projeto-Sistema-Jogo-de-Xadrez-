using System;
using tabuleiro;
using xadrez;
namespace xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez p = new PosicaoXadrez('c', 7);

            
            Console.WriteLine(p.ToPosicao());

        }

    }








}