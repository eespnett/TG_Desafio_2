using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TG.Data.EderSousa.Entity;
using TG.Data.EderSousa.Data;

namespace TG.Data.EderSousa.Business
{
  public  class LogradouroClientebusiness:LogradouroClienteData
    {

        public bool IncluirLogradouro(ClienteLogradouroEntity oClienteLogradouro)
        {
            bool returnSucess = false;


            returnSucess = base.IncluirLogradouro(oClienteLogradouro);

            return returnSucess;

        }

        public bool AtualidarClienteLogradouro(ClienteLogradouroEntity oClienteLogradouro)
        {
            bool returnSucess = false;


            returnSucess = base.AtualidarClienteLogradouro(oClienteLogradouro);


            return returnSucess;

        }

        [Obsolete]
        public List<ClienteLogradouroEntity> ListarLogradouroCliente(ClienteLogradouroEntity oClienteLogradouro)
        {
            List<ClienteLogradouroEntity> returnListClienteLogradouroEntity = new List<ClienteLogradouroEntity>();


            return= base.ListarLogradouroCliente(oClienteLogradouro);

            return returnListClienteLogradouroEntity;

        }


    }
}
