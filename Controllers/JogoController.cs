using Microsoft.AspNetCore.Mvc;

namespace monitoria_dotnet_webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class JogoController : ControllerBase
{

    [HttpGet]
    public List<Jogo> Get() {
        List<Jogo> jogos = new List<Jogo>();

        var jogo1 = new Jogo();
        var jogo2 = new Jogo();

        jogo1.Id = 1;
        jogo1.Nome = "GOD OF WAR";
        jogo1.Valor = 199.00;
        jogo1.CriadoPor = 9;
        jogo1.CriadoEm = new DateTime();

        jogo2.Id = 2;
        jogo2.Nome = "FIFA 2020";
        jogo2.Valor = 280.00;
        jogo2.CriadoPor = 2;
        jogo2.CriadoEm = new DateTime();

        jogos.Add(jogo1);
        jogos.Add(jogo2);

        return jogos;
    }

}
