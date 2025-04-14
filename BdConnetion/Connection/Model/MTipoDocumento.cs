using BdConnetion.Connection.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdConnetion.Connection.Model
{
    internal class MTipoDocumento : ITipoDocumento
    {
        public int IdTipoDocumento { get; set; }
        public string? Extencion { get; set; }
        public MTipoDocumento(int idTipoDocumento, string? extención)
        {
            IdTipoDocumento = idTipoDocumento;
            Extencion = extención;
        }
        public MTipoDocumento(string extencion)
        {
            Extencion = extencion;
        }
        public MTipoDocumento(int idTipoDocumento)
        {
            IdTipoDocumento = idTipoDocumento;
        }
    }
}
