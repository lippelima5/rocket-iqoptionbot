using IqOptionApiDotNet.Models;
using IqOptionApiDotNet.Models.BinaryOptions;
using IqOptionApiDotNet.Models.DigitalOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketBuy.Models
{
    public class Log
    {

        public DateTime Hora { set; get; }
        public string IdOrEmail { set; get; }
        public string Titulo { set; get; }
        public string Message { set; get; }

        public BinaryOptionsResult BinaryResult { set; get; }
        public DigitalOptionsPlacedResult DigitalResult { set; get; }

    }
}
