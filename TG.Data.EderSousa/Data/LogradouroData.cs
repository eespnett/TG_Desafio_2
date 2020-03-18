using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TG.Data.EderSousa.Entity;

namespace TG.Data.EderSousa.Data
{
    class LogradouroData
    {
        public bool IncluirLogradouro(LogradouroEntity oLogradouro)
        {
            bool returnSucess = false;



            try
            {
                using (ContextModel.Model myModel = new ContextModel.Model())
                {
                    myModel.Add(oLogradouro);

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

        public bool AtualidarLogradouro(LogradouroEntity oLogradouro)
        {
            bool returnSucess = false;



            try
            {
                using (var myModel = new ContextModel.Model())
                {
                    ClienteEntity updateCliente = new ClienteEntity();



                    myModel.Update(oLogradouro);

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
        public List<LogradouroEntity> ListarLogradouros(LogradouroEntity oLogradouro)
        {
            List<LogradouroEntity> returnListLogradouroEntity = new List<LogradouroEntity>();



            try
            {
                using (var myModel = new ContextModel.Model())
                {



                    returnListLogradouroEntity = myModel.Query<LogradouroEntity>().ToList();


                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return returnListLogradouroEntity;

        }

        [Obsolete]
        internal List<LogradouroEntity> SelecionarLogradouroPorCliente(ClienteEntity myCliente, LogradouroEntity myLogradouro)
        {
            List<LogradouroEntity> retorno = new  List<LogradouroEntity>();

            try
            {
                using (var myModel = new ContextModel.Model())
                {



                    retorno = myModel.Query<LogradouroEntity>().ToList().Where(x => x.CEP == myLogradouro.CEP && x.Bairro == myLogradouro.Bairro && x.Endereco == myLogradouro.Endereco).ToList();
                    retorno = (from item in retorno
                               join item2 in myModel.Query<ClienteLogradouroEntity>().ToList()
                               on item.ID equals item2.IDLogradouro
                               where item2.IDCliente == myCliente.ID
                               select item).ToList();
                          


                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return retorno;
        }
    }
}
