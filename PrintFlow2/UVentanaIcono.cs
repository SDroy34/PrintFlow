using PrintFlow2.Busisnes.ConfNontIcon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintFlow2
{
    public partial class UVentanaIcono : UserControl
    {
        private TrayIconManager _tray ;
        
        public UVentanaIcono()
        {
            InitializeComponent();
        }
        private void MostrarInicio()
        {
            if (this.ParentForm is Form formActual)
            {
                formActual.Hide();
                var inicio = new FInicio();
                inicio.FormClosed += (s, e) => formActual.Close();
                inicio.Show();
            }
        }
        private void CerrarApp()
        {

            TrayIconManager.IconM.DisposeResources();
            Application.Exit();
        }
        
        private void BtnRegresarInc_Click(object sender, EventArgs e)
        {
            MostrarInicio();
        }

        private void BtnCerraApp_Click(object sender, EventArgs e)
        {
            CerrarApp();
        }
    }
}
