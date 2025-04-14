using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BdConnetion.Connection;
using SharedLibrary.DTOs;

namespace PrintFlow2.Busisnes.Services
{
    internal class FuncionesBd : BdPrintFlow
    {
        private readonly BdPrintFlow _bdPrintFlow;
        public FuncionesBd(string path) : base (path)
        {

        }
        public List<string> Extenciones()
        {
           var dTOsExtencions = _bdPrintFlow.TiposDocumentos();
            
            return dTOsExtencions;
        }
        public void CreatePrintFlow(DTOsCreatePrintFlow dTCPt)
        {
            _bdPrintFlow.AddPrintFlow(dTCPt);
        }
    }
}
