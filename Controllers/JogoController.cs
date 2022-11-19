using Microsoft.AspNetCore.Mvc;

namespace monitoria_dotnet_webapi.Controllers;

[ApiController]
[Route("jogo")]
public class JogoController : ControllerBase
{
    private ContextoBancoDeDados ContextoBancoDeDados = new ContextoBancoDeDados();


    [HttpGet]
    public List<Jogo> Get() {
        DateTime now = DateTime.Now;
        var resultado = this.ContextoBancoDeDados
            .Set<Jogo>()
            .Where(jogo => jogo.Id > 0)
            .ToList();

        resultado
            .ForEach(jogo => {
                jogo.Genero = this.ContextoBancoDeDados
                    .Set<Genero>()
                    .Where(genero => genero.Id == jogo.GeneroId)
                    .First();
            });
        // var resultado = this.ContextoBancoDeDados.Jogo
        //     .Join(this.ContextoBancoDeDados.Genero, jogo => jogo.GeneroId, genero => genero.Id,
        //      (jogo, genero) => new 
        //         {
        //             Id = jogo.Id,
        //             Titulo = jogo.Titulo,
        //             Valor = jogo.Valor,
        //             FaixaEtaria = jogo.FaixaEtaria,
        //             Genero = genero,
        //             CriadoEm = jogo.CriadoEm,
        //             CriadoPor = jogo.CriadoPor,

        //         }).Where(jogo => jogo.Id > 0).Select(jogoGenero => new Jogo() 
        //         {
        //             Id = jogoGenero.Id,
        //             Titulo = jogoGenero.Titulo,
        //             Valor = jogoGenero.Valor,
        //             FaixaEtaria = jogoGenero.FaixaEtaria,
        //             Genero = jogoGenero.Genero,
        //             CriadoEm = jogoGenero.CriadoEm,
        //             CriadoPor = jogoGenero.CriadoPor,
        //         }).ToList();
        Console.WriteLine(DateTime.Now - now);
        return resultado;
    }

}
