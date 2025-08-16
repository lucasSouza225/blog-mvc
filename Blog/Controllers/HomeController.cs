using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Blog.Models;

namespace Blog.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["Mensagem"] = "Olá, mundo!";

        Categoria anime = new();
        anime.Id = 1;
        anime.Nome = "Anime";

        Categoria filme = new() {
            Id = 2,
            Nome = "Filme"
        };

        List<Postagem> postagens = [
            new() {
                Id = 1,
                Nome = "Demon Slayer: Kimetsu no Yaiba : Castelo Infinito",
                CategoriaId = 2,
                Categoria = filme,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "Demon Slayer: Kimetsu no Yaiba : Castelo Infinito estreia no Brasil em 11 de setembro, com pré-venda de ingressos começando em 15 de agosto",
                Texto = "O filme Demon Slayer: Kimetsu no Yaiba / Castelo Infinito estreia no Brasil em 11 de setembro, com pré-venda de ingressos começando em 15 de agosto. O filme adaptará o arco do Castelo Infinito do mangá e anime, mostrando Tanjiro e os Hashira enfrentando Muzan e seus demônios no castelo. ",
                Thumbnail = "/img/1.jpg",
                Foto = "/img/1.jpg"
            },
             new() {
                Id = 2,
                Nome = "Black Clover - A Espada do Rei Mago",
                CategoriaId = 2,
                Categoria = filme,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "O filme Black Clover: A Espada do Rei Mago narra uma história original que se passa entre o Arco da Reencarnação dos Elfos e o Arco da Luta Conjunta do Reino Heart",
                Texto = "O filme Black Clover: A Espada do Rei Mago narra uma história original que se passa entre o Arco da Reencarnação dos Elfos e o Arco da Luta Conjunta do Reino Heart. A trama central gira em torno de Conrad Leto, o 27º Rei Mago, que foi banido e retorna com o objetivo de destruir o Reino Clover, revivendo três outros Reis Magos com a Espada Imperial. Asta e os Cavaleiros Mágicos precisam unir forças para impedir a ameaça e proteger o reino.",
                Thumbnail = "/img/2.jpg",
                Foto = "/img/2.jpg"
            }, 
            new() {
                Id = 3,
                Nome = "Kaiju No. 8",
                CategoriaId = 1,
                Categoria = anime,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "Kaiju No. 8 é um mangá e anime que se passa em um mundo onde criaturas gigantes chamadas Kaiju aparecem e causam destruição.",
                Texto = "Kaiju No. 8 é um mangá e anime que se passa em um mundo onde criaturas gigantes chamadas Kaiju aparecem e causam destruição. A história segue Kafka Hibino, um homem que trabalha na limpeza de restos de Kaiju após os ataques, e que, por um evento inesperado, se torna capaz de se transformar em um Kaiju, ganhando o codinome Kaiju No. 8. ",
                Thumbnail = "/img/3.jpg",
                Foto = "/img/3.jpg"
            },
            new() {
                Id = 4,
                Nome = "Clevatess",
                CategoriaId = 1,
                Categoria = anime,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "Um rei demônio que, após ser caçado por 13 heróis, acaba cuidando de um bebê humano.",
                Texto = "Clevatess é o protagonista de uma série de anime, descrito como um rei demônio que, após ser caçado por 13 heróis, acaba cuidando de um bebê humano. Ele é conhecido por sua força e inteligência, mas também por sua frustração com os heróis, que o levaram a querer eliminar a humanidade. No entanto, a chegada do bebê muda seus planos e ele se vê obrigado a protegê-lo, junto com uma heroína ressuscitada chamada Alicia. ",
                Thumbnail = "/img/4.jpg",
                Foto = "/img/4.jpg"
            },
            new() {
                Id = 5,
                Nome = "Fullmetal Alchemis",
                CategoriaId = 1,
                Categoria = anime,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "Série de mangá e anime criada por Hiromu Arakawa, que segue a história dos irmãos Elric, Edward e Alphonse, em sua busca pela lendária Pedra Filosofal.",
                Texto = "Fullmetal Alchemist é uma série de mangá e anime criada por Hiromu Arakawa, que segue a história dos irmãos Elric, Edward e Alphonse, em sua busca pela lendária Pedra Filosofal. Após uma tentativa fracassada de ressurreição da mãe usando alquimia, eles sofrem graves consequências físicas: Edward perde um braço e uma perna, e Alphonse perde seu corpo inteiro, tendo sua alma presa a uma armadura. A partir daí, a trama se desenrola com a jornada dos irmãos para recuperar seus corpos, enquanto se envolvem em intrigas políticas e confrontos com seres poderosos conhecidos como Homúnculos. ",
                Thumbnail = "/img/5.jpg",
                Foto = "/img/5.jpg"
            },
             new() {
                Id = 6,
                Nome = "Haikyuu ",
                CategoriaId = 2,
                Categoria = filme,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "O filme foca na tão aguardada Batalha do Lixo, um confronto entre as escolas Karasuno e Nekoma no campeonato nacional.",
                Texto = "O filme foca na tão aguardada Batalha do Lixo, um confronto entre as escolas Karasuno e Nekoma no campeonato nacional. A história mostra o desenvolvimento da rivalidade entre Hinata e Kageyama, que se unem para enfrentar o time Nekoma, liderado por Kenma Kozume, um amigo de infância de Hinata. ",
                Thumbnail = "/img/6.jpg",
                Foto = "/img/6.jpg"
            }
        ];

        return View(postagens);
    }

    public IActionResult Postagem(int id)
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
