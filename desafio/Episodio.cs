class Episodio
{

    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo => $"Episódio {Ordem} - {Titulo}. Duração: {Duracao} min. Com os convidádos: " +
        $"{string.Join(", ", convidados)}";

    private List<string> convidados = new();

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}