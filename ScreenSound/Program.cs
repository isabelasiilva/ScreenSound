using ScreenSound.Banco;
using ScreenSound.Menus;
using ScreenSound.Modelos;

//try
//{
//    var context = new ScreenSoundContext();
//    var artistaDAL = new ArtistaDAL(context);

// ----- Testando métodos de artistaDAL -----
//    //var novoArtista = new Artista("Gilberto Gil", "Bio do Gilberto Gil");
//    //artistaDAL.Adicionar(novoArtista);

//    //var atualizarArtista = new Artista("Gilberto Gil", "segunda bio do Gilberto Gil") { Id = 1002};
//    //artistaDAL.Atualizar(atualizarArtista);

//    //artistaDAL.Deletar(atualizarArtista);

//    var artistaRecuperado = artistaDAL.RecuperarPeloNome("Gilberto Gil");
//    Console.WriteLine(artistaRecuperado);


//    var listaArtistas = artistaDAL.Listar();

//    foreach (var artista in listaArtistas)
//    {
//        Console.WriteLine(artista);
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.ToString());
//}





//Artista ira = new Artista("Ira!", "Banda Ira!");
//Artista beatles = new("The Beatles", "Banda The Beatles");

//Dictionary<string, Artista> artistasRegistrados = new();
//artistasRegistrados.Add(ira.Nome, ira);
//artistasRegistrados.Add(beatles.Nome, beatles);

var context = new ScreenSoundContext();
var artistaDAL = new ArtistaDAL(context);
var musicaDAL = new MusicaDAL(context);

// ----- Testando métodos de musicaDAL -----

//var novaMusica = new Musica("Oceano");
//musicaDAL.Adicionar(novaMusica);

//var atualizaMusica = new Musica("Sina") { Id = 1};
//musicaDAL.Atualizar(atualizaMusica);

//var deletarMusica = new Musica("Oceano") { Id = 3};
//musicaDAL.Deletar(deletarMusica);


var musicaRecuperada = musicaDAL.RecuperarPeloNome("Samurai");
Console.WriteLine(musicaRecuperada);


//var listarMusicas = musicaDAL.ListarMusicas();

//foreach (var item in listarMusicas)
//{
//    Console.WriteLine(item);
//}



Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarArtista());
opcoes.Add(2, new MenuRegistrarMusica());
opcoes.Add(3, new MenuMostrarArtistas());
opcoes.Add(4, new MenuMostrarMusicas());
opcoes.Add(-1, new MenuSair());

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 3.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar um artista");
    Console.WriteLine("Digite 2 para registrar a música de um artista");
    Console.WriteLine("Digite 3 para mostrar todos os artistas");
    Console.WriteLine("Digite 4 para exibir todas as músicas de um artista");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(artistaDAL);
        if (opcaoEscolhidaNumerica > 0)
            ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }
}

ExibirOpcoesDoMenu();
