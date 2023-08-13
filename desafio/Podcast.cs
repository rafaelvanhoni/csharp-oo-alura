class Podcast
{
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    private List<Episodio> episodios = new();

    public string Nome { get; }
    public string Host { get; }

    public int TotalEpisodios => episodios.Count;

    
    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Este é o Podcast {Nome} apresentado por {Host}");
        Console.WriteLine($"Total de Episódios: {TotalEpisodios}\n");

        foreach(Episodio ep in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine($"- {ep.Resumo}\n");
        }
    }

}