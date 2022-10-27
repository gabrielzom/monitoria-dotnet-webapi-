using Microsoft.AspNetCore.Mvc;

namespace monitoria_dotnet_webapi.Controllers;

[ApiController]
[Route("jogo")]
public class JogoController : ControllerBase
{

    [HttpGet]
    public List<Jogo> Get() {
        List<Jogo> jogos = new List<Jogo>();
        return jogos;
    }

}
