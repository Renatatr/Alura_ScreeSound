using ScreenSound.Modelos;

namespace ScreenSound.Menu;

class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}