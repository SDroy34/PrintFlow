using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFlow2.Busisnes.Services
{
    internal class SelectPrint
    {
        public static List<string> NombresImpresoras()
        {
            var printerName = new List<String>();
            foreach(var print in PrinterSettings.InstalledPrinters)
            {
                printerName.Add(print.ToString());
            }
            return printerName;

        }
        
    }
}
