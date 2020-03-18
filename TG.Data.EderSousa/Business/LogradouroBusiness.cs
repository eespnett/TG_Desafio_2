using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TG.Data.EderSousa.Data;
using TG.Data.EderSousa.Entity;


namespace TG.Data.EderSousa.Business
{
    public class LogradouroBusiness : LogradouroData
    {
        [Obsolete]
        public bool IncluirLogradouro(LogradouroEntity oLogradouro, ClienteEntity myCliente)
        {
            bool returnSucess = false;

            int intVerificarLogradouroPAraCliente = new LogradouroBusiness().SelecionarLogradouroPorCliente(myCliente, oLogradouro).Count
                ;
            if (intVerificarLogradouroPAraCliente>1) // se não tem esse endereço cadastrado para esse cliente
            {
    returnSucess = this.IncluirLogradouro(oLogradouro);
            }
        

            return returnSucess;

        }

        public bool AtualidarLogradouro(LogradouroEntity oLogradouro)
        {
            bool returnSucess = false;

            returnSucess = base.AtualidarLogradouro(oLogradouro);


            return returnSucess;

        }

        [Obsolete]
        public List<LogradouroEntity> ListarLogradouro(LogradouroEntity oLogradouro)
        {
            List<LogradouroEntity> returnListLogradouroEntity = new List<LogradouroEntity>();

            returnListLogradouroEntity = base.ListarLogradouros(oLogradouro);


            return returnListLogradouroEntity;

        }


        [Obsolete]
        public List<LogradouroEntity> SelecionarLogradouroCliente(ClienteEntity myCliente, LogradouroEntity myLogradouro)
        {
            List<LogradouroEntity> returnLogradouroEntity = new List<LogradouroEntity>();

            returnLogradouroEntity = SelecionarLogradouroPorCliente(myCliente, myLogradouro);


            return returnLogradouroEntity;

        }


    }
}
