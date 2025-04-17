using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFlow2.Busisnes.Strategy
{
    public class PdfStrategy 
    {
        private static readonly PdfStrategy _pfdInsatance = new PdfStrategy();
        public static PdfStrategy PdfInstance { get { return _pfdInsatance;}}

        private PdfStrategy()
        {
            
        }
        public  void PrintDoc(string path, int copias, string namePrint )
        {
            if (!File.Exists(path))
            {
                MessageBox.Show("El archivo no existe");
            }
            try
            {
                short.TryParse(copias.ToString(), out short copiasShort);
                using (var print = new PrintDocument())
                {
                    print.PrinterSettings.PrinterName = namePrint;
                    print.PrinterSettings.Copies = copiasShort;
                    print.PrintController = new StandardPrintController();
                    print.Print();
                }

            }
            catch(Exception ex) { MessageBox.Show($"{ex}"); }
        }
    }
}
