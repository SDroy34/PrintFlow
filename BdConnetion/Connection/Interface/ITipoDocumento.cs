using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdConnetion.Connection.Interface
{
    internal interface ITipoDocumento
    {
        int IdTipoDocumento { get; set; }
        string? Extencion { get; set; }
    }
}
