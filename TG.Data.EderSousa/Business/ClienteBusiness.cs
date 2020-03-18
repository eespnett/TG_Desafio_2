using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TG.Data.EderSousa.Entity;

using TG.Data.EderSousa.Data;

namespace TG.Data.EderSousa.Business
{
    public class ClienteBusiness : ClienteBusiness
    {
        public bool IncluirCliente(ClienteEntity oCliente)
        {
            bool returnSucess = false;

            returnSucess=  base.IncluirCliente(oCliente);

            return returnSucess;

        }

        public bool AtualidarCliente(ClienteEntity oCliente)
        {
            bool returnSucess = false;


            returnSucess=    base.AtualidarCliente(oCliente);

            return returnSucess;

        }

        [Obsolete]
        public List<ClienteEntity> ListarClientes(ClienteEntity oCliente)
        {
            List<ClienteEntity> returnListClienteEntity = new List<ClienteEntity>();


            returnListClienteEntity = base.ListarClientes(oCliente);
           

            return returnListClienteEntity;

        }

    }
}
