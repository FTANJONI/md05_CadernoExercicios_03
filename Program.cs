using System;

namespace md05_CadernoExercicios_03
{
    class Program
    {
        /*
         3. Leia uma matriz 3 x 2 e exiba a soma dos elementos da primeira linha e a
            soma dos elementos da primeira coluna.
         */
        static void Main(string[] args)
        {//Entrada de dados
            int[,] matriz = new int[3, 2];
            for (int linha = 0; linha <= 2; linha++)
            {
                for (int coluna = 0; coluna <= 1; coluna++)
                {
                    Console.WriteLine("Digite um valor para a posição [{0}, {1}] da Matriz.",
                        linha.ToString(), coluna.ToString());
                    matriz[linha, coluna] = Convert.ToInt32(Console.ReadLine());

                }
            }
            //Saída de dados
            int somalinha = 0, somaColuna = 0;
            for (int linha = 0; linha <= 2; linha++)
            {
                for (int coluna = 0; coluna <= 1; coluna++)
                {
                    if (linha == 0)
                    {
                        somalinha = somalinha + matriz[linha, coluna];
                    }
                    if (coluna == 0)
                    {
                        somaColuna = somaColuna + matriz[linha, coluna];
                    }
                }
            }
            Console.WriteLine("O total da linha um da matriz é: {0}", somalinha.ToString());
            Console.WriteLine("O total da coluna um da matriz é: {0}", somaColuna.ToString());
        }
    }
}
