using PrintFlow2.Busisnes.Services;
using SharedLibrary.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintFlow2
{
    public partial class FCreatePrintFlow : Form
    {

        private string _path;
        private string _namePrintFlow;
        private string _selecPrint;
        private string _selecDoc;
        private string _aliasDocument;
        private string _tipoDocument;
        private int _cantCopias;
        public FCreatePrintFlow()
        {

            try
            {
                var obtenerInf = Busisnes.Services.ObtenerInfBase.InfBase;
                DTOsExtencion dTOs = new DTOsExtencion();
                InitializeComponent();
                ConfiguracionesDeBox.AllBoxConf(CbxImpresoras, SelectPrint.NombresImpresoras());
                ConfiguracionesDeBox.AllBoxConf(CbxTipoDocumento, obtenerInf.Extenciones());
                ConfiguracionesDeBox.AllBoxConf(TbxNamePrintFlow, 100);
                ConfiguracionesDeBox.AllBoxConf(TbxAliasDoc, 50, "'ReciboDePago'");
                NudCopias.Minimum = 1;

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"{ex}");
                FInicio fInicio = new FInicio();
                this.Hide();
                fInicio.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
                FInicio fInicio = new FInicio();
                this.Hide();
                fInicio.ShowDialog();
                this.Close();
            }

        }

        private async void BtnAddPrintFlow_Click(object sender, EventArgs e)
        {
            var obtenerInf = Busisnes.Services.ObtenerInfBase.InfBase;
            int idTipDoc = 0; bool concAlias = false, conPrintFlow = false;
            try
            {
                var task2 = new Task(() =>
                {
                    concAlias = obtenerInf.AliasConcidencias(_aliasDocument);
                });
                var task3 = new Task(() =>
                {
                    conPrintFlow = obtenerInf.NamePFConcidencias(_namePrintFlow);
                });
                task2.Start();
                await task2;
                task3.Start();
                await task3;
                if (String.IsNullOrWhiteSpace(_path)) { MessageBox.Show("Selecciona una carpeta para el Print Flow."); }
                else if (NudCopias.Value == 0) { MessageBox.Show("El numero de impresiones no debede ser cero."); }
                else if (String.IsNullOrEmpty(_namePrintFlow)) { MessageBox.Show("Ingrese el nombre del Pirnt Flow."); }
                else if (!concAlias) { MessageBox.Show("Hay un alias registrado con ese mismo nombre"); }
                else if (!conPrintFlow) { MessageBox.Show("Hay un Nombre de print flow registrado con el mismo nombre."); }
                else
                {
                    Task task1 = new Task(() =>
                    {
                        idTipDoc = obtenerInf.TipoDoc(_tipoDocument);

                    });

                    task1.Start();
                    await task1;
                    var DtosCrate = new DTOsCreatePrintFlow()
                    {
                        NamePrinterFlow = _namePrintFlow,
                        NamePrinter = _selecPrint,
                        IdTipoDocumento = idTipDoc,
                        AliasDoc = _aliasDocument,
                        CantCopias = _cantCopias,
                        Path = _path
                    };
                    obtenerInf.CreatePrintFlow(DtosCrate);
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"{ex}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            finally
            {
                FInicio fInicio = new FInicio();
                this.Hide();
                fInicio.ShowDialog();
                this.Close();
            }
        }

        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            string path = ShowFolderDialog.PachtFolder();
            _path = path;
            LblPathFolder.Text = path;


        }

        private void TbxNamePrintFlow_TextChanged(object sender, EventArgs e)
        {
            string namePrinFlow = TbxNamePrintFlow.Text;
            _namePrintFlow = namePrinFlow;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string AliasDocumento = TbxAliasDoc.Text;
            _aliasDocument = AliasDocumento;
        }

        private void CbxImpresoras_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectImpresora = CbxImpresoras.SelectedItem as string;
            _selecPrint = selectImpresora;
        }

        private void CbxTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectDoc = CbxTipoDocumento.SelectedItem as string;
            _tipoDocument = selectDoc;
        }

        private void NudCopias_ValueChanged(object sender, EventArgs e)
        {

            var cantCopias = NudCopias.Value;
            int.TryParse(cantCopias.ToString(), out _cantCopias);
        }
    }
}
