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
    public class LogradouroController : ControllerBase
    {
      


        private readonly ILogger<LogradouroController> _logger;

        public LogradouroController(ILogger<LogradouroController> logger)
        {
            _logger = logger;
        }


        public bool IncluirLogradouro(TG.Data.EderSousa.Entity.LogradouroEntity myLogradouro, TG.Data.EderSousa.Entity.ClienteEntity myCliente)
        {
            bool retorno = false;

            retorno = new TG.Data.EderSousa.Business.LogradouroBusiness().IncluirLogradouro(myLogradouro, myCliente);

            return retorno;
        }

        [HttpPost]
        public bool AtualizarLogradouro(TG.Data.EderSousa.Entity.LogradouroEntity myLougradouro)
        {
            bool retorno = false;

            retorno = new TG.Data.EderSousa.Business.LogradouroBusiness().AtualidarLogradouro(myLougradouro);

            return retorno;
        }

        [HttpPost]
        [Obsolete]
        public List<TG.Data.EderSousa.Entity.LogradouroEntity> ListarLogradouro(TG.Data.EderSousa.Entity.LogradouroEntity myLougradouro)
        {
            List<TG.Data.EderSousa.Entity.LogradouroEntity> retorno = new List<TG.Data.EderSousa.Entity.LogradouroEntity>();

            retorno = new TG.Data.EderSousa.Business.LogradouroBusiness().ListarLogradouro(myLougradouro);

            return retorno;
        }



    }
}
