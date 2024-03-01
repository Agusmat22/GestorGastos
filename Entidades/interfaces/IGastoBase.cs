using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.interfaces
{
    public interface IGastoBase : IGastoServicios, IGastoImprevisto, IGastoNecesidad, IGastoOcio
    {
        public double GastoBase { get; set; }
    }
}
