using System;
using tabuleiro;
using xadrez;
namespace xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Posicao posicao = new Posicao(3, 4);
            Tabuleiro tab = new Tabuleiro(8, 8);
            //   Console.WriteLine(posicao);

            Console.WriteLine("Digite quantas Pecas Deseja inserir");
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n; i++)
            {
                Console.WriteLine("Digite a linha que deseja inserir");
                int linha = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a coluna");
                int coluna=int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a inicial da peca que deseja inserir");
                string opc = Console.ReadLine();
                if (opc.Equals("T"))
                {
                    Posicao posicao = new Posicao(linha, coluna);
                    Torre t = new Torre(tab, Enum.Parse<Cor>("Preta"));
                    tab.colocarPeca(t, posicao);
                }
                else if (opc.Equals("R"))
                {
                    Posicao posicao = new Posicao(linha, coluna);
                    Torre t = new Torre(tab, Enum.Parse<Cor>("Preta"));
                    tab.colocarPeca(t, posicao);
                }
            }

            Tela.imprimirTabuleiro(tab);



        }

    }








}