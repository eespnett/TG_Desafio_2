using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TG.Data.EderSousa;

namespace TG.Desafio.EderSousa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;


        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
        }
        [HttpPost]
        public bool IncluirCliente(TG.Data.EderSousa.Entity.ClienteEntity myCliente)
        {
            bool retorno = false;

            retorno = new TG.Data.EderSousa.Business.ClienteBusiness().IncluirCliente(myCliente);

            return retorno;
        }

        [HttpPost]
        public bool AtualizarCliente(TG.Data.EderSousa.Entity.ClienteEntity myCliente)
        {
            bool retorno = false;

            retorno = new TG.Data.EderSousa.Business.ClienteBusiness().AtualidarCliente(myCliente);

            return retorno;
        }

        [HttpPost]
        [Obsolete]
        public List<TG.Data.EderSousa.Entity.ClienteEntity> ListarCliente(TG.Data.EderSousa.Entity.ClienteEntity myCliente)
        {
            List<TG.Data.EderSousa.Entity.ClienteEntity> retorno = new List<TG.Data.EderSousa.Entity.ClienteEntity>();

            retorno = new TG.Data.EderSousa.Business.ClienteBusiness().ListarClientes(myCliente);

            return retorno;
        }

    }
}
