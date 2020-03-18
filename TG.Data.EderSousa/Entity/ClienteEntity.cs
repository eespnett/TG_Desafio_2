using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.Data.EderSousa.Entity
{
  public  class ClienteEntity
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public string Endereco { get; set; }

        public string Email { get; set; }

        public ClienteEntity()
        {
            ID = int.MinValue;
            Nome = string.Empty;
            Endereco = string.Empty;
            Email = string.Empty;
        }
    }
}
