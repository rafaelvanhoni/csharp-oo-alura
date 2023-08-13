class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome, int ano)
    {
        Nome = nome;
        Ano = ano;
    }

    public string Nome { get; }
    public int Ano { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do album {Nome}: \n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir esse álbum inteiro você precisa de {DuracaoTotal}");
    }
    
}