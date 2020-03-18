using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TG.Data.EderSousa.Entity;


namespace TG.Data.EderSousa.Data
{
    class LogradouroClienteData
    {

        public bool IncluirLogradouro(ClienteLogradouroEntity oClienteLogradouro)
        {
            bool returnSucess = false;



            try
            {
                using (ContextModel.Model myModel = new ContextModel.Model())
                {
                    myModel.Add(oClienteLogradouro);

                    myModel.SaveChanges();

                    returnSucess = true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return returnSucess;

        }

        public bool AtualidarClienteLogradouro(ClienteLogradouroEntity oClienteLogradouro)
        {
            bool returnSucess = false;



            try
            {
                using (var myModel = new ContextModel.Model())
                {
                  

                    myModel.Update(oClienteLogradouro);

                    myModel.SaveChanges();

                    returnSucess = true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return returnSucess;

        }

        [Obsolete]
        public List<ClienteLogradouroEntity> ListarLogradouroCliente(ClienteLogradouroEntity oClienteLogradouro)
        {
            List<ClienteLogradouroEntity> returnListClienteLogradouroEntity = new List<ClienteLogradouroEntity>();



            try
            {
                using (var myModel = new ContextModel.Model())
                {



                    var retorno = myModel.Query<ClienteLogradouroEntity>().ToList().Where(x=>x.IDCliente==oClienteLogradouro.IDCliente);

                    foreach (var item in retorno)
                    {
                        returnListClienteLogradouroEntity.Add(new ClienteLogradouroEntity() { ID=item.ID, IDCliente=item.IDCliente,IDLogradouro=item.IDLogradouro});
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return returnListClienteLogradouroEntity;

        }


    }
}
