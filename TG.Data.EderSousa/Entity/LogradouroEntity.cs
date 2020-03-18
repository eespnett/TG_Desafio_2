using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.Data.EderSousa.Entity
{
    public class LogradouroEntity
    {
        public int ID { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }

        public string CEP { get; set; }

        public LogradouroEntity()
        {
            ID = int.MinValue;
            Endereco = string.Empty;
            Bairro = string.Empty;
            CEP = string.Empty;
        }

    }
}
