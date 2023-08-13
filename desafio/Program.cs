
Episodio episodio1 = new Episodio(1, "10 melhores filmes de 2023", 50);
episodio1.AdicionarConvidados("João da Silva");
episodio1.AdicionarConvidados("Maria da Silva");

Episodio episodio2 = new Episodio(2, "Melhores discos do Ano", 45);
episodio2.AdicionarConvidados("Rafael");
episodio2.AdicionarConvidados("Rodrigo");
episodio2.AdicionarConvidados("Raul");


Podcast podcast1 = new("Meu Podcast", "Rafael Vanhoni");
podcast1.AdicionarEpisodio(episodio1);
podcast1.AdicionarEpisodio(episodio2);

podcast1.ExibirDetalhes();

Console.ReadKey();