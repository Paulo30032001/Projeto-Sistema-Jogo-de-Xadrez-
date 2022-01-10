using System;

namespace tabuleiro
{
     class Tabuleiro
    {
        public int linhas { get; set; }

        public int colunas { get; set; }

        private Peca[,] pecas;


        public Tabuleiro() { }


        public Tabuleiro(int linhas,int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
        }


    }
}
