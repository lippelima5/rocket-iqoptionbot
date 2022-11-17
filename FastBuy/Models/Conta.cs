using IqOptionApiDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketBuy.Models
{
  public  class Conta
    {
        public string Email { set; get; }
        public string Senha { set; get; }
        public int Entrada { set; get; }
        public bool OperarReal { set; get; }

        public IqOptionApiDotNetClient Client { set; get; }
    }
}
