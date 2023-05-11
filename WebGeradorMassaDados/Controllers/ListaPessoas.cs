using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebGeradorMassaDados.Regras;

namespace WebGeradorMassaDados.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ListaPessoas : Controller
    {
        [HttpGet(Name = "Gerador ListaPessoas")]
        public List<WebGeradorMassaDados.Objetos.Pessoa> CriarLista(int IdadeInicial, 
                    int IdadeFinal , 
                    int QuantasPessoas)
        {
            List<WebGeradorMassaDados.Objetos.Pessoa> pessoas 
                = new List<WebGeradorMassaDados.Objetos.Pessoa>();

            Fabricar fabricar = new Fabricar();
            for (int i = 0; i < QuantasPessoas; i++)
            {
                pessoas.Add(fabricar.Criar(IdadeInicial, IdadeFinal));
            }
            return pessoas; 
        }
    }
}
