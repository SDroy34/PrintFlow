using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdConnetion.Connection.Interface
{
    internal interface IPrintFlow
    {
        int IdPrintFlow { get; }
        string? AliasDoc { get; set; }
        int CantCopias { get; set; }
        string? NamePrinter { get; set; }
        int? IdTipoDocumento { get; set; }
        string? Path { get; set; }
        string? NamePrintFlow { get; set; }
    }
}
