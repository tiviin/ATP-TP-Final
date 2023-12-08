using System;

namespace Aula_1
{
    internal class Program
    {
        static Random rand = new Random();
        static void Main()
        {
            Console.WriteLine("MAPA DO JOGADOR");
            Jogador();
            Console.WriteLine("DIVISÃO DE JOGO");
            Console.WriteLine("MAPA DO COMPUTADOR");
            //Computador();

            // JOGADOR ESCOLHEI INTERAGIR COM MATRIZ
            // ESCOLHE ONDE ATACAR
            // CHECAGEM
            // COMPUTADOR ATACA ALEATORIO
            // CHECAGEM
            // WHILE JOGO DURAR
        }

        static void Jogador()
        {
            char[,] matriz = new char[10, 10];

            PreencherMatrizComA(matriz, true);

            AdicionarS(matriz, true);

            AdicionarH(matriz, true);

            AdicionarC(matriz, true);

            AdicionarE(matriz, true);

            AdicionarP(matriz, true);

            MostrarMatriz(matriz, true);
            // RETONAR MATRIZ
        }
        static void Computador()
        {
            char[,] matriz = new char[10, 10];

            PreencherMatrizComA(matriz, false);

            AdicionarS(matriz, false);

            AdicionarH(matriz, false);

            AdicionarC(matriz, false);

            AdicionarE(matriz, false);

            AdicionarP(matriz, false);

            MostrarMatriz(matriz, false);
            // RETONAR MATRIZ

        }

        static void PreencherMatrizComA(char[,] matriz, bool jogador)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = 'A';
                }
            }
        }

        static void AdicionarS(char[,] matriz, bool jogador)
        {
            int contador = 0;

            while (contador < 4)
            {
                int linha = rand.Next(0, matriz.GetLength(0) - 1);
                int coluna = rand.Next(0, matriz.GetLength(1) - 1);

                if (matriz[linha, coluna] == 'A')
                {
                    matriz[linha, coluna] = 'S';
                    contador++;
                }
            }
        }

        static void AdicionarH(char[,] matriz, bool jogador)
        {
            int contador = 0;
            bool tentar = false;
            while (contador < 3)
            {
                do
                {
                    tentar = false;
                    int linha = rand.Next(0, matriz.GetLength(0) - 1);
                    int coluna = rand.Next(0, matriz.GetLength(1) - 1);
                    int direcao = rand.Next(0, 2);
                    if (direcao == 0)
                    {
                        if (coluna <= matriz.GetLength(1) - 2)
                        {
                            if (coluna <= (matriz.GetLength(1) - 2) && matriz[linha, coluna] == 'A' && matriz[linha, coluna + 1] == 'A')
                            {
                                matriz[linha, coluna] = 'H';
                                matriz[linha, coluna + 1] = 'H';
                                contador++;
                            }
                        }
                        else
                        {
                            tentar = true;
                        }
                    }
                    else
                    {
                        if (coluna <= (matriz.GetLength(1) - 2) && matriz[linha, coluna] == 'A' && matriz[linha + 1, coluna] == 'A')
                        {
                            matriz[linha, coluna] = 'H';
                            matriz[linha + 1, coluna] = 'H';
                            contador++;
                        }
                        else
                        {
                            tentar = true;
                        }
                    }
                } while (tentar);
            }
        } 
        static void AdicionarC(char[,] matriz, bool jogador)
        {
            int contador = 0;
            bool tentar = false;


            while (contador < 2)
            {
                do
                {
                    tentar = false;
                    int linha = rand.Next(0, matriz.GetLength(0) - 1);
                    int coluna = rand.Next(0, matriz.GetLength(1) - 1);
                    int direcao = rand.Next(0, 2);
                    if (direcao == 0)
                    {
                        if (coluna <= (matriz.GetLength(1) - 3) && matriz[linha, coluna] == 'A' && matriz[linha, coluna + 1] == 'A' && matriz[linha, coluna + 2] == 'A')
                        {
                             matriz[linha, coluna] = 'C';
                             matriz[linha, coluna + 1] = 'C';
                             matriz[linha, coluna + 2] = 'C';
                             contador++;
                        }
                        else
                        {
                            tentar = true;
                        }
                    }
                    else
                    {
                        if (linha <= (matriz.GetLength(0) - 3) && matriz[linha, coluna] == 'A' && matriz[linha + 1, coluna] == 'A' && matriz[linha + 2, coluna] == 'A')
                        {
                            matriz[linha, coluna] = 'C';
                            matriz[linha + 1, coluna] = 'C';
                            matriz[linha + 2, coluna] = 'C';
                            contador++;
                        }
                        else
                        {
                            tentar = true;
                        }
                    }
                } while (tentar);
            }
        }

        static void AdicionarE(char[,] matriz, bool jogador)
        {
            bool tentar = false;
                do
                {
                    int linha = rand.Next(0, matriz.GetLength(0) - 1);
                    int coluna = rand.Next(0, matriz.GetLength(1) - 1);
                    int direcao = rand.Next(0, 2);
                    tentar = false;


                    if (direcao == 0)
                    {
                        if (coluna <= (matriz.GetLength(1) - 4) && matriz[linha, coluna] == 'A' && matriz[linha, coluna + 1] == 'A' && matriz[linha, coluna + 2] == 'A' && matriz[linha, coluna + 3] == 'A')
                        {
                            matriz[linha, coluna] = 'E';
                            matriz[linha, coluna + 1] = 'E';
                            matriz[linha, coluna + 2] = 'E';
                            matriz[linha, coluna + 3] = 'E';
                        }
                        else
                        {
                            tentar = true;
                        }
                    }
                    else
                    {
                        if (linha <= (matriz.GetLength(0) - 4) && matriz[linha, coluna] == 'A' && matriz[linha + 1, coluna] == 'A' && matriz[linha + 2, coluna] == 'A' && matriz[linha + 3, coluna] == 'A')
                        {
                            matriz[linha, coluna] = 'E';
                            matriz[linha + 1, coluna] = 'E';
                            matriz[linha + 2, coluna] = 'E';
                            matriz[linha + 3, coluna] = 'E';

                        }
                        else
                        {
                            tentar = true;
                        }
                    }
                } while (tentar);

          
            
        }
        static void AdicionarP(char[,] matriz, bool jogador)
        {
            int contador = 0;
            bool tentar = false;
            do
            {
                int linha = rand.Next(0, matriz.GetLength(0));
                int coluna = rand.Next(0, matriz.GetLength(1) - 1);
                int direcao = rand.Next(0, 2);
                tentar = false;

                if (direcao == 0)
                {
                    if (coluna <= (matriz.GetLength(1) - 5) && matriz[linha, coluna] == 'A' && matriz[linha, coluna + 1] == 'A' && matriz[linha, coluna + 2] == 'A' && matriz[linha, coluna + 3] == 'A' && matriz[linha, coluna + 4] == 'A')
                    {
                        matriz[linha, coluna] = 'P';
                        matriz[linha, coluna + 1] = 'P';
                        matriz[linha, coluna + 2] = 'P';
                        matriz[linha, coluna + 3] = 'P';
                        matriz[linha, coluna + 4] = 'P';

                    }
                    else
                    {
                        tentar = true;
                    }
                }
                else
                {
                    if (linha <= (matriz.GetLength(0) - 5) && matriz[linha, coluna] == 'A' && matriz[linha + 1, coluna] == 'A' && matriz[linha + 2, coluna] == 'A' && matriz[linha + 3, coluna] == 'A' && matriz[linha + 4, coluna] == 'A')
                    {
                        matriz[linha, coluna] = 'P';
                        matriz[linha + 1, coluna] = 'P';
                        matriz[linha + 2, coluna] = 'P';
                        matriz[linha + 3, coluna] = 'P';
                        matriz[linha + 4, coluna] = 'P';

                    }
                    else
                    {
                        tentar = true;
                    }
                }
            } while (tentar);
        }

        static void MostrarMatriz(char[,] matriz, bool jogador)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
