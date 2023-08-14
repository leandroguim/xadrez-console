
using tabuleiro;
using xadrez_console;
using xadrez;
using tabuleiro.Enums;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();

   while (!partida.terminada)
    {
        Console.Clear();
        Tela.ImprimirTabuleiro(partida.tab);

        Console.WriteLine();
        Console.Write("Origem: ");
        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
        Console.Write("Destio: ");
        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

        partida.ExecutaMovimento(origem, destino);
    }

    Tela.ImprimirTabuleiro(partida.tab);
}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}

