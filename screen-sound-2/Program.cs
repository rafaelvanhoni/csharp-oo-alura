Banda nofx = new ("NOFX");

Album albumTheLonguestLine = new ("The Longuest Line", 1992);
Album albumRibbed = new("Ribbed", 1991);
Album albumLiberalAnimation = new("Liberal Animation", 1988);
Album albumPunkInDrublic = new("Punk in Drublic", 1994);

Genero genero = new("Punk Rock");

Musica musica1 = new(nofx, "The Death of John Smith", genero)
{
    Duracao = 231,
    Disponivel = true,
};

Musica musica2 = new(nofx, "The Longuest Line", genero)
{
    Duracao = 124,
    Disponivel = true,
};

Musica musica3 = new(nofx, "Stranded", genero)
{
    Duracao = 129,
    Disponivel = true,
};

Musica musica4 = new(nofx, "Remnants", genero)
{
    Duracao = 180,
    Disponivel = false,
};

Musica musica5 = new(nofx, "Kill All The White Man", genero)
{
    Duracao = 168,
    Disponivel = true,
};


albumTheLonguestLine.AdicionarMusica(musica1);
albumTheLonguestLine.AdicionarMusica(musica2);
albumTheLonguestLine.AdicionarMusica(musica3);
albumTheLonguestLine.AdicionarMusica(musica4);
albumTheLonguestLine.AdicionarMusica(musica5);


musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
musica3.ExibirFichaTecnica();
musica4.ExibirFichaTecnica();
musica5.ExibirFichaTecnica();

nofx.AdicionarAlbum(albumTheLonguestLine);
nofx.AdicionarAlbum(albumRibbed);
nofx.AdicionarAlbum(albumLiberalAnimation);
nofx.AdicionarAlbum(albumPunkInDrublic);
nofx.ExibirDiscografia();


Console.ReadKey();