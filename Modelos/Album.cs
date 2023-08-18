namespace ScreenSound.Modelos;

class Album : IAvaliavel
{
    private List<Musica> musicas = new List<Musica>();
    public List<Avaliacao> notas = new List<Avaliacao>();
    public static int ContadorObjetos = 0;

    public Album(string nome)
    {
        Nome = nome;
        ContadorObjetos++;
    }
    
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public IEnumerable<Musica> Musicas => musicas;

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal}");
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public double Media
    {
        get
        {
            if (notas.Count == 0) 
            {
                return 0;
            }
            return notas.Average(a => a.Nota);
        }
    }
}