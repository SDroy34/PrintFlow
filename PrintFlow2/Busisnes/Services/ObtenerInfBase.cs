using BdConnetion.Connection;
using SharedLibrary.DTOs;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFlow2.Busisnes.Services
{
    public class ObtenerInfBase
    {
        private static readonly ObtenerInfBase _infBase = new ObtenerInfBase();
        private static readonly object _lock = new object();
        private BdPrintFlow _bd = new BdPrintFlow(_pathDataBase);
        private const string _pathDataBase = @"C:\Users\asgar\source\repos\PrintFlow\DataBase\PrintFlowDb.db";
        public static ObtenerInfBase InfBase
        {
            get {
                return _infBase;
            }
        }
        private ObtenerInfBase() { }

        public  List<string> Extenciones()
        {
            var dTOsExtencions = _bd.TiposDocumentos();

            return dTOsExtencions;
        }
        public void CreatePrintFlow(DTOsCreatePrintFlow dTCPt)
        {
            _bd.AddPrintFlow(dTCPt);
        }
        public bool AliasConcidencias(string alias)
        {
            int res =_bd.ConcidenciasAlias(alias.ToUpper());
            return res == 1 ? true : false;
        }
        public bool NamePFConcidencias(string nPF)
        {
            int res = _bd.ConcidenciasPrintFlow(nPF.ToUpper());
            return res == 1 ? true : false;
        }
        public int TipoDoc(string extencion)
        {
            int tipo = _bd.IdExtencion(extencion);
            return tipo;
        }
    }
}
