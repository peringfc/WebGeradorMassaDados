using Microsoft.AspNetCore.Mvc;
using WebGeradorMassaDados.Regras;

namespace WebGeradorMassaDados.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GerarNomeLista : Controller
    {
        [HttpGet(Name = "Gerador Nome Lista")]
        public List<string> Nome(string sexo, int QtdeNomesGerar)
        {
            List<string> ListNome = new List<string>();
            Nomes nomes = new Nomes();
            for (int i = 0; i < QtdeNomesGerar; i++)
            {
                ListNome.Add(nomes.nome(sexo).Trim().TrimEnd().TrimStart());
            }
            return ListNome;
        }
    }

}
