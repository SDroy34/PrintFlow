using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.DTOs
{
    public class DTOsCreatePrintFlow
    {
        public string AliasDoc { get; set; }
        public int CantCopias { get; set; }
        public string NamePrinter { get; set; }
        public int IdTipoDocumento {  get; set; }
        public string Path {  get; set; }
        public string NamePrinterFlow { get; set; }
    }
}
