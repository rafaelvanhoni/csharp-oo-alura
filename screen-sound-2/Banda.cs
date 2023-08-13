class Banda
{
    private List<Album> albums = new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public void AdicionarAlbum (Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"\nDiscografia da banda {Nome}\n");
        foreach (Album album in albums.OrderBy(a => a.Ano))
        {
            Console.WriteLine($"Álbum: {album.Nome}. Ano: {album.Ano}. Duração: {TimeSpan.FromSeconds(album.DuracaoTotal)}");
        }
    }
}