using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdConnetion.Connection.Model
{
    internal class MPrintFlow
    {
        public int IdPrintFlow { get; set; }
        public string AliasDoc { get; set; }
        public int CantCopias { get; set; }
        public string NamePrinter { get; set; }
        public int IdDocument { get; set; }
        public string Path {  get; set; }
        public string NamePrinFlow { get; set; }
    }
}
