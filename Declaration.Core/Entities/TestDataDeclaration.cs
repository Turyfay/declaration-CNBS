using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Declaration.Core.Entities
{
    public class TestDataDeclaration
    {
        //public required BigInteger nroTransaccion { get; set; }

        //public required DateTime fechaHoraTrn { get; set; }

        public required string fechaAConsultar { get; set; }

        public required int cuentaDeclaraciones { get; set; }

        public required string datosComprimidos { get; set; }
    }
}
