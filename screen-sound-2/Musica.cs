class Musica
{

    public Musica(Banda artista, string nome, Genero genero)
    {
        Artista = artista;
        Nome = nome;
        Genero = genero;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public Genero Genero { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida =>
        $"A música {Nome} pertence à banda {Artista}";
    
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"\nNome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {TimeSpan.FromSeconds(Duracao)}");
        Console.WriteLine($"Gênero: {Genero.Nome}");

    
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        } else
        {
            Console.WriteLine("Arquira o plano Plus+");
        }
    }
    
}
