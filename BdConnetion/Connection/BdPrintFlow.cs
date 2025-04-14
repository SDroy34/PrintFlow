using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;
using BdConnetion.Connection.Model;
using SharedLibrary.DTOs;


namespace BdConnetion.Connection
{
    public class BdPrintFlow : BdConnection
    {
        public BdPrintFlow(string path) : base(path)
        {

        }

        public void AddPrintFlow(DTOsCreatePrintFlow cpf)
        {
            try
            {

                AbrirBd();
                string query = "INSERT INTO PrintFlow (AliasDoc, CantCopias, NamePrinter, idTipoDocumento, Path, NamePrinFlow) " +
                    "VALUES (@aliasDoc, @cantCopias, @namePrinter, @IdTipoDocumento, @path, @namePrintFlow)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connectionBd))
                {
                    cmd.Parameters.AddWithValue("@aliasDoc", cpf.AliasDoc);
                    cmd.Parameters.AddWithValue("@cantCopias", cpf.CantCopias);
                    cmd.Parameters.AddWithValue("@namePrinter", cpf.NamePrinter);
                    cmd.Parameters.AddWithValue("@IdTipoDocumento", cpf.IdTipoDocumento);
                    cmd.Parameters.AddWithValue("@path", cpf.Path);
                    cmd.Parameters.AddWithValue("@namePrintFlow", cpf.NamePrinterFlow);
                    cmd.ExecuteNonQuery();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                CerrarBd();
            }
        }

        public List<string> TiposDocumentos()
        {
            List<string> strings = new List<string>();
            try
            {


                AbrirBd();
                var tipoDocumento = new List<MTipoDocumento>();
                string query = "SELECT idTipoDocumento, Extencion FROM TipoDocumento";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connectionBd))
                {
                    using (SQLiteDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            string Extencion = rd.GetString(1);
                            tipoDocumento.Add(new MTipoDocumento(Extencion));
                        }

                        var extn = new DTOsExtencion();

                        foreach (var tipo in tipoDocumento)
                        {
                            extn.Extencion = tipo.Extencion;
                            strings.Add(extn.Extencion);
                        }
                    }

                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine($"{ex}");
            }
            finally
            {
                CerrarBd();
            }
            return strings;

        }
        public int IdExtencion(string extencion)
        {
            int result = 0;
            try
            {
                AbrirBd();
                string query = "SELECT idTipoDocumento FROM TipoDocumento " +
                    "WHERE Extencion = @tipoExtencion";
                using (var cmd = new SQLiteCommand(query, connectionBd))
                {
                    cmd.Parameters.AddWithValue("@tipoExtencion", extencion);

                    using (SQLiteDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            result = rd.GetInt16(0);
                        }
                        if (result == 0)
                            throw new Exception("No es encontro el tipo de documento.");

                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine($"{ex}");
            }
            finally
            {
                CerrarBd();
            }
            return result;

        }
        public int ConcidenciasAlias(string Alias)
        {
            int res = 0;
            try
            {
                AbrirBd();
                string query = "SELECT COUNT(AliasDoc) FROM PrintFlow " +
                    "WHERE Upper(AliasDoc) = @Alias";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connectionBd))
                {
                    cmd.Parameters.AddWithValue("@Alias", Alias);
                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            res = rd.GetInt32(0);
                        }
                    }
                }
                if (res >= 1)
                    throw new Exception("Hay un alias con el mismo nombre.");
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine($"{ex}");
            }catch (Exception ex)
            {
                Console.WriteLine($"{ex}");
            }
            finally
            {
                CerrarBd();
            }
            return res;

        }
        public int ConcidenciasPrintFlow(string printFlow)
        {
            int res = 0;
            try
            {
                AbrirBd();
                string query = "SELECT COUNT(NamePrinFlow) FROM PrintFlow " +
                    "WHERE Upper(NamePrinFlow) = @printFlow";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connectionBd))
                {
                    cmd.Parameters.AddWithValue("@printFlow", printFlow);
                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            res = rd.GetInt32(0);
                        }
                    }
                }
                if (res >= 1)
                    throw new Exception("Hay un printFlow con el mismo nombre.");
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine($"{ex}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");
            }
            finally
            {
                CerrarBd();
            }
            return res;
        }
    }
}
