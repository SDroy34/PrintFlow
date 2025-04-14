using BdConnetion.Connection.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdConnetion.Connection.Model
{
    internal class MPrintFlow : IPrintFlow
    {
        public int IdPrintFlow { get; }
        public string? AliasDoc { get; set; }
        public int CantCopias { get; set; }
        public string? NamePrinter { get; set; }
        public int? IdTipoDocumento { get; set; }
        public string? Path { get; set; }
        public string? NamePrintFlow { get; set; }
    }
}
