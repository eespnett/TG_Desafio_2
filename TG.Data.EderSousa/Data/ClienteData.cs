using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TG.Data.EderSousa.Entity;

namespace TG.Data.EderSousa.Data
{
    class ClienteData
    {
        public bool IncluirCliente(ClienteEntity oCliente)
        {
            bool returnSucess = false;



            try
            {
                using (ContextModel.Model myModel = new ContextModel.Model())
                {
                    myModel.Add(oCliente);

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

        public bool AtualidarCliente(ClienteEntity oCliente)
        {
            bool returnSucess = false;



            try
            {
                using (var myModel = new ContextModel.Model())
                {
                    ClienteEntity updateCliente = new ClienteEntity();

             

                    myModel.Update(oCliente);

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
        public List<ClienteEntity> ListarClientes(ClienteEntity oCliente)
        {
            List<ClienteEntity> returnListClienteEntity = new List<ClienteEntity>();



            try
            {
                using (var myModel = new ContextModel.Model())
                {



                    returnListClienteEntity = myModel.Query<ClienteEntity>().ToList();

                    
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return returnListClienteEntity;

        }


    }
}
