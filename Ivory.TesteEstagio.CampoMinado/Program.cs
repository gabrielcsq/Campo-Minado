using System;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            var campoMinado = new CampoMinado();
            Console.WriteLine("Início do jogo\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);


            // Realize sua codificação a partir deste ponto, boa sorte!

            /// <summary>
            /// Usuário informa as coordenadas que deseja abrir.
            /// Status de jogo:
            /// Se jogo em aberto, continua perguntando.
            /// Se jogo finalizado, informa ao usuário se ele perdeu ou se ele ganhou.
            /// </summary>
            
            do
            {
                var x = new int();
                var y = new int();
                Console.WriteLine("\nQual casa você deseja abrir?  ");
                Console.Write("\nLinha: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("\nColuna: ");
                y = int.Parse(Console.ReadLine());

                campoMinado.Abrir(x, y);

                Console.Clear();

                Console.WriteLine("Jogo em aberto, continue procurando as casas que não possuem bombas.\n=========");
                Console.WriteLine(campoMinado.Tabuleiro);


            } while ((campoMinado.JogoStatus != 1) && (campoMinado.JogoStatus != 2));

            Console.Clear();

            if (campoMinado.JogoStatus == 1)
            {
                Console.WriteLine("Vitoria, você encontrou todas as casas que não possui bomba.\n=========");
                Console.WriteLine(campoMinado.Tabuleiro);
            }
            else if (campoMinado.JogoStatus == 2)
            {
                Console.WriteLine("GameOver, você encontrou uma bomba.\n=========");
                Console.WriteLine(campoMinado.Tabuleiro);
            }
        }
    }
}
